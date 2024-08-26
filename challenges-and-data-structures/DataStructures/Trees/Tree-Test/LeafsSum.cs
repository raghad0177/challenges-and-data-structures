using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace Tree_Test
{
    public class LeafsSum
    {
        [Fact]
        public void LeafsTest()
        {
            BinaryTree Btree3 = new BinaryTree(9);
            Btree3.Root.Left = new TNode(8);
            Btree3.Root.Right = new TNode(12);
            Btree3.Root.Left.Left = new TNode(3);
            Btree3.Root.Left.Right = new TNode(7);
            Btree3.Root.Right.Left = new TNode(17);
            Btree3.Root.Right.Right = new TNode(23);
            Btree3.Root.Left.Left.Right = new TNode(4);
            int leafSum = Btree3.LeafSum(Btree3.Root); // Output: 51
            Assert.Equal(leafSum, 51);
        }
        [Fact]
        public void LeafsNegTest()
        {
            BinaryTree Btree3 = new BinaryTree(9);
            Btree3.Root.Left = new TNode(8);
            Btree3.Root.Right = new TNode(12);
            Btree3.Root.Left.Left = new TNode(3);
            Btree3.Root.Left.Right = new TNode(-7);
            Btree3.Root.Right.Left = new TNode(17);
            Btree3.Root.Right.Right = new TNode(23);
            Btree3.Root.Left.Left.Right = new TNode(4);
            int leafSum = Btree3.LeafSum(Btree3.Root); // Output: 51
            Assert.Equal(leafSum, 37);
        }
    }
}
