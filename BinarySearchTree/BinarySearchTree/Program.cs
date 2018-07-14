using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree myTree = new Tree();
            myTree.Add(100);
            myTree.Add(82);
            myTree.Add(78);
            myTree.Add(93);
            myTree.Add(116);
            myTree.Add(105);
            myTree.Add(123);
            myTree.Display();
            Console.ReadLine();

            Console.WriteLine("Pre-order: ");
            myTree.PreOrder();
            Console.WriteLine("");

            Console.WriteLine("In-order: ");
            myTree.InOrder();
            Console.WriteLine();

            Console.WriteLine("Post-order: ");
            myTree.PostOrder();
            Console.WriteLine();

            Console.WriteLine("Level order: ");
            myTree.LevelOrder();
            Console.WriteLine();

        }
    }
}
