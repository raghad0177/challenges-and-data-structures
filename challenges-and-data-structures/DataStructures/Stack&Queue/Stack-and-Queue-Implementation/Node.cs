using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue_Implementation
{
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }
        public Node(int data)
        {
            Data = data;
        }
        public Node()
        {

        }
    }
}
