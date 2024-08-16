namespace Tree_Test
{
    public class UnitTest1
    {
        [Fact]
        public void AddingNode()
        {
            // Arrange
            var bst = new TreeImplementation.BinarySearchTree(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(3);
            bst.Add(7);
            bst.Add(12);
            bst.Add(18);

            // Act
            bool contains3 = bst.Contains(3, bst.Root);
            bool contains7 = bst.Contains(7, bst.Root);
            bool contains12 = bst.Contains(12, bst.Root);
            bool contains18 = bst.Contains(18, bst.Root);
            bool contains20 = bst.Contains(20, bst.Root);

            // Assert
            Assert.True(contains3);  
            Assert.True(contains7);
            Assert.True(contains12);
            Assert.True(contains18);
            Assert.False(contains20);

        }

        [Fact]
        public void Check()
        {
            // Arrange
            TreeImplementation.BinarySearchTree b = new TreeImplementation.BinarySearchTree(10);
            b.Add(5);
            b.Add(15);
            b.Add(2);
            b.Add(7);
            b.Add(12);
            b.Add(20);
            //act

            //assert
            Assert.True(b.Contains(15, b.Root));

        }

        [Fact]
        public void RemovingNode()
        {
            // Arrange
            var bst = new TreeImplementation.BinarySearchTree(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(3);
            bst.Add(7);
            bst.Add(12);
            bst.Add(18);

            // Act
            bst.Root = bst.deleteRecursively(bst.Root, 15);
            bool contains15 = bst.Contains(15, bst.Root);
            bool contains18 = bst.Contains(18, bst.Root);

            // Assert
            Assert.False(contains15);
            Assert.True(contains18);
        }
    }
}