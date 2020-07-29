using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TreeSearch newTree = new TreeSearch();
            newTree.Insert(Convert.ToChar("g"));
            newTree.Insert(Convert.ToChar("d"));
            newTree.Insert(Convert.ToChar("a"));
            newTree.Insert(Convert.ToChar("h"));
            newTree.Insert(Convert.ToChar("m"));
            newTree.Insert(Convert.ToChar("b"));
            newTree.Insert(Convert.ToChar("u"));
            newTree.Insert(Convert.ToChar("z"));
            newTree.Traverse(newTree.Root);
            Console.ReadKey();
            newTree.Search(newTree.Root,Convert.ToChar("u"));

        }
    }

    class BTNode
    {
        private char letter;
        private BTNode left;
        private BTNode right;

        public char Letter { get => letter; set => letter = value; }
        internal BTNode Left { get => left; set => left = value; }
        internal BTNode Right { get => right; set => right = value; }


        public BTNode()
        {
            Letter = Convert.ToChar("\0");
            Left = null;
            Right = null;

        }
    }

    class TreeSearch
    {
        private BTNode root;
        private BTNode current;

        internal BTNode Root { get => root; set => root = value; }
        internal BTNode Current { get => current; set => current = value; }

        public TreeSearch()
        {
            Root = null;
            Current = null;

        }

        public void Insert(char letter)
        {
            current = root;            
            while (current != null)
            {
                if (letter > current.Letter)
                {
                    current = current.Right;                    
                }
                else
                { 
                    current = current.Left;
                }                              
            }
            BTNode newNode = new BTNode();
            newNode.Letter = letter;
            current = newNode;
        }

        public void Traverse(BTNode Root)
        {
            if(Root != null)
            {
                Traverse(Root.Left);
                Console.WriteLine(Root.Letter);
                Traverse(Root.Right);
            }
        }

        public void Search(BTNode current, Char searchLetter)
        {
            
            if (searchLetter > current.Letter)
            {
                current.Right = current;
                Search(current, searchLetter);
            }
            else if (searchLetter < current.Letter)
            {
                current.Left = current;
                Search(current, searchLetter);
            }
            else
            { Console.WriteLine(searchLetter + " was found in the tree"); }

        }

           
    }
}
