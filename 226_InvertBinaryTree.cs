using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace leetcode
{
    internal class InvertBinaryTree
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
            public TreeNode InvertTree(TreeNode root)
            {
                return InvertTreeCompute(root, null);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            private TreeNode InvertTreeCompute(TreeNode root, TreeNode parent)
            {
                if (root == null)
                {
                    return null;
                }

                TreeNode temp = root.left;
                root.left = root.right;
                root.right = temp;

                TreeNode newParent = root;
                root = root.left;
                parent = newParent;
                InvertTreeCompute(root, parent);

                root = parent.right;
                parent = newParent;
                InvertTreeCompute(root, parent);

                return newParent;
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
            Solution.TreeNode root = new Solution.TreeNode(4,
                new Solution.TreeNode(2, new Solution.TreeNode(1), new Solution.TreeNode(3)),
                new Solution.TreeNode(7, new Solution.TreeNode(6), new Solution.TreeNode(9))
            );

            Console.WriteLine("Original tree:");
            PrintTree(root);

            Solution solution = new Solution();
            root = solution.InvertTree(root);

            Console.WriteLine("Inverted tree:");
            PrintTree(root);
        }


    }
}
