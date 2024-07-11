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
                linkedList.InsertLast(2);
                linkedList.InsertLast(3);
                linkedList.InsertLast(4);
                linkedList.Remove(4);
                linkedList.Print();
                linkedList.Include(2);
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
