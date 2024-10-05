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

        public void RotateLeft(int k)
        {
            //1 , 2, 3, 4, 5
            Node current = First; //1
            while (k != 0)
            {
                InsertLast(current.Data); //1 , 2, 3, 4, 5 ,1
                Remove(current.Data);
                current = current.Next; // 2
                k--;
            }
            //while(k != 0)
            //{
            //    DeleteSpecifiedData(current.Data);
            //    current = current.Next;
            //    k--;
            //}
        }
        public int[] GetLinkedListData(LinkedList linkedList)
        {
            var current = First;
            var result = new List<int>();
            while (current != null)
            {
                result.Add(current.Data);
                current = current.Next;
            }
            return result.ToArray();
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Channels;
//using System.Threading.Tasks;

//namespace StudyLinkedList
//{
//    public class LinkedList
//    {
//        public Node Head { get; set; }
//        // 1.
//        public void InsertFirst(int data)
//        {
//            Node newNode = new Node()
//            {
//                Data = data,
//                Next = Head
//            };
//            Head = newNode;
//        }
//        // 2.
//        public void InsertLast(int data)
//        {
//            Node newNode = new Node()
//            {
//                Data = data,
//            };

//            if (Head == null)
//            {
//                Head = newNode;
//                return;
//            }

//            Node current = Head;
//            while (current.Next != null)
//            {
//                current = current.Next;
//            }
//            current.Next = newNode;
//        }
//        // 3.
//        public void RemoveFirst()
//        {
//            if (Head == null) { return; }

//            if (Head != null)
//            {
//                Head = Head.Next;
//            }
//        }
//        // 4.
//        public void RemoveLast()
//        {
//            if (Head == null) { return; }

//            Node current = Head;
//            while (current.Next.Next != null)
//            {
//                current = current.Next;
//            }
//            current.Next = null;
//            return;

//        }
//        // 5.
//        public void MidelValue()
//        {
//            int count = 0;

//            Node current = Head;
//            while (current != null)
//            {
//                count++;
//                current = current.Next;
//            }

//            int index = 0;
//            int midelIndex = count / 2;

//            Node node = Head;

//            while (node != null)
//            {
//                if (index == midelIndex)
//                {
//                    Console.WriteLine("this is Midel Value : " + node.Data);
//                    return;
//                }
//                index++;
//                node = node.Next;
//            }

//        }
//        // 6.
//        public void DeleteSpecifiedData(int data)
//        {
//            Node courent = Head;
//            Node previous = null;

//            while (courent != null)
//            {
//                if (courent.Data == data)
//                {
//                    if (previous == null)
//                    {
//                        Head = courent.Next;
//                    }
//                    else
//                    {
//                        previous.Next = courent.Next;
//                    }
//                    return;
//                }
//                previous = courent;
//                courent = courent.Next;
//            }
//            return;
//        }
//        // 7.
//        public void ReveselList()
//        {
//            Node previous = null;
//            Node current = Head;
//            Node next = null;

//            // Traverse the list and reverse the links
//            while (current != null)
//            {
//                next = current.Next;  // Store the next node 
//                current.Next = previous;  // Reverse the current node's pointer 
//                previous = current;  // Move previous and current one step forward 
//                current = next;
//            }

//            // Set the new head of the reversed list
//            Head = previous;
//        }
//        private Node Reverse(Node head)
//        {
//            Node prev = null;
//            while (head != null)
//            {
//                Node next = head.Next;
//                head.Next = prev;
//                prev = head;
//                head = next;
//            }
//            return prev;
//        }
//        // 8.
//        public int MaximumValue()
//        {
//            Node current = Head;

//            int maxValue = Head.Data;

//            if (Head == null)
//            {
//                throw new InvalidOperationException("The list is empty.");
//            }

//            while (current.Next != null)
//            {
//                if (current.Data > maxValue)
//                {
//                    maxValue = current.Data;
//                }
//                current = current.Next;
//            }
//            //return MaximumValue();
//            return maxValue;
//        }
//        // 9.
//        public int? Find(int data)
//        {
//            Node courent = Head;

//            while (courent != null)
//            {
//                if (courent.Data == data)
//                {
//                    return courent.Data;
//                }

//                courent = courent.Next;
//            }
//            Console.WriteLine("The list did not have this value");
//            return null;
//        }
//        // 10.
//        public bool IsSorted()
//        {
//            Node current = Head;

//            while (current.Next != null)
//            {
//                if (current.Data > current.Next.Data)
//                {
//                    return false;
//                }
//                current = current.Next;
//            }
//            return true;
//        }
//        // 11.
//        public bool IsEmpty()
//        {
//            Node current = Head;

//            if (current == null)
//            {
//                return true;
//            }
//            if (current.Data != null)
//            {
//                return false;
//            }
//            return true;
//        }
//        // 12.
//        public void DeleteDuplicates()
//        {
//            Node current = Head;

//            while (current != null)
//            {
//                Node runner = current;
//                while (runner.Next != null)
//                {
//                    if (runner.Next.Data == current.Data)
//                    {
//                        runner.Next = runner.Next.Next;
//                    }
//                    else
//                    {
//                        runner = runner.Next;
//                    }
//                }
//                current = current.Next;
//            }
//        }
//        // 13.
//        public int FindMinValue()
//        {
//            if (Head == null)
//            {
//                throw new InvalidOperationException("The list is empty.");
//            }

//            Node current = Head;

//            int minValue = Head.Data;

//            while (current.Next != null)
//            {
//                if (current.Data < minValue)
//                {
//                    minValue = current.Data;
//                }
//                current = current.Next;
//            }
//            return minValue;
//        }
//        // 14.
//        public bool DetectCycle()
//        {
//            if (Head == null || Head.Next == null)
//            {
//                return false;
//            }
//            Node fast = Head;
//            Node slow = Head;

//            while (fast != null && fast.Next != null)
//            {
//                fast = fast.Next;
//                slow = slow.Next.Next;

//                if (fast.Next == slow.Next)
//                {
//                    return true;
//                }
//                fast = fast.Next;
//            }
//            return false;

//        }
//        // 15.
//        public Node MergeSort(Node list1, Node list2)
//        {
//            if (list1 == null) return list2;
//            if (list2 == null) return list1;

//            Node mergeSort = new Node();
//            Node current = mergeSort;

//            while (list1 != null && list2 != null)
//            {
//                if (list1.Data <= list2.Data)
//                {
//                    current.Next = list1;
//                    list1 = list1.Next;
//                }
//                else
//                {
//                    current.Next = list2;
//                    list2 = list2.Next;
//                }
//                current = current.Next;
//            }

//            if (list1 != null)
//            {
//                current.Next = list1;
//            }
//            else if (list2 != null)
//            {
//                current.Next = list2;
//            }

//            return mergeSort.Next;
//        }
//        public Node MergeSortRecersion(Node list1, Node list2)
//        {
//            if (list1 == null) return list2;
//            if (list2 == null) return list1;

//            // Compare the first elements and choose the smaller one to be the head
//            if (list1.Data <= list2.Data)
//            {
//                list1.Next = MergeSortRecersion(list1.Next, list2);
//                return list1;
//            }
//            else
//            {
//                list2.Next = MergeSortRecersion(list1, list2.Next);
//                return list2;
//            }
//        }
//        // 16.
//        public void InsertAtPosition(int position, int data)
//        {
//            Node newNode = new Node { Data = data };

//            // If inserting at the head (position 1)
//            if (position == 1)
//            {
//                newNode.Next = Head;
//                Head = newNode;
//                return;
//            }

//            Node current = Head;
//            int currentPosition = 1;
//            while (current != null && currentPosition < position - 1)//The loop ensures that we stop at the node just before the insertion point.
//            {
//                current = current.Next;
//                currentPosition++;
//            }
//            if (current == null)
//            {
//                Console.WriteLine("Position out of bounds.");
//                return;
//            }
//            newNode.Next = current.Next;
//            current.Next = newNode;
//        }
//        // 17.
//        public bool IsPalindrome()
//        {
//            if (Head == null || Head.Next == null)
//                return true;

//            Node fast = Head;
//            Node slow = Head;

//            while (fast != null && fast.Next != null)
//            {
//                slow = slow.Next;
//                fast = fast.Next.Next;          // 1 2 3 4 5
//            }
//            // Step 2: Reverse the second half of the linked list
//            Node secondHalf = Reverse(slow);

//            // Step 3: Compare the first half with the reversed second half
//            Node firstHalf = Head;
//            while (secondHalf != null)
//            {
//                if (firstHalf.Data != secondHalf.Data)
//                    return false;
//                firstHalf = firstHalf.Next;
//                secondHalf = secondHalf.Next;
//            }

//            return true;

//        }
//        // 18.
//        public void Include(int data)
//        {
//            Node current = Head;

//            while (current != null)
//            {
//                if (current.Data == data)
//                {
//                    Console.WriteLine("The List include the Data :" + data);
//                    return;
//                }
//                current = current.Next;
//            }
//            Console.WriteLine("Not found");
//        }
//        // 19.
//        public int[] GetLinkedListData(LinkedList linkedList)
//        {
//            Node current = Head;
//            var result = new List<int>();

//            while (current != null)
//            {
//                result.Add(current.Data);
//                current = current.Next;
//            }
//            return result.ToArray();
//        }
//        // 20.
//        public void RotateLeft(int K)
//        {
//            Node current = Head;
//            while (K != 0)
//            {
//                InsertLast(current.Data);
//                DeleteSpecifiedData(current.Data);
//                current = current.Next;
//                K--;

//            }
//        }





//        public void DisplayList()
//        {
//            Node current = Head;
//            while (current != null)
//            {
//                current.DisplayData();
//                current = current.Next;
//            }

//            Console.WriteLine();
//        }
//        //public void DisplayList()
//        //{
//        //    Node current = Head;

//        //    if (current == null)
//        //    {
//        //        Console.WriteLine("╭───────────────────────────────╮");
//        //        Console.WriteLine("│         The list is empty     │");
//        //        Console.WriteLine("╰───────────────────────────────╯");
//        //        return;
//        //    }

//        //    Console.WriteLine("╭───────────────────────────────────────────────╮");
//        //    Console.WriteLine("│               Linked List Contents             │");
//        //    Console.WriteLine("╰───────────────────────────────────────────────╯");

//        //    while (current != null)
//        //    {
//        //        // Display the node and its next pointer in a visually clear format
//        //        Console.WriteLine("╭─────────────── Node ───────────────╮");
//        //        Console.WriteLine($"│ Data: {current.Data,-10}            │");

//        //        // Show where the 'Next' pointer is pointing
//        //        if (current.Next != null)
//        //        {
//        //            Console.WriteLine($"│ Next: Points to Node with Data: {current.Next.Data,-4} │");
//        //        }
//        //        else
//        //        {
//        //            Console.WriteLine("│ Next: Points to: null               │");
//        //        }

//        //        Console.WriteLine("╰────────────────────────────────────╯");

//        //        if (current.Next != null)
//        //        {
//        //            // Show an arrow between nodes for clarity
//        //            Console.WriteLine("          │");
//        //            Console.WriteLine("          ↓");
//        //        }

//        //        current = current.Next;
//        //    }
//        //}
//    }
//}








