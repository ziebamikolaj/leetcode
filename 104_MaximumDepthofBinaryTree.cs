using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace leetcode
{
    internal class MaximumDepthofBinaryTree
    {
        public class Solution
        {
            public class TreeNode
            {
                public int val;
                public TreeNode left;
                public TreeNode right;
                public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
                {
                    this.val = val;
                    this.left = left;
                    this.right = right;
                }
            }
            public int MaxDepth(TreeNode root)
            {
                if (root == null)
                {
                    return 0;
                }
                else
                {
                    int leftDepth = MaxDepth(root.left);
                    int rightDepth = MaxDepth(root.right);
                    return Math.Max(leftDepth, rightDepth) + 1;
                }
            }
        }

        static void PrintTree(Solution.TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.val);
            PrintTree(root.left);
            PrintTree(root.right);
        }
        static void Main(string[] args)
        {
            Solution.TreeNode root = new Solution.TreeNode(3);
            root.left = new Solution.TreeNode(9);
            root.right = new Solution.TreeNode(20);
            root.right.left = new Solution.TreeNode(15);
            root.right.right = new Solution.TreeNode(7);

            int depth = new Solution().MaxDepth(root);
            Console.WriteLine(depth);

        }

    }
}
