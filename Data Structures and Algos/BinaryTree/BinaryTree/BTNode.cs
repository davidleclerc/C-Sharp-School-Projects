using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    
    class BTNode
    {
        private string letter;
        private BTNode left;
        private BTNode right;

        public string Letter { get => letter; set => letter = value; }
        internal BTNode Left { get => left; set => left = value; }
        internal BTNode Right { get => right; set => right = value; }


        public BTNode()
        {
            Letter = "\0";
            Left = null;
            Right = null;

        }
    }


}
