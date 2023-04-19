using DSA.leetcode;
using DSA.practice.Trees.BinaryTrees;

namespace Test;

public class UTBuildBinaryTree
{

    [Fact]
    public void Solution_ExampleOne_ReturnsExpected()
    {
        //Arrange
        Node root = new(3);
        root.Left = new Node(9);
        root.Right = new Node(20);
        root.Right.Left = new Node(15);
        root.Right.Right = new Node(7);

        int expected = 3;
        
        //Act
        var result = MaxDepthBinaryTree.MaxDepth(root);
        //Assert
        Assert.Equal(expected, result);
    }
    
    public void Solution_ExampleTwo_ReturnsExpected()
    {
        //Arrange
        Node root = new(1);
        root.Right = new Node(2);

        int expected = 2;
        
        //Act
        var result = MaxDepthBinaryTree.MaxDepth(root);
        //Assert
        Assert.Equal(expected, result);
    }
}
