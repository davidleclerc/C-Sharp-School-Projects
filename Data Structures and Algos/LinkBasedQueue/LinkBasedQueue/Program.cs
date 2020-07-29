using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkBasedQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            //test queue

            //create list
            LinkedList myList = new LinkedList();
            //create queue
            LLQueue myQueue = new LLQueue(myList);

            //enqueue 6 numbers
            Console.WriteLine("enqueue 6");
            myQueue.Enqueue(6);
            Console.WriteLine("enqueue 5");
            myQueue.Enqueue(5);
            Console.WriteLine("enqueue 4");
            myQueue.Enqueue(4);
            Console.WriteLine("enqueue 3");
            myQueue.Enqueue(3);
            Console.WriteLine("enqueue 2");
            myQueue.Enqueue(2);
            Console.WriteLine("enqueue 1");
            myQueue.Enqueue(1);
            //peek front to ensure that "6" is the first node in queue
            Console.WriteLine("Peek front: " + myQueue.Peek());

            //dequeue the first 3 nodes
            Console.WriteLine("Dequeue");
            Console.WriteLine("removed " + myQueue.Dequeue());
            Console.WriteLine("Dequeue");
            Console.WriteLine("removed " + myQueue.Dequeue());
            Console.WriteLine("Dequeue");
            Console.WriteLine("removed " + myQueue.Dequeue());

            //peek front again to ensure that "3" is now the front node
            Console.WriteLine("Peek Front: " + myQueue.Peek());
            Console.ReadKey();




        }

        class LLQueue
        {
            //private field
            private LinkedList qList;

            
            //constructor
            public LLQueue(LinkedList myList)
            {
                qList = myList;
                
            }
            //if front node is empty, create it. else move through list until there is an empty node and create 
            //new node at the end. set back pointer to the last node.
            public void Enqueue(int data)
            {
                if (qList.Front == null)
                {
                    LLNode aNode = new LLNode(data);
                    qList.Front = aNode;
                    qList.Current = qList.Front;
                    
                }
                else
                {
                    while (qList.Current.next != null)
                    {
                        qList.Current = qList.Current.Next;
                     }
                    LLNode aNode = new LLNode(data);                    
                    qList.Current.next = aNode;
                    qList.Current = qList.Current.Next;
                    qList.Back = qList.Current;
                    
                }                            
                
            }
            //return front node, then set new front pointer to the next node.
            public int Dequeue()
            {
                int data = qList.Front.data;
                qList.Front = qList.Front.next;
                return data;
            }
            //return front node but do not move front node pointer
            public int Peek()
            {
                int data = qList.Front.data;
                return data;
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
                Front = null;
                Current = Front;
                Back = null;
            }

            
        }
    }
}
