using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TreeImplementation
{
    public class BinaryTree
    {
        public TNode Root { get; set; }
        public BinaryTree(int rootValue)
        {
            Root = new TNode(rootValue);
        }
        public BinaryTree()
        {
        }
        public void PrintRightView(TNode node)
        {
            TNode current = node.Left;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Right;
            }
            while (current != null)
            {
                TNode temp = current;
                current = current.Right;               
                if (current == null && temp.Left != null)
                {
                    current = temp.Left;
                    current = current.Right;
                }
                if (current != null)
                {
                    Console.WriteLine(current.Value);
                }
            }
        }
        List<int> list = new List<int>();
        List<int> list2 = new List<int>();
        List<int> list3 = new List<int>();
        int Max1 = 0;
        int Max2 = 0;
        public List<int> LargestValueEachLevel(TNode node)
        {
            list3.Add(node.Value);
            ///////////////////////////////////////////////////////////////////////////////
            if (node.Left.Value > node.Right.Value)
            {
                list3.Add(node.Left.Value);
            }
            else
            {
                list3.Add(node.Left.Value);
            }
            ///////////////////////////////////////////////////////////////////////////////
            if (node.Left.Left.Value > node.Left.Right.Value)
            {
                Max1 = node.Left.Left.Value;
            }
            else
            {
                Max1 = node.Left.Right.Value;
            }
            ////////////////////////////////////////////////////////////////////////////////
            if (node.Right.Left.Value > Max1)
            {
                Max1 = node.Right.Left.Value;
            }
            if (node.Right.Right.Value > Max1)
            {
                Max1 = node.Right.Right.Value;
            }
            list3.Add(Max1);
            if (node.Left.Left.Left.Value > node.Left.Left.Right.Value)
            {
                Max2 = node.Left.Left.Left.Value;
            }
            if (node.Left.Left.Left.Value < node.Left.Left.Right.Value)
            {
                Max2 = node.Left.Left.Right.Value;
            }
            if (node.Right.Left.Right.Value > Max2)
            {
                list3.Add(node.Right.Left.Right.Value);
            }
            else
            {
                list3.Add(Max2);
            }
            return list3;
        }
        int LeafSums = 0;
        public int LeafSum(TNode node)
        {
            if (node == null) return LeafSums;
            if (node.Left ==null && node.Right == null)
            {
                LeafSums += node.Value;
            }
            LeafSum(node.Left);
            LeafSum(node.Right);
            return LeafSums; 
        }
        int FirstMax = 0;
        int SecMax = 0;
        public int FindSecondMax(TNode node)
        {
            if (node == null) return SecMax;
            if (node.Value > FirstMax)
            {
                SecMax = FirstMax; 
                FirstMax = node.Value;
                if (node.Left == null && node.Right == null)
                {
                    return FirstMax;
                }
                if (node.Right != null)
                {
                    FindSecondMax(node.Right);
                }
                if (node.Right == null)
                {
                    FindSecondMax(node.Left);
                }
            }
            else if (node.Value > SecMax && node.Value < FirstMax)
            {
                SecMax = node.Value; 
            }
            if (node.Left != null)
            {
                FindSecondMax(node.Left);
            }
            if (node.Right != null)
            {
                FindSecondMax(node.Right);
            }
            return SecMax;
        }
        public List<int> MirrorTree(TNode node)
        {
            if (node == null) return null;
            MirrorTree(node.Right);
            list2.Add(node.Value);
            MirrorTree(node.Left);
            return list2;
        }
        public List<int> InorderTraversal(TNode node)
        {
            if (node == null) return null;
            InorderTraversal(node.Left);
            list.Add(node.Value);
            InorderTraversal(node.Right);
            return list;
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
        public int LargestLevelValue()
        {
            List<int> nodeCountsPerLevel = new List<int>();
            // Start by calling the helper method to calculate the count of nodes at each level
            LargestLevelValue(Root, 0, nodeCountsPerLevel);
            // Find the level with the maximum node count
            int maxLevel = 0;
            int maxNodes = nodeCountsPerLevel[0];
            for (int i = 1; i < nodeCountsPerLevel.Count; i++)
            {
                if (nodeCountsPerLevel[i] > maxNodes)
                {
                    maxNodes = nodeCountsPerLevel[i];
                    maxLevel = i;
                }
            }
            return maxLevel;
        }
        private void LargestLevelValue(TNode node, int level, List<int> nodeCountsPerLevel)
        {
            if (node == null) return;
            // If this is the first time visiting this level, initialize the count for the level
            if (level == nodeCountsPerLevel.Count)
            {
                nodeCountsPerLevel.Add(0);
            }
            // Increment the count for the current level
            nodeCountsPerLevel[level]++;
            // Recur for the left and right children
            LargestLevelValue(node.Left, level + 1, nodeCountsPerLevel);
            LargestLevelValue(node.Right, level + 1, nodeCountsPerLevel);
        }
        public int FindMinimumDepth(TNode node)
        {
            if (node == null) return 0;

            // If there is no left subtree, recur for right subtree
            if (node.Left == null) return FindMinimumDepth(node.Right) + 1;

            // If there is no right subtree, recur for left subtree
            if (node.Right == null) return FindMinimumDepth(node.Left) + 1;

            // If both left and right children exist, recur for both and take the minimum
            return Math.Min(FindMinimumDepth(node.Left), FindMinimumDepth(node.Right)) + 1;
        }
    }
}
