namespace Stack_and_Queue_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Min Stack
            MinStack minStack = new MinStack();
            minStack.Push(15); 
            minStack.Push(7);  
            minStack.Push(12); 
            minStack.Push(3);  

            minStack.PrintStack();

            int min = minStack.GetMin(); 
            Console.WriteLine("Min: " + min);

            int popped = minStack.Pop(); 
            Console.WriteLine("Popped: " + popped);

            minStack.PrintStack(); 

            min = minStack.GetMin(); 
            Console.WriteLine("Min: " + min);

            int peeked = minStack.Top(); 
            Console.WriteLine("Top: " + peeked);

            minStack.Push(2);  
            minStack.PrintStack(); 

            min = minStack.GetMin();
            Console.WriteLine("Min: " + min);

            bool isEmpty = minStack.IsEmpty();
            Console.WriteLine("IsEmpty: " + isEmpty);


            // Delete Middle 
            Stack_and_Queue_Implementation.Stack stack = new Stack_and_Queue_Implementation.Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.DeleteMiddle(stack);

            // Reverse Stack
            Stack_and_Queue_Implementation.Stack stack2 = new Stack_and_Queue_Implementation.Stack();
            stack2.Push(1);
            stack2.Push(2);
            stack2.Push(3);
            stack2.Push(4);
            stack2.Push(5);
            Console.WriteLine(stack2);
            Console.WriteLine("Before Rev.");
            Stack_and_Queue_Implementation.Stack tempStack = new Stack_and_Queue_Implementation.Stack();
            while (!stack2.IsEmpty())
            {
                int item = stack2.Pop();
                Console.WriteLine(item);
                tempStack.Push(item);
            }
            tempStack.ReverseStack(stack2);
            Console.WriteLine("After Rev.");
            while (!tempStack.IsEmpty())
            {
                Console.WriteLine(tempStack.Pop());
            }
            Stack_and_Queue_Implementation.Queue queue = new Stack_and_Queue_Implementation.Queue();
            stack2.Push(1);
            stack2.Push(2);
            Console.WriteLine("Pushing 1 & 2");
            Console.WriteLine("Popping: " + stack2.Pop());
            Console.WriteLine("Return the first Element : " + stack2.Peek());
            Console.WriteLine("Check if the stack is empty " + stack2.IsEmpty());
            Stack_and_Queue_Implementation.Queue queue2 = new Stack_and_Queue_Implementation.Queue();
            queue2.Enqueue(1);
            queue2.Enqueue(2);
            Console.WriteLine("Return the first element : " + queue2.Peek());
            Console.WriteLine("Check if the Queue is Empty : " + queue2.IsEmpty());
            Console.WriteLine("Enqueue 1 & 2");
            Console.WriteLine("Dequeue : " + queue2.Dequeue());
        }
    }
}
