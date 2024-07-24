namespace Stack_and_Queue_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack_and_Queue_Implementation.Stack stack = new Stack_and_Queue_Implementation.Stack();
            stack.Push(1);
            stack.Push(2);
            Console.WriteLine("Pushing 1 & 2");
            Console.WriteLine("Popping: " + stack.Pop());
            Console.WriteLine("Return the first Element : "+ stack.Peek());
            Console.WriteLine("Check if the stack is empty "+ stack.IsEmpty());
            Stack_and_Queue_Implementation.Queue queue = new Stack_and_Queue_Implementation.Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            Console.WriteLine("Enqueue 1 & 2");
            Console.WriteLine("Dequeue : " + queue.Dequeue());
            Console.WriteLine("Return the first element : "+ queue.Peek());
            Console.WriteLine("Check if the Queue is Empty : "+ queue.IsEmpty());
        }
    }
}
