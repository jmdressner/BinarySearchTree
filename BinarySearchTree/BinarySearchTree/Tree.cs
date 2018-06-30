using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree
    {
        public Node root;

        public Tree()
        {
            root = null;
        }

        public void Insert(int id)
        {
            Node newNode = new Node();
            newNode.item = id;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.item)
                    {
                        current = current.leftchild;
                        if (current == null)
                        {
                            parent.leftchild = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightchild;
                        if (current == null)
                        {
                            parent.rightchild = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public void Print()
        {
            Print(root, 4);
        }

        public void Print(Node p, int padding)
        {
            if (p != null)
            {
                if (p.rightchild != null)
                {
                    Print(p.rightchild, padding + 4);
                }
                if (padding > 0)
                {
                    Console.Write(" ".PadLeft(padding));
                }
                if (p.rightchild != null)
                {
                    Console.Write("/\n");
                    Console.Write(" ".PadLeft(padding));
                }
                Console.Write(p.item.ToString() + "\n ");
                if (p.leftchild != null)
                {
                    Console.Write(" ".PadLeft(padding) + "\\\n");
                    Print(p.leftchild, padding + 4);
                }
            }
        }
    }


}

