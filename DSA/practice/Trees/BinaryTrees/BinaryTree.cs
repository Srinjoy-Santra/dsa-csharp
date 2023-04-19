namespace DSA.practice.Trees.BinaryTrees;

// FCC Binary Tree Algos (https://youtu.be/fAAZixBzIAI)

public class BinaryTree
{
     internal class Node
     {
          internal char Value { get; }
          internal Node? Left { get; set; }
          internal Node? Right { get; set; }

          internal Node(char c)
          {
               Value = c;
          }
     }

     // Recursive - Preorder
     // TC = O(n), n = # of nodes
     // SC = O(n)
     private void DepthFirstTraversal(Node? root)
     {
          if (root == null)
               return;
          Console.Write(root.Value + " ,");
          DepthFirstTraversal(root.Left);
          DepthFirstTraversal(root.Right);
     }
     
     // Iterative - Preorder
     private void DFSIterative(Node? root)
     {
          if (root == null)
               return;
          Stack<Node> stack = new();
          stack.Push(root);

          while (stack.Count > 0)
          {
               var current = stack.Pop();
               
               Console.Write(current.Value + " ,");
               if(current.Right != null)
                    stack.Push(current.Right);
               if(current.Left != null)
                    stack.Push(current.Left);
          }
          
     }
     
     // Recursive
     // TC = O(n), n = # of nodes
     // SC = O(n)
     private void BreadthFirstTraversal(Node? root)
     {
          if (root == null)
               return;
          BreadthFirstTraversal(root.Left);
          Console.Write(root.Value + " ,");
          BreadthFirstTraversal(root.Right);

     }
     
     // Level Order Traversal
     private void BFSIterative(Node root)
     {
          if (root == null)
               return;
          Queue<Node> queue = new();
          queue.Enqueue(root);

          while (queue.Count > 0)
          {
               var current = queue.Dequeue();
               
               Console.Write(current.Value + " ,");
               if(current.Left != null)
                    queue.Enqueue(current.Left);
               if(current.Right != null)
                    queue.Enqueue(current.Right);
          }
     }

     public static void Run()
     {
          var a = new Node('a');
          var b = new Node('b');
          var c = new Node('c');
          var d = new Node('d');
          var e = new Node('e');
          var f = new Node('f');

          a.Left = b;
          a.Right = c;
          b.Left = d;
          b.Right = e;
          c.Right = f;

          BinaryTree bt = new BinaryTree();
          bt.DepthFirstTraversal(a);
          Console.WriteLine();
          bt.DFSIterative(a);
          Console.WriteLine();
          
          bt.DepthFirstTraversal(null);
          Console.WriteLine();
          bt.DFSIterative(null);
          Console.WriteLine();
          
          bt.BreadthFirstTraversal(a);
          Console.WriteLine();
          bt.BFSIterative(a);
          Console.WriteLine();
     }


}