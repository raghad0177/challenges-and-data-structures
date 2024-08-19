using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace Tree_Test
{
    public class SecMax
    {
        [Fact]
        public void Test1()
        {
            BinaryTree Btree2 = new BinaryTree(10);
            Btree2.Root.Left = new TNode(5);
            Btree2.Root.Right = new TNode(20);
            Btree2.Root.Left.Left = new TNode(3);
            Btree2.Root.Left.Right = new TNode(7);
            Btree2.Root.Right.Left = new TNode(15);
            Btree2.Root.Right.Right = new TNode(25);
            int expected = 20;
            int secondMax = Btree2.FindSecondMax(Btree2.Root); // Output: 20
            Assert.Equal(expected, secondMax);
        }
        [Fact]
        public void TestUnique()
        {
            BinaryTree Btree2 = new BinaryTree(10);
            int expected = 10;
            int secondMax = Btree2.FindSecondMax(Btree2.Root); // Output: 20
            Assert.Equal(expected, secondMax);
        }
        [Fact]
        public void TestNegative()
        {
            BinaryTree Btree1 = new BinaryTree(10);
            Btree1.Root.Left = new TNode(5);
            Btree1.Root.Right = new TNode(20);
            Btree1.Root.Left.Left = new TNode(-3);
            Btree1.Root.Left.Right = new TNode(7);
            Btree1.Root.Right.Left = new TNode(15);
            Btree1.Root.Right.Right = new TNode(25);
            int expected = 20;
            int secondMax = Btree1.FindSecondMax(Btree1.Root); // Output: 20
            Assert.Equal(expected, secondMax);
        }
    }
}
