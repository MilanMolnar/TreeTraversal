using System;
using System.Collections.Generic;
using tree;

namespace tree
{
    class Program
    {
        static Node manager;
        static List<Node> employees = new List<Node>();


        static void Main(string[] args)
        {
            Node root = GenerateTree();
            //Finding node 'B'
            Find("B", root);
            //Getting the childrens of node 'B'
            Collect(manager);
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Id);
            }
        }
        /***
         * Tree structure
         * 
         * A
         * |
         * +--B
         *    |
         *    +--C
         *    +--D
         *    +--E
         *    F
         *    |
         *    +--G
         *    +--H
         *    +--I
         *    +--J
         *       |
         *       +--Z
         ***/
        public static Node GenerateTree()
        {
            //right
            Node G = new Node("G");
            Node H = new Node("H");
            Node Z = new Node("Z");
            Node J = new Node("J");
            J.Children.Add(Z);
            Node I = new Node("I");
            Node F = new Node("F");
            F.Children.Add(G);
            F.Children.Add(H);
            F.Children.Add(I);
            F.Children.Add(J);
            //Left
            Node C = new Node("C");
            Node D = new Node("D");
            Node E = new Node("E");
            Node B = new Node("B");
            B.Children.Add(C);
            B.Children.Add(D);
            B.Children.Add(E);
            //root
            Node A = new Node("A");
            A.Children.Add(B);
            A.Children.Add(F);
            //return rootnode
            return A;
        }
        
        static void Find(String id, Node node)
        {
            foreach (var child in node.Children)
            {
                Find(id, child);
                if (child.Id == id)
                {
                    manager = child;
                }
              
            }
        }

        static void Collect(Node node)
        {
            foreach (var child in node.Children)
            {
                Collect(child);
                employees.Add(child);
            }
        }

         
    }
}

