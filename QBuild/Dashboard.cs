using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QBuild
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }

        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=qbuild.accdb");

        private Dictionary<string, NAryTreeNode> map = new Dictionary<string, NAryTreeNode>();

        private void populateData_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                List<List<string>> bom = get_bom();
                con.Close();
                
                NAryTreeNode root = convert_to_tree(bom);
                Boolean isLoaded = load_treeview(root, treeView.Nodes);

                if (isLoaded)
                {
                    MessageBox.Show("Data Loaded", "Message");
                    populateData.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Data Loading Faild!", "Message");
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string current_node = e.Node.Text;
            set_label_text((e.Node.Parent != null) ? e.Node.Parent.Text : "", current_node);

            try
            {
                load_gridview(current_node);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit application?", "Message", MessageBoxButtons.YesNo) ==
       DialogResult.Yes) Application.Exit();
        }

        private void set_label_text(string parent, string current)
        {
            parentChildLabel.Text = "Parent Child Part: " + parent + "\\" + current;

            currentPartLabel.Text = "Current Part: " + current;
        }

        private List<List<string>> get_bom()
        {
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Bom";
            cmd.Connection = con;
            OleDbDataReader reader = cmd.ExecuteReader();

            List<List<string>> bom = new List<List<string>>();
            while (reader.Read())
            {
                List<string> row = new List<string>();
                //PARENT_NAME
                row.Add(reader[1].ToString());
                //QUANTITY
                row.Add(reader[2].ToString());
                //COMPONENT_NAME
                row.Add(reader[3].ToString());
                bom.Add(row);
            }

            return bom;
        }

        private List<string> get_part(string part_name)
        {
            OleDbCommand cmd = con.CreateCommand();
            string query = @"select * from Part where NAME = ""{0}""";
            cmd.CommandText = String.Format(query, part_name);
            cmd.Connection = con;
            OleDbDataReader reader = cmd.ExecuteReader();

            List<string> part = new List<string>();
            while (reader.Read())
            {
                //NAME
                part.Add(reader[1].ToString());
                //TYPE
                part.Add(reader[2].ToString());
                //ITEM
                part.Add(reader[3].ToString());
                //PART_NAME
                part.Add(reader[4].ToString());
                //TITLE
                part.Add(reader[5].ToString());
                //MATERIAL
                part.Add(reader[6].ToString());
            }

            return part;
        }

        private NAryTreeNode convert_to_tree(List<List<string>> bom)
        {

            NAryTreeNode root = null;

            foreach (List<string> row in bom)
            {
                string parent_name = row[0];
                int quantity = Int32.Parse(row[1]);
                string child_name = row[2];

                if (parent_name == "")
                {
                    if (map.ContainsKey(child_name))
                    {
                        map[child_name].quantity = quantity;
                    }
                    else
                    {
                        NAryTreeNode current = new NAryTreeNode(child_name, quantity);
                        map[child_name] = current;
                    }

                    root = map[child_name];
                }
                else
                {
                    if (map.ContainsKey(parent_name))
                    {
                        NAryTreeNode current = new NAryTreeNode(child_name, quantity);
                        map[parent_name].children.Add(current);
                        map[child_name] = current;
                    }
                    else
                    {
                        NAryTreeNode parent = new NAryTreeNode(parent_name);
                        NAryTreeNode current = new NAryTreeNode(child_name, quantity);
                        parent.children.Add(current);
                        map[parent_name] = parent;
                        map[child_name] = current;
                    }
                }
            }

            return root;
        }

        private Boolean load_treeview(NAryTreeNode current_tree_node, TreeNodeCollection current_level)
        {
            if (current_tree_node == null) return false;

            int node_index = current_level.IndexOf(current_level.Add(current_tree_node.name));

            if (current_tree_node.children.Count == 0) return true;
            

            foreach (NAryTreeNode child in current_tree_node.children)
            {
                load_treeview(child, current_level[node_index].Nodes);
            }

            return true;
        }

        private void load_gridview(string current_node)
        {
            dataGridView.Rows.Clear();

            List<List<string>> part_result = get_selected_part_detail(current_node);

            if (!map.ContainsKey(current_node) ||
                map[current_node].children.Count == 0 ||
                part_result.Count == 0) throw new Exception("Could not find any records");


            for (int i = 0; i < part_result.Count; i++)
            {
                dataGridView.Rows.Add();
                DataGridViewRow row = dataGridView.Rows[i];

                if (i % 2 != 0) row.DefaultCellStyle.BackColor = Color.Tomato;

                row.Cells[0].Value = current_node;
                row.Cells[1].Value = map[part_result[i][0]].quantity;

                for (int j = 0; j < part_result[i].Count; j++)
                {
                    row.Cells[j + 2].Value = part_result[i][j];
                }

            }
        }

        private List<List<string>> get_selected_part_detail(string current_node)
        {
            List<List<string>> part_result = new List<List<string>>();
            con.Open();
            foreach (NAryTreeNode child in map[current_node].children)
            {
                List<string> part = get_part(child.name);
                if (part.Count > 0) part_result.Add(part);

            }
            con.Close();
            return part_result;
        }
    }
}
