using System;
using System.Collections.Generic;
using System.Text;

namespace tree
{
    class Node
    {
        public string Id { get; set; }

        public List<Node> Children { get; set; }

        public Node(String id)
        {
            this.Id = id;
            this.Children = new List<Node>();
        }
    }
}
