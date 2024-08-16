using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace Tree_Test
{
    public class Test2
    {
        [Fact]
        public void ConvertingTest()
        {
            BinaryTree Btree = new BinaryTree(4);
            Btree.Root.Left = new TNode(8);
            Btree.Root.Right = new TNode(7);
            Btree.Root.Left.Left = new TNode(12);
            Btree.Root.Left.Right = new TNode(9);
            List<int> l2 = Btree.MirrorTree(Btree.Root);
            string mirror = "";
            foreach(int x in l2) mirror += x+" ";
            Assert.Equal("7 4 9 8 12 ", mirror);
        }
        [Fact]
        public void SingleTest()
        {
            BinaryTree Btree = new BinaryTree(4);
            Btree.Root.Left = new TNode(8);
            List<int> l2 = Btree.MirrorTree(Btree.Root);
            string mirror = "";
            foreach (int x in l2) mirror += x + " ";
            Assert.Equal("4 8 ", mirror);
        }
        [Fact]
        public void NullTest()
        {
            BinaryTree Btree = new BinaryTree();
            List<int> l2 = Btree.MirrorTree(Btree.Root);
            Assert.Equal(null, l2);
        }
    }
}
