using System.Xml.Linq;

namespace TreeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree BTree1 = new BinaryTree(10);
            BTree1.Insert(5);
            BTree1.Insert(18);
            BTree1.Insert(3);
            BTree1.Insert(7);
            BTree1.Insert(15);
            // Printing Pre Order Traversal
            // ( Root - Left - Right )
            Console.Write("Pre Order Traversal: ");
            BTree1.PreOrderTraversal(BTree1.Root);
            // Printing In Order Traversal
            // ( Left - Root - Right )
            Console.Write("\nIn Order Traversal: ");
            BTree1.InOrderTraversal(BTree1.Root);
            // Printing Post Order Traversal
            // (Left - Right - Root)
            Console.Write("\nPost Order Traversal: ");
            BTree1.PostOrderTraversal(BTree1.Root);

            BinaryTree b = new BinaryTree(10);
            b.Insert(5);
            b.Insert(15);
            b.Insert(3);
            b.Insert(7);
            b.Insert(12);
            b.Insert(18);
            b.print(b.Root);

            BinaryTree Btree = new BinaryTree(4);
            Btree.Root.Left = new TNode(8);
            Btree.Root.Right = new TNode(7);
            Btree.Root.Left.Left = new TNode(12);
            Btree.Root.Left.Right = new TNode(9);

            Console.WriteLine("Tree & Its Mirror : ");
            Console.WriteLine("Before");
            List<int> list = Btree.InorderTraversal(Btree.Root);
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine("After");
            List<int> list2 = Btree.MirrorTree(Btree.Root);
            foreach (int i in list2)
            {
                Console.Write(i + " ");
            }
            BinaryTree Btree2 = new BinaryTree(10);
            Btree2.Root.Left = new TNode(5);
            Btree2.Root.Right = new TNode(20);
            Btree2.Root.Left.Left = new TNode(3);
            Btree2.Root.Left.Right = new TNode(7);
            Btree2.Root.Right.Left = new TNode(15);
            Btree2.Root.Right.Right = new TNode(25);
            Console.WriteLine();
            int secondMax = Btree2.FindSecondMax(Btree2.Root); // Output: 20
            Console.WriteLine(secondMax);
            Console.WriteLine();
            BinaryTree Btree3 = new BinaryTree(9);
            Btree3.Root.Left = new TNode(8);
            Btree3.Root.Right = new TNode(12);
            Btree3.Root.Left.Left = new TNode(3);
            Btree3.Root.Left.Right = new TNode(7);
            Btree3.Root.Right.Left = new TNode(17);
            Btree3.Root.Right.Right = new TNode(23);
            Btree3.Root.Left.Left.Right = new TNode(4);
            int leafSum = Btree3.LeafSum(Btree3.Root); // Output: 51
            Console.WriteLine("Som of Leaf Nodes : "+ leafSum);
        }

    }
}
