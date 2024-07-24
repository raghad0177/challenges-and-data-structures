namespace Stack_and_Queue_Implementation_Test
{
    public class Stack_Test
    {
        //Test pushing a node onto the stack.
        [Fact]
        public void PushTest()
        {
            //Arrange
            Stack_and_Queue_Implementation.Stack stack = new Stack_and_Queue_Implementation.Stack();
            //Act
            stack.Push(1);
            //Arrange
            Assert.False(stack.IsEmpty());
            Assert.Equal(1,stack.Peek());
        }
        // Test popping a node from the stack.
        [Fact]
        public void PopTest()
        {
            //Arrange
            Stack_and_Queue_Implementation.Stack stack = new Stack_and_Queue_Implementation.Stack();
            //Act
            stack.Push(1);
            stack.Push(2);
            //Arrange
            Assert.Equal(2, stack.Pop());
            Assert.Equal(1, stack.Peek());
        }
        // Test checking if the stack is empty.
        [Fact]
        public void EmptyTest()
        {
            Stack_and_Queue_Implementation.Stack stack = new Stack_and_Queue_Implementation.Stack();
            //Act
            stack.Push(1);
            stack.Pop();
            //Arrange
            Assert.True(stack.IsEmpty());
        }
    }
}