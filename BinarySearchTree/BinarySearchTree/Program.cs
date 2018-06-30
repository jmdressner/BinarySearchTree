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
            myTree.Insert(100);
            myTree.Insert(82);
            myTree.Insert(78);
            myTree.Insert(93);
            myTree.Insert(116);
            myTree.Insert(105);
            myTree.Insert(123);
            myTree.Print();
            Console.ReadLine();
        }
    }
}
