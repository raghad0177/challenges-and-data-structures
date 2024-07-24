using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue_Implementation_Test
{
    public class Queue_Test
    {
        // Test enqueuing a node into the queue.
        [Fact]
        public void EnqueTest()
        {
            //Arrange
            Stack_and_Queue_Implementation.Queue queue = new Stack_and_Queue_Implementation.Queue();
            //Act
            queue.Enqueue(1);
            //Assert
            Assert.False(queue.IsEmpty());
            Assert.Equal(queue.Peek(), 1);
        }
        // Test dequeuing a node from the queue.
        [Fact]
        public void DenqueTest()
        {
            //Arrange
            Stack_and_Queue_Implementation.Queue queue = new Stack_and_Queue_Implementation.Queue();
            //Act
            queue.Enqueue(1);
            queue.Enqueue(2);
            //Assert
            Assert.Equal(queue.Dequeue(), 1);
            Assert.Equal(queue.Peek(), 2);
        }
        // Test checking if the queue is empty.
        [Fact]
        public void EmptyTest()
        {
            //Arrange
            Stack_and_Queue_Implementation.Queue queue = new Stack_and_Queue_Implementation.Queue();
            //Act
            queue.Enqueue(1);
            queue.Dequeue();
            //Assert
            Assert.True(queue.IsEmpty());
        }
    }
}
