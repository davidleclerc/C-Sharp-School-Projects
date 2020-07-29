using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BTNode newNode = new BTNode();

            if (newNode.Letter == "\0")
            {
                Console.WriteLine("Node letter is set to '\\0'");
            }
            if (newNode.Left == null)
            {
                Console.WriteLine("left node set to null");
            }
            if (newNode.Right == null)
            {
                Console.WriteLine("right node set to null");
            }
           
            Console.ReadKey();
        }
    }
}
