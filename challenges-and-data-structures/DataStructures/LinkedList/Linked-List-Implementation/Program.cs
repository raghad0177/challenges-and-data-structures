using LearnLinkedList;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Linked_List_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LearnLinkedList.LinkedList linkedList1 = new LearnLinkedList.LinkedList();
                LearnLinkedList.LinkedList linkedList2 = new LearnLinkedList.LinkedList();

                linkedList1.InsertLast(1);
                linkedList1.InsertLast(3);
                linkedList1.InsertLast(5);
                linkedList1.InsertLast(5);
                linkedList1.InsertLast(7);
                linkedList1.InsertLast(8);


                linkedList2.InsertLast(2);
                linkedList2.InsertLast(4);
                linkedList2.InsertLast(6);
                linkedList2.InsertLast(5);


               
                Console.WriteLine("\nPrint All the list");
                linkedList1.Print();

                Console.WriteLine("\n\nAfter removing the last item");
                linkedList1.Remove(5);
                linkedList1.Print();

                Console.WriteLine("\n\n" +
                    "Check if there is an existing items it is 2");
                linkedList1.Include(2);

                Console.WriteLine("\nCheck if there is not existing items it is 9");
                linkedList1.Include(9);

                Console.WriteLine("\nRemove Duplicated Numbers");
                linkedList1.RemoveDuplicate();
                linkedList1.Print();


                LearnLinkedList.LinkedList linkedList3 = new LearnLinkedList.LinkedList();
                LearnLinkedList.LinkedList linkedList4 = new LearnLinkedList.LinkedList();

                linkedList3.InsertLast(1);
                linkedList3.InsertLast(3);
                linkedList3.InsertLast(5);

                linkedList4.InsertLast(5);
                linkedList4.InsertLast(7);
                linkedList4.InsertLast(8);
                Console.WriteLine("\n\nMerge Two Sorted Lists");
                Console.WriteLine("List 1");
                linkedList3.Print();
                Console.WriteLine("\nList 2");
                linkedList4.Print();
                Console.WriteLine("\nMerging : ");
                LinkedList node = LinkedList.MergeTwoLists(linkedList3, linkedList4);
                node.Print();

                Console.WriteLine("\nRotateLeft for 1,2,3,4,5  with k=2 : ");
                LinkedList linkedList5 = new LinkedList();
                linkedList5.InsertLast(1);
                linkedList5.InsertLast(2);
                linkedList5.InsertLast(3);
                linkedList5.InsertLast(4);
                linkedList5.InsertLast(5);

                linkedList5.RotateLeft(7);
                linkedList5.Print();


            }
            catch (FormatException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}



