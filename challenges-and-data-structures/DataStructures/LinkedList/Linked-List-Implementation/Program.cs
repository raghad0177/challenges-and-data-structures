namespace Linked_List_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LearnLinkedList.LinkedList linkedList = new LearnLinkedList.LinkedList();
                linkedList.InsertLast(1);
                linkedList.InsertLast(1);
                linkedList.InsertLast(1);
                linkedList.InsertLast(2);
                linkedList.InsertLast(3);
                linkedList.InsertLast(4);
                linkedList.InsertLast(4);
                linkedList.InsertLast(5);
                linkedList.InsertLast(5);
                Console.WriteLine("\nPrint All the list");
                linkedList.Print();
                Console.WriteLine("\n\nAfter removing the last item");
                linkedList.Remove(5);
                linkedList.Print();
                Console.WriteLine("\n\n" +
                    "Check if there is an existing items it is 2");
                linkedList.Include(2);
                Console.WriteLine("\nCheck if there is not existing items it is 9");
                linkedList.Include(9);
                Console.WriteLine("\nRemove Duplicated Numbers");
                linkedList.RemoveDuplicate();
                linkedList.Print();

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



