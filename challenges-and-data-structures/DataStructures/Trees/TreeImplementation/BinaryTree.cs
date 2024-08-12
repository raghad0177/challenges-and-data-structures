using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    internal class BinaryTree
    {
        public TNode Root { get; set; }
        public BinaryTree(int rootValue)
        {
            Root = new TNode(rootValue);
        }
        public void Insert(int value)  
        {
            Insert(Root, value);
        }
        private void Insert(TNode node, int value)
        {
            if (value < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new TNode(value);
                }
                else
                {
                    Insert(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new TNode(value);
                }
                else
                {
                    Insert(node.Right, value);
                }
            }
        }
        // ( Root - Left - Right )
        public void PreOrderTraversal(TNode node)
        {
            if (node == null) return; // Base case if node null then return
            Console.Write(node.Value + "  ");
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);

        }
        // ( Left - Root - right )
        public void InOrderTraversal(TNode node)
        {
            if (node == null) return;
            InOrderTraversal(node.Left);
            Console.Write(node.Value + "  ");
            InOrderTraversal(node.Right);
        }

        // ( Left - Right - Root )
        public void PostOrderTraversal(TNode node)
        {
            if (node == null) return;
            InOrderTraversal(node.Left);
            InOrderTraversal(node.Right);
            Console.Write(node.Value + "  ");
        }
        public void print(TNode node)
        {
            Console.WriteLine("----------------------------->");
            print2DUtil(node, 0);
        }

        int COUNT = 7;
        private void print2DUtil(TNode root, int space)
        {

            // Base case
            if (root == null)
                return;
            // Increase distance between levels
            space += COUNT;
            // Process right child first
            print2DUtil(root.Right, space);
            // Print current node after space
            // count
            Console.Write("\n");
            for (int i = COUNT; i < space; i++)
                Console.Write(" ");
            Console.Write(root.Value + "\n");
            // Process left child
            print2DUtil(root.Left, space);
        }
    }
}
