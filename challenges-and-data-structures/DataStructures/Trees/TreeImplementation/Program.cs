﻿namespace TreeImplementation
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
        }
    }
}