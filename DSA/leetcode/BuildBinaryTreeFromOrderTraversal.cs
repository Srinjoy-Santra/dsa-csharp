/*
---
problem: Given two integer arrays preorder and inorder where preorder is the preorder traversal of a binary tree and inorder is the inorder traversal of the same tree, construct and return the binary tree.
tags:
  - array
  - medium
  - leetcode
  - tree
link: // https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
---
*/

using DSA.practice.Trees.BinaryTrees;

namespace DSA.leetcode;

public class BuildBinaryTreeFromOrderTraversal
{
    public static Node? BuildTree(int[] preorder, int[] inorder) {
        if(preorder.Length <= 0) return null;

        var root = new Node(preorder[0]);
        
        int i = 0;
        for(; ; i++)
            if(inorder[i] == preorder[0])
                break;
        root.Left = BuildTree(preorder[1..(i + 1)], inorder[..i]);
        root.Right = BuildTree(preorder[(i + 1)..], inorder[(i + 1)..]);
        
        return root;
    }
}