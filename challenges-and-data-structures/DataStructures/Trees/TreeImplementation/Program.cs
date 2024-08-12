namespace TreeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree BTree = new BinaryTree(10);
            BTree.Insert(5);
            BTree.Insert(18);
            BTree.Insert(3);
            BTree.Insert(7);
            BTree.Insert(15);
            // Printing Pre Order Traversal
            // ( Root - Left - Right )
            Console.Write("Pre Order Traversal: ");
            BTree.PreOrderTraversal(BTree.Root);
            // Printing In Order Traversal
            // ( Left - Root - Right )
            Console.Write("\nIn Order Traversal: ");
            BTree.InOrderTraversal(BTree.Root);
            // Printing Post Order Traversal
            // (Left - Right - Root)
            Console.Write("\nPost Order Traversal: ");
            BTree.PostOrderTraversal(BTree.Root);

            BinaryTree b = new BinaryTree(10);
            b.Insert(5);
            b.Insert(15);
            b.Insert(3);
            b.Insert(7);
            b.Insert(12);
            b.Insert(18);

            b.print(b.Root);
        }
    }
}
