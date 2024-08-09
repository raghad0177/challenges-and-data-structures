using Stack_and_Queue_Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue_Implementation_Test
{
    public class MinTest
    {
        [Fact]
        public void AfterPush()
        {
            // Arrange
            var minStack = new MinStack();
            minStack.Push(15);
            minStack.Push(7);
            minStack.Push(12);
            minStack.Push(3);

            // Act
            int min = minStack.GetMin();
             
            // Assert
            Assert.Equal(3, min); 
        }

        [Fact]
        public void AfterPop()
        {
            // Arrange
            var minStack = new MinStack();
            minStack.Push(15);
            minStack.Push(7);
            minStack.Push(12);
            minStack.Push(3);
            minStack.Pop(); 

            // Act
            int min = minStack.GetMin();

            // Assert
            Assert.Equal(7, min); 
        }

        [Fact]
        public void PushAfterMultiplePushes()
        {
            // Arrange
            var minStack = new MinStack();
            minStack.Push(15);
            minStack.Push(7);

            // Act & Assert
            Assert.Equal(7, minStack.GetMin()); 

            minStack.Push(5);
            Assert.Equal(5, minStack.GetMin());

            minStack.Push(10);
            Assert.Equal(5, minStack.GetMin()); 
        }

        [Fact]
        public void PopAfterMultiplePushes()
        {
            // Arrange
            var minStack = new MinStack();
            minStack.Push(15);
            minStack.Push(7);
            minStack.Push(12);
            minStack.Push(3);

            // Act & Assert
            Assert.Equal(3, minStack.GetMin()); 
            minStack.Pop(); 
            Assert.Equal(7, minStack.GetMin()); 

            minStack.Pop(); 
            Assert.Equal(7, minStack.GetMin()); 

            minStack.Pop(); 
            Assert.Equal(15, minStack.GetMin()); 
        }
    }
}
