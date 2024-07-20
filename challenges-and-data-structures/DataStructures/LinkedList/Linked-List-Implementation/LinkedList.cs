using LearnLinkedList;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LearnLinkedList
{
    public class LinkedList
    {
        public Node First { get; set; }
        public static LinkedList MergeTwoLists(LinkedList list1, LinkedList list2)
        {
            // Step 1: Check for empty lists
            if (list1.First == null) return list2;
            if (list2.First == null) return list1;
            // Step 2: Initialize a dummy node
            Node dummy = new Node();
            Node tail = dummy;
            Node current1 = list1.First;
            Node current2 = list2.First;
            //1  3  5  //2  4  6
            // Step 3: Merge the lists
            while (current1 != null && current2 != null)
            {
                if (current1.Data <= current2.Data)// true // 3 <=  2 false // 3 <= 4 true // 5<=4  false // 5 <= 6 true 
                {
                    tail.Next = current1; //1 // 3 // 5
                    current1 = current1.Next;// 3 //  5 //null
                }
                else
                {
                    tail.Next = current2; // 2 // 4
                    current2 = current2.Next; // 4 //6
                }
                tail = tail.Next;// 1  2   3   4  5
            }
            // Step 4: Attach remaining nodes
            tail.Next = (current1 != null) ? current1 : current2; // null else 6
            // Step 5: Return the merged list
            LinkedList mergedList = new LinkedList();
            mergedList.First = dummy.Next; // (data.next(daya.next(data,next)))
            return mergedList;
        }

        // Remove duplication
        public void RemoveDuplicate()
        {
            Node current = First;
            while (current != null)
            {
                Node runner = current;
                while (runner.Next != null)
                {
                    if (runner.Next.Data == current.Data)
                    {
                        runner.Next = runner.Next.Next;
                    }
                    else
                    {
                        runner = runner.Next;
                    }
                }

                current = current.Next;
            }
        }
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








