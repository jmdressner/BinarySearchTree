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

        public void Search(int id)
        {
            Search(root, id);
            Console.WriteLine(); ;
        }

        public void Search(Node node, int id)
        {
            if (root == null)
            {
                Console.WriteLine("This binary search tree is empty.");
            }
            else if (root.item == id)
            {
                Console.WriteLine(id + " is the root node of this binary search tree.");
            }
            else
            {
                Console.WriteLine(id +" is not the root node. Checking children:");

                if (node.leftchild != null && id == node.leftchild.item)
                {
                    Console.WriteLine(id + " is found in the left child.");
                }
                else if (node.leftchild != null && id == node.rightchild.item)
                {
                    Console.WriteLine(id + " is found in the right child.");
                }
                else
                {
                    if (node.leftchild.leftchild != null && id == node.leftchild.leftchild.item)
                    {
                        Console.WriteLine(id + " is found in the left childs, left child.");
                    }
                    else if (node.leftchild.rightchild != null && id == node.leftchild.rightchild.item)
                    {
                        Console.WriteLine(id + " is found in the left childs, right child.");
                    }
                    else if (node.rightchild.leftchild != null && id == node.rightchild.leftchild.item)
                    {
                        Console.WriteLine(id + " is found in the right childs, left child.");
                    }
                    else if (node.rightchild.rightchild != null && id == node.rightchild.rightchild.item)
                    {
                        Console.WriteLine(id + " is found in the right childs, right child.");
                    }
                    else
                    {
                        Console.WriteLine(id + " is not in this binary search tree.");
                    }
                }
            }
         
        }

    }
}

