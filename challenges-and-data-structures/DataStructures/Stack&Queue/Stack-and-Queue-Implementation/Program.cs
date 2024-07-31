namespace Stack_and_Queue_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack_and_Queue_Implementation.Stack stack = new Stack_and_Queue_Implementation.Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(stack);
            Console.WriteLine("Before Rev.");
            Stack_and_Queue_Implementation.Stack tempStack = new Stack_and_Queue_Implementation.Stack();
            while (!stack.IsEmpty())
            {
                int item = stack.Pop();
                Console.WriteLine(item);
                tempStack.Push(item);
            }
            tempStack.ReverseStack(stack);
            Console.WriteLine("After Rev.");
            while (!tempStack.IsEmpty())
            {
             Console.WriteLine(tempStack.Pop());
            }
            // Stack_and_Queue_Implementation.Queue queue = new Stack_and_Queue_Implementation.Queue();
            //stack.Push(1);
            //stack.Push(2);
            //Console.WriteLine("Pushing 1 & 2");
            //Console.WriteLine("Popping: " + stack.Pop());
            //Console.WriteLine("Return the first Element : " + stack.Peek());
            //Console.WriteLine("Check if the stack is empty " + stack.IsEmpty());
            //Stack_and_Queue_Implementation.Queue queue = new Stack_and_Queue_Implementation.Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //Console.WriteLine("Return the first element : " + queue.Peek());
            //Console.WriteLine("Check if the Queue is Empty : " + queue.IsEmpty());
            //Console.WriteLine("Enqueue 1 & 2");
            //Console.WriteLine("Dequeue : " + queue.Dequeue());
        }
    }
}
