using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue_Implementation_Test
{
    public class DeleteMiddle
    {
        [Fact]
        public void ReverseElementsOdd()
        {
            //Arrange
            Stack_and_Queue_Implementation.Stack stack = new Stack_and_Queue_Implementation.Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            //Act
             StringWriter stringWriter = new StringWriter();
             TextWriter originalOutput = Console.Out;
             Console.SetOut(stringWriter);
             stack.DeleteMiddle(stack);
             Console.SetOut(originalOutput);
             string result = stringWriter.ToString().Trim();
           // Assert
                Assert.Equal("5 4 2 1", result);
        }
        [Fact]
        public void ReverseElementsEven()
        {
            //Arrange
            Stack_and_Queue_Implementation.Stack stack = new Stack_and_Queue_Implementation.Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            //Act
            StringWriter stringWriter = new StringWriter();
            TextWriter originalOutput = Console.Out;
            Console.SetOut(stringWriter);
            stack.DeleteMiddle(stack);
            Console.SetOut(originalOutput);
            string result = stringWriter.ToString().Trim();
            // Assert
            Assert.Equal("6 5 4 2 1", result);
        }
    }
}
