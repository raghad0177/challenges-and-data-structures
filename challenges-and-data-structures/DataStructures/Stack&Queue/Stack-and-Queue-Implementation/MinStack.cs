using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue_Implementation
{
    public class MinStack
    {
        private Node top;
        private Node minTop;

        public MinStack()
        {
            top = null;
            minTop = null;
        }
         
        // Push an element to the stack
        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;

            if (minTop == null || data <= minTop.Data)
            {
                Node newMinNode = new Node(data);
                newMinNode.Next = minTop;
                minTop = newMinNode;
            }
        }

        // Pop an element from the stack
        public int Pop()
        {
            if (top == null) throw new InvalidOperationException("Stack is empty.");

            int poppedData = top.Data;
            top = top.Next;

            if (poppedData == minTop.Data)
            {
                minTop = minTop.Next;
            }

            return poppedData;
        }

        // Return the top element of the stack without removing it
        public int Top()
        {
            if (top == null) throw new InvalidOperationException("Stack is empty.");
            return top.Data;
        }

        // Check if the stack is empty
        public bool IsEmpty()
        {
            return top == null;
        }

        // Return the minimum element in the stack
        public int GetMin()
        {
            if (minTop == null) throw new InvalidOperationException("Stack is empty.");
            return minTop.Data;
        }

        // Print the contents of the stack
        public void PrintStack()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            Node current = top;
            Console.Write("Top -> ");
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
                if (current != null)
                {
                    Console.Write("-> ");
                }
            }
            Console.WriteLine();
        }
    }
}
