using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//David Leclerc
//Data Structures
//2/28/2020
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //create nodes and assign values
            LLNode aNode = new LLNode(1);
            aNode.next = new LLNode(2);
            aNode.next.next = new LLNode(4);
            aNode.next.next.next = new LLNode(8);

            //create list and assign pointers
            LinkedList myList = new LinkedList();
            myList.Front = aNode;
            myList.Current = myList.Front;
            myList.Back = aNode.next.next.next;

            //loop through list and print current node
            while (myList.Current != null)
            {
                Console.WriteLine("current node = " + myList.Current.data);
                myList.Current = myList.Current.next;

            }
            Console.WriteLine("Front = " + myList.Front.data);
            Console.WriteLine("Back = " + myList.Back.data);
            Console.ReadKey();

        }
    }

    class LLNode
    {
        public int data;
        public LLNode next;


        //get and set data and next node
        public int Data { get => data; set => data = value; }
        public LLNode Next { get => next; set => next = value; }

        //node constructor
        public LLNode(int nodeData)
        {
            data = nodeData;
            next = null;
            
        }
    }

    class LinkedList
    {
        public LLNode current;
        public LLNode front;
        public LLNode back;

        //get and set list pointers
        public LLNode Current { get => current; set => current = value; }
        public LLNode Front { get => front; set => front = value; }
        public LLNode Back { get => back; set => back = value; }

        //list constructor
        public LinkedList()
        {
            
        }

        
    }
}
