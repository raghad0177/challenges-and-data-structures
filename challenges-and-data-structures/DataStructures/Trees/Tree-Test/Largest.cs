using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

namespace Tree_Test
{
    public class Largest
    {
       
            [Fact]
            public void Test()
            {
                BinaryTree Btree4 = new BinaryTree(5);
                Btree4.Root.Left = new TNode(13);
                Btree4.Root.Right = new TNode(7);
                Btree4.Root.Left.Left = new TNode(3);
                Btree4.Root.Left.Right = new TNode(7);
                Btree4.Root.Right.Left = new TNode(12);
                Btree4.Root.Right.Right = new TNode(20);
                Btree4.Root.Left.Left.Left = new TNode(1);
                Btree4.Root.Left.Left.Right = new TNode(4);
                Btree4.Root.Right.Left.Right = new TNode(11);
                List<int> actual = Btree4.LargestValueEachLevel(Btree4.Root);
                List<int> expected = new List<int>() { 5, 13, 20, 11 };
                Assert.Equal(expected, actual);
            }
        
    }
}
