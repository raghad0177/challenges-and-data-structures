using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace Tree_Test
{
    public class LevelMaxNodes
    {

        [Fact]
        public void Max()
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new TNode(1);
            Btree.Root.Left = new TNode(2);
            Btree.Root.Right = new TNode(3);
            Btree.Root.Left.Left = new TNode(4);
            Btree.Root.Left.Right = new TNode(5);
            Btree.Root.Right.Right = new TNode(6);
            Btree.Root.Left.Left.Left = new TNode(7);
            Btree.Root.Left.Left.Right = new TNode(8);
            int result = Btree.LargestLevelValue();
            Assert.Equal(2, result);
        }

        [Fact]
        public void MaxSameTwo()
        {
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new TNode(1);
            Btree.Root.Left = new TNode(2);
            Btree.Root.Right = new TNode(3);
            Btree.Root.Left.Left = new TNode(4);
            Btree.Root.Left.Right = new TNode(5);
            Btree.Root.Right.Right = new TNode(7);
            Btree.Root.Left.Left.Left = new TNode(8);
            Btree.Root.Left.Right.Left = new TNode(9);
            Btree.Root.Right.Right.Left = new TNode(10);
            int result = Btree.LargestLevelValue();
            Assert.Equal(2, result);
        }
    }
}
