using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//David Leclerc
//Data Structures
//3/13/2020
namespace ArrayStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //create stack with capacity of 10
            ArrayStack newStack = new ArrayStack(10);
            
            //push 6 items to stack
            newStack.Push(1);
            newStack.Push(2);
            newStack.Push(3);
            newStack.Push(4);
            newStack.Push(5);
            newStack.Push(6);
            //check top of stack
            newStack.Peek();
            //pop 2 items
            newStack.Pop();
            newStack.Pop();
            //check new top
            newStack.Peek();
            //push 6 more items
            newStack.Push(7);
            newStack.Push(8);
            newStack.Push(9);
            newStack.Push(10);
            newStack.Push(11);
            newStack.Push(12);
            //stack should be full, try to push one more
            newStack.Push(13);
            //check top again
            newStack.Peek();
            Console.ReadKey();


        }
    }

    public class ArrayStack
    {
        //private fields
        private int size;
        private int capacity;
        private int[] stack;

        
        //construct arrayStack using provided capacity
        public ArrayStack(int arrayLength)
        {
            //create empty array with set capacity
            capacity = arrayLength;
            stack = new int[capacity];
            //set size of empty array to 0
            size = 0;
                 


        }
        public void Push(int newItem)
        {
            //if there is room in the array, add the new number to array and increase size by 1
            if (size < capacity)
            {
                stack[size] = newItem;
                size++;
                Console.WriteLine("pushed " + newItem + " to stack");
            }
            else
                Console.WriteLine("Cannot push "+newItem+", stack is full");
        }
         public int Pop()
            {
            //remove last item from array and set value to 0, reduce size by 1
                int poppedItem = stack[size-1];
                stack[size-1] = 0;
                size--;
            Console.WriteLine("Popped " + poppedItem);
                return poppedItem;
            }

         public void Peek()
            {
            //print top of stack
            Console.WriteLine("Top of stack: " + stack[size - 1]);
                
            }
        }
    }

