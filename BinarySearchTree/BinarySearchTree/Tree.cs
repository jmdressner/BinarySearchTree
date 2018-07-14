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

        public void Add(int id)
        {
            Node newNode = new Node();
            newNode.item = id;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;

                while (true)
                {
                    parent = current;
                    if (newNode.item < current.item)
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

        public void Display()
        {
            Display(root, 0);
            Console.WriteLine();
        }
        public void Display(Node node, int level)
        {
            if (node == null)
            {
                return;
            }

            Display(node.rightchild, level + 1);
            Console.WriteLine();

            for (int i = 0; i < level; i++)
            {
                Console.Write("    ");
            }
            Console.Write(node.item);

            Display(node.leftchild, level + 1);
        }

        public void PreOrder()
        {
            PreOrder(root);
            Console.WriteLine();
        }
        public void PreOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            Console.Write(node.item + " ");
            PreOrder(node.leftchild);
            PreOrder(node.rightchild);
        }

        public void InOrder()
        {
            InOrder(root);
            Console.WriteLine();
        }
        public void InOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            InOrder(node.leftchild);
            Console.Write(node.item + " ");
            InOrder(node.rightchild);
        }

        public void PostOrder()
        {
            PostOrder(root);
            Console.WriteLine();
        }
        public void PostOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            PostOrder(node.leftchild);
            PostOrder(node.rightchild);
            Console.Write(node.item + " ");
        }

        public void LevelOrder()
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            Node node;
            while (queue.Count != 0)
            {
                node = queue.Dequeue();
                Console.Write(node.item + " ");
                if (node.leftchild != null)
                {
                    queue.Enqueue(node.leftchild);
                }
                if (node.rightchild != null)
                {
                    queue.Enqueue(node.rightchild);
                }
            }
        }

    }
}

