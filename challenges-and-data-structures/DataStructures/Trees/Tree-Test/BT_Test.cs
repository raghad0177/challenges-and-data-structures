using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace Tree_Test
{
    public class BT_Test
    {
        [Fact]
        public void PreOrderTraversal()
        {
            // Arrange
            BinaryTree b = new BinaryTree(10);
            b.Insert(5);
            b.Insert(15);
            b.Insert(2);
            b.Insert(7);
            b.Insert(12);
            b.Insert(20);

            List<int> expectedOutput = new List<int> { 10, 5, 2, 7, 15, 12, 20 };
            List<int> actualOutput = new List<int>();

            // Inserting output
            void PreOrder(TNode node)
            {
                if (node == null) return;
                actualOutput.Add(node.Value);
                PreOrder(node.Left);
                PreOrder(node.Right);

            }

            // Act
            PreOrder(b.Root);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
        [Fact]
        public void InOrderTraversal()
        {
            // Arrange
            BinaryTree b = new BinaryTree(10);
            b.Insert(5);
            b.Insert(15);
            b.Insert(2);
            b.Insert(7);
            b.Insert(12);
            b.Insert(20);

            List<int> expectedOutput = new List<int> { 2, 5, 7, 10, 12, 15, 20 };
            List<int> actualOutput = new List<int>();

            // Inserting output
            void InOrder(TNode node)
            {
                if (node == null) return;
                InOrder(node.Left);
                actualOutput.Add(node.Value);
                InOrder(node.Right);
            }

            // Act
            InOrder(b.Root);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);

        }
        [Fact]
        public void PostOrderTraversal()
        {
            // Arrange
            BinaryTree b = new BinaryTree(10);
            b.Insert(5);
            b.Insert(15);
            b.Insert(2);
            b.Insert(7);
            b.Insert(12);
            b.Insert(20);

            List<int> expectedOutput = new List<int> { 2, 7, 5, 12, 20, 15, 10 };
            List<int> actualOutput = new List<int>();

            // Inserting output
            void PostOrder(TNode node)
            {
                if (node == null) return;
                PostOrder(node.Left);
                PostOrder(node.Right);
                actualOutput.Add(node.Value);
            }

            // Act
            PostOrder(b.Root);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);

        }
    }
}
