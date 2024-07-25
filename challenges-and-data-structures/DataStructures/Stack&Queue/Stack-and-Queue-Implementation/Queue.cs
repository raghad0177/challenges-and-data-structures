using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Stack_and_Queue_Implementation
{
    public class Queue
    {//FIFO
        private Node front;
        private Node back;
        public Queue()
        {
            front = back = null;
        }
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            // check if the queue is empty
            if (back == null)
            {
                front = back = newNode;
            }
            else
            {
                back.Next = newNode;
                back = newNode;
            }
        }
        // implement the Dequeue
        public int Dequeue()
        {
            int result = 0;
            Node newNode = new Node();
            // check if the queue is empty
            if (back == null)
            {
                front = back = newNode;
            }
            else
            {
                result =  front.Data;
                front = front.Next;
            }
            return result;
        }
        public int Peek()
        {
            return front.Data;
        }
        public bool IsEmpty()
        {
            return front == null;
        }
    }
}

