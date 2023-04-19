using DSA.practice.Trees.BinaryTrees;

namespace DSA.leetcode;

// https://leetcode.com/problems/maximum-depth-of-binary-tree/
public class MaxDepthBinaryTree
{
    public static int MaxDepth(Node? root) {
        if(root == null) return 0;

        int left = MaxDepth(root.Left);
        int right = MaxDepth(root.Right);

        return 1+Math.Max(left, right);
    }
}