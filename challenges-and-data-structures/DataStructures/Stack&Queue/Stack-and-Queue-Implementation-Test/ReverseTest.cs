using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue_Implementation_Test
{
    public class ReverseTest
    {
        [Fact]
        public void ReverseElements()
        {
            //Arrange
            Stack_and_Queue_Implementation.Stack stack = new Stack_and_Queue_Implementation.Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            //Act
            stack.ReverseStack(stack);
            //Assert
            Assert.Equal(1,stack.Peek());
        }
        [Fact]
        public void ReverseOneElement()
        {
            //Arrange
            Stack_and_Queue_Implementation.Stack stack = new Stack_and_Queue_Implementation.Stack();
            stack.Push(1);
            //Act
            stack.ReverseStack(stack);
            //Assert
            Assert.Equal(1, stack.Peek());
        }
        [Fact]
        public void ReverseEmpty()
        {
            //Arrange
            Stack_and_Queue_Implementation.Stack stack = new Stack_and_Queue_Implementation.Stack();
            //Act
            stack.ReverseStack(stack);
            //Assert
            Assert.True(stack.IsEmpty());
        }
    }
}
