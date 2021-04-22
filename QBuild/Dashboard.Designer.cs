namespace QBuild
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.treeGroupBox = new System.Windows.Forms.GroupBox();
            this.exit = new System.Windows.Forms.Button();
            this.populateData = new System.Windows.Forms.Button();
            this.currentPartLabel = new System.Windows.Forms.Label();
            this.parentChildLabel = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.PARENT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPONENT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PART_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(196, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(415, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Tesing Functionality for Tree and Datagrid";
            // 
            // treeGroupBox
            // 
            this.treeGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.treeGroupBox.Controls.Add(this.exit);
            this.treeGroupBox.Controls.Add(this.populateData);
            this.treeGroupBox.Controls.Add(this.currentPartLabel);
            this.treeGroupBox.Controls.Add(this.parentChildLabel);
            this.treeGroupBox.Controls.Add(this.treeView);
            this.treeGroupBox.Location = new System.Drawing.Point(12, 37);
            this.treeGroupBox.Name = "treeGroupBox";
            this.treeGroupBox.Size = new System.Drawing.Size(776, 213);
            this.treeGroupBox.TabIndex = 1;
            this.treeGroupBox.TabStop = false;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(348, 152);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(158, 23);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit From Application";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // populateData
            // 
            this.populateData.Location = new System.Drawing.Point(348, 106);
            this.populateData.Name = "populateData";
            this.populateData.Size = new System.Drawing.Size(158, 23);
            this.populateData.TabIndex = 3;
            this.populateData.Text = "Populate Data in Tree";
            this.populateData.UseVisualStyleBackColor = true;
            this.populateData.Click += new System.EventHandler(this.populateData_Click);
            // 
            // currentPartLabel
            // 
            this.currentPartLabel.AutoSize = true;
            this.currentPartLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.currentPartLabel.Location = new System.Drawing.Point(345, 67);
            this.currentPartLabel.Name = "currentPartLabel";
            this.currentPartLabel.Size = new System.Drawing.Size(69, 13);
            this.currentPartLabel.TabIndex = 2;
            this.currentPartLabel.Text = "Current Part: ";
            // 
            // parentChildLabel
            // 
            this.parentChildLabel.AutoSize = true;
            this.parentChildLabel.ForeColor = System.Drawing.Color.Tomato;
            this.parentChildLabel.Location = new System.Drawing.Point(345, 32);
            this.parentChildLabel.Name = "parentChildLabel";
            this.parentChildLabel.Size = new System.Drawing.Size(92, 13);
            this.parentChildLabel.TabIndex = 1;
            this.parentChildLabel.Text = "Parent Child Part: ";
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(6, 19);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(310, 174);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PARENT_NAME,
            this.QUANTITY,
            this.COMPONENT_NAME,
            this.TYPE,
            this.ITEM,
            this.PART_NUMBER,
            this.TITLE,
            this.MATERIAL});
            this.dataGridView.Location = new System.Drawing.Point(18, 257);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(770, 181);
            this.dataGridView.TabIndex = 2;
            // 
            // PARENT_NAME
            // 
            this.PARENT_NAME.HeaderText = "PARENT_NAME";
            this.PARENT_NAME.Name = "PARENT_NAME";
            // 
            // QUANTITY
            // 
            this.QUANTITY.HeaderText = "QUANTITY";
            this.QUANTITY.Name = "QUANTITY";
            // 
            // COMPONENT_NAME
            // 
            this.COMPONENT_NAME.HeaderText = "COMPONENT_NAME";
            this.COMPONENT_NAME.Name = "COMPONENT_NAME";
            // 
            // TYPE
            // 
            this.TYPE.HeaderText = "TYPE";
            this.TYPE.Name = "TYPE";
            // 
            // ITEM
            // 
            this.ITEM.HeaderText = "ITEM";
            this.ITEM.Name = "ITEM";
            // 
            // PART_NUMBER
            // 
            this.PART_NUMBER.HeaderText = "PART_NUMBER";
            this.PART_NUMBER.Name = "PART_NUMBER";
            // 
            // TITLE
            // 
            this.TITLE.HeaderText = "TITLE";
            this.TITLE.Name = "TITLE";
            // 
            // MATERIAL
            // 
            this.MATERIAL.HeaderText = "MATERIAL";
            this.MATERIAL.Name = "MATERIAL";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.treeGroupBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "Dashboard";
            this.Text = "QBuild";
            this.treeGroupBox.ResumeLayout(false);
            this.treeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox treeGroupBox;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button populateData;
        private System.Windows.Forms.Label currentPartLabel;
        private System.Windows.Forms.Label parentChildLabel;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARENT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPONENT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn PART_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERIAL;
    }
}

