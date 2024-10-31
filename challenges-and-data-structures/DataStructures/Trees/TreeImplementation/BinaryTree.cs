using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
            if (node == null) { return; }
            TNode current = node.Left;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Right;
                if (node != null)
                {
                    if (node.Left != null && node.Left.Right != null)
                    {
                        Console.WriteLine(node.Left.Right.Value);
                    }
                }
            }
            while (current != null)
            {
                TNode temp = current;
                current = current.Right;
                if (current == null && temp.Left != null)
                {
                    current = temp.Left;
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
        public  void Helper(List<int> largest,TNode root, int level){
            if (root == null)
                return;
            if (level == largest.Count)
                largest.Add(root.Value);
            else
                largest[level] = Math.Max(largest[level], root.Value);
            Helper(largest, root.Left, level + 1);
            Helper(largest, root.Right, level + 1);
        }
        public  List<int> LargestValues(TNode root)
        {
            List<int> level = new List<int>();
            Helper(level, root, 0);
            return level;
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
        int max = 0;
        int max2 = 0;
        public int FindSecondMax(TNode node)
        {
            if (node == null) return 0;

            if (node.Value > max)
            {
                max2 = max;
                max = node.Value;
            }

            if (node.Value > max2 && node.Value < max)
            {
                max2 = node.Value;
            }
            FindSecondMax(node.Left);
            FindSecondMax(node.Right);

            return max2;
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
        List<int> lists = new List<int>();      
        public void BTToList(TNode node)
        {
            if (node == null) return; 
            lists.Add(node.Value); 
            BTToList(node.Left);
            BTToList(node.Right);
        }
        public TNode BTToBST(TNode node)
        {
            BTToList(node); 
            lists.Sort();
            return Result(lists, 0, lists.Count-1);           
        }
        public TNode Result(List<int> sorted, int start, int end)
        {
            if (start > end)
            {
                return null; 
            }
            int mid = (start + end) / 2; 
            TNode nodes = new TNode(sorted[mid]);
            nodes.Left = Result(sorted, start, mid - 1); 
            nodes.Right = Result(sorted, mid + 1, end); 
            return nodes; 
        }
        public bool Contains(int value, TNode node)
        {
            if (node == null) return false;
            if (value == node.Value) return true;

            else if (value < node.Value)
            {
                return Contains(value, node.Left);
            }
            else if (value > node.Value)
            {
                return Contains(value, node.Right);
            }
            else return false;
        }

        //1- Symmetric (Interview)
        public bool SymmetricPub(TNode node)
        {
            if (node == null) return false;
            if (node.Left == null || node.Right==null) return false;
            return Symmetric(node.Left,node.Right);
        }
        private bool Symmetric(TNode left , TNode right)
        {
            if(left == null && right == null) return true;
            //if(left.Value == right.Value)
            //{
            //    return Symmetric(left.Left, right.Right) && Symmetric(left.Right, right.Left);
            //}
            return (left.Value == right.Value) && Symmetric(left.Left,right.Right) && Symmetric(left.Right,right.Left);
        }
        //2- MaxDepth (Interview)
        public int MaxDepth(TNode node)
        {
           if(node == null) return 0;
           if(node.Left == null && node.Right == null) return 1;
           return Math.Max(MaxDepth(node.Left),MaxDepth(node.Right))+1;
        }
        //3- MinDepth (Interview)
        public int MinDepth(TNode node)
        {
            if (node == null) return 0;
            if (node.Left == null && node.Right == null) return 1;
            return Math.Min(MinDepth(node.Left), MinDepth(node.Right)) + 1;
        }
        //4- Inverted (swapping right to left and left to right) (Interview)
        public TNode Inverted(TNode node)
        {
            if(node == null) return null;
            if (node.Left ==null && node.Right == null) return node;
            TNode temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;
            Inverted(node.Left) ;
            Inverted(node.Right) ;
            return node;
        }
        //5- Diameeter BTree (Interview)
        int diameeter = 0;
        public int DiameeterPub(TNode node)
        {
            Diameeter(node);
            return diameeter;
        }
        private int Diameeter(TNode node)
        {
            if (node == null) return 0;         
            diameeter = Math.Max(diameeter, Diameeter(node.Left) + Diameeter(node.Right));
            return Math.Max(Diameeter(node.Left), Diameeter(node.Right)) +1;
        }
        //6- Same Two Tree ? (Interview)
        public bool IsSame(TNode node,TNode node2)
        {
            if(node == null && node2 == null) return true;
            if (node == null || node2 ==null ) return false;
            if(node.Value != node2.Value) return false;
            return IsSame(node.Left, node2.Left) && IsSame(node.Right,node2.Right);
        }
        //7- Sorted Array To BST (Interview)
        public TNode ArrToBST(int[] array)
        {
            return ConvertToBST(array, 0, array.Length - 1);
        }
        private TNode ConvertToBST(int[] array, int start, int end)
        {
            if (start > end)
            {
                return null;// {1,2,3,4,5,6,7,8,9,10}
            }
            int mid = (start + end) / 2;
            TNode node = new TNode(array[mid]);
            node.Left = ConvertToBST(array, start, mid - 1);
            node.Right = ConvertToBST(array, mid + 1, end);
            return node;
        }
        //8- Merged Two BinaryTree (Interview)
        public TNode MergeTwoBT(TNode node,TNode node2)
        {
            if (node == null && node2 == null) return null;
            int root = (node?.Value ?? 0) + (node2?.Value ?? 0);
            TNode merged =new TNode(root);
            merged.Left = MergeTwoBT(node?.Left, node2?.Left);
            merged.Right = MergeTwoBT(node2?.Right, node?.Right);
            return merged;
        }
        //9- Balanced  |leftDepth - rightDepth| <=1  (Interview)
        public bool IsBalancedPub(TNode node)
        {
            return IsBlanced(node) != -1;           
        }
        public int IsBlanced(TNode node)
        {
            if(node == null) return 0;

            if((Math.Abs(IsBlanced(node.Left) - IsBlanced(node.Right)) > 1) ) return -1;

            return Math.Max(IsBlanced(node.Left), IsBlanced(node.Right)) +1;
        }
         //      5
         //     / \
         //    4   8
         //   /   / \
         //  11  13  4
         // /  \      \
        // 7    2      1
        //10- PathSum  (Interview)
        public bool HasPathSum(TNode node, int target)// tree , 22 
        {
            if(node==null)return false;
            if(node.Left == null && node.Right ==null) return node.Value == target ;
            //int result = target - node.Value;// 17 -->  13 --> 2 
            return HasPathSum(node.Left, target - node.Value) || HasPathSum(node.Right, target - node.Value);// 17 -->  13 --> 2 
        }
        //11- Validate (Interview)
        // The Wrong Code
        //public bool IsValidate(TNode node)
        //{
        //    if (node == null) return true;
        //    //if (node.Left == null) return true;
        //    //if (node.Right == null) return true;

        //    if (node.Left != null && node.Left.Value > node.Value)
        //    {
        //        return false;
        //    }
        //    if (node.Right != null && node.Right.Value < node.Value)
        //    {
        //        return false;
        //    }
        //    return IsValidate(node.Left) && IsValidate(node.Right);
        //}
        // Abed Solution , Wrong Solution As My Code 
        //public bool IsValidate(TNode node)
        //{
        //    if (node == null) return false;
        //    if (node.Left.Value < node.Value && node.Right.Value > node.Value) return true;

        //    IsValidate(node.Left);
        //    IsValidate(node.Right);
        //    return false;
        //}
        // The right one
        public bool IsValidate(TNode node, int? min = null, int? max = null)
        {
            if (node == null) return true;
            // Check if the current node violates the min/max constraints
            if ((min != null && node.Value <= min) || (max != null && node.Value >= max))
            {
                return false;
            }
            // Recursively validate the left subtree (everything must be < node.Value)
            // and the right subtree (everything must be > node.Value)
            return IsValidate(node.Left, min, node.Value) && IsValidate(node.Right, node.Value, max);
        }
        //12- ( Root - Left - Right ) (Interview)
        public void PreOrderTraversal(TNode node)
        {
            if (node == null) return; // Base case if node null then return
            Console.Write(node.Value + "  ");
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }
        //13- ( Left - Root - right ) (Interview)
        public void InOrderTraversal(TNode node)
        {
            if (node == null) return;
            InOrderTraversal(node.Left);
            Console.Write(node.Value + "  ");
            InOrderTraversal(node.Right);
        }
        //14- ( Left - Right - Root ) (Interview)
        public void PostOrderTraversal(TNode node)
        {
            if (node == null) return;
            InOrderTraversal(node.Left);
            InOrderTraversal(node.Right);
            Console.Write(node.Value + "  ");
        }
    }
}
