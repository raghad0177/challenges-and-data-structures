using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLinkedList
{
    public class LinkedList
    {
        public Node First { get; set; }

        //Check if the linked List contains a node with the specified value.
        public void Include(int data)
        {
            if (First == null) return;
            if (First.Data == data)
            {
                First = First.Next;
                return;
            }
            Node current = First;
            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    Console.WriteLine("Found the data : " + current.Next.Data);
                    break;
                }
                current = current.Next;
            }
            if (current.Next == null)
            {
                Console.WriteLine("Not Found");
            }
        }

        //Remove the first node with the specified data from the linkedlist.
        public void Remove(int data)
        {
            if (First == null) return;

            if (First.Data == data)
            {
                First = First.Next;
                return;
            }
            Node current = First;
            while (current.Next != null && current.Next.Data != data)
            {
                current = current.Next;
            }
            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }

        // Print the contents of the list in order.
        public void Print()
        {
            Node current = First;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
        }

        public void InsertLast(int data)
        {
            Node newNode = new Node(data);
            if (First == null)
            {
                First = newNode;
                return;
            }
            Node current = First;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public int GetLength()
        {
            int length = 0;
            Node current = First;
            while (current != null)
            {
                length++;
                current = current.Next;
            }
            return length;
        }
    }
}