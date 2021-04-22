using System;
using System.Collections.Generic;


namespace QBuild
{
    class NAryTreeNode
    {
        public string name = "";
        public int quantity = 0;
        public List<NAryTreeNode> children = new List<NAryTreeNode>();

        public NAryTreeNode(string name)
        {
            this.name = name;
        }

        public NAryTreeNode(string name, int quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }
    }
}
