using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
namespace Stack_and_Queue_Implementation
{
    public class Stack
    {//LIFO
        public Node top;
        public Stack()
        {
            top = null;
        }
        // Push method
        public void Push(int data)
        {//Last element at the first data and next
            Node newNode = new Node(data);//(data,next(data,next(data,next(data,next(data,next))))
            newNode.Next = top;
            top = newNode;
        }
        // Pop Method
        public int Pop()
        {
            // check if the stack is empty
            if (IsEmpty())
                throw new Exception("Stack is Empty from the pop");
            int data = top.Data;
            top = top.Next;
            return data;
        }
        // Peek Method
        public int Peek()
        {
            // check if the stack is empty
            if (IsEmpty())
                throw new Exception("Stack is Empty from the peek");
            return top.Data;
        }
        // IsEmpty Method
        public bool IsEmpty()
        {
            return top == null;
        }
        public void ReverseStack(Stack_and_Queue_Implementation.Stack stack)
        {
            Stack_and_Queue_Implementation.Queue queue = new Stack_and_Queue_Implementation.Queue();
            while (!stack.IsEmpty())// LIFO
            {
                queue.Enqueue(stack.Pop());// 5 4 3 2 1 
            }
            // Dequeue elements from the queue and push them back into the stack
            while (!queue.IsEmpty())// FIFO
            {
                stack.Push(queue.Dequeue());// 5 4 3 2 1 => 1 2 3 4 5
            }

        }
    }
}