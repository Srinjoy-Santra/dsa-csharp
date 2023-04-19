using System.Collections;
using DSA.leetcode;

namespace Test;

public class UTThreeSum
{
    [Fact]
    public void Solution_TwoSum_ExampleOne_ReturnsExpected()
    {
        //Arrange
        int[] nums = { -1, 0, 1, 2, -1, -4 };
        var expected = new List<List<int>>
        {
            new() { -1, -1, 2 },
            new() { -1, 0, 1 }
        };

        //Act
        var output = ThreeSum.Solution(nums);
        //Assert
        Assert.Equal(output, expected);
    }
    
    [Fact]
    public void Solution_TwoSum_ExampleTwo_ReturnsExpected()
    {
        //Arrange
        int[] nums = { 0, 1, 1};
        var expected = new List<List<int>>();

        //Act
        var output = ThreeSum.Solution(nums);
        //Assert
        Assert.Equal(output, expected);
    }
    
    [Fact]
    public void Solution_TwoSum_ExampleThree_ReturnsExpected()
    {
        //Arrange
        int[] nums = { 0,0,0 };
        var expected = new List<List<int>>
        {
            new() { 0,0,0 }
        };

        //Act
        var output = ThreeSum.Solution(nums);
        //Assert
        Assert.Equal(output, expected);
    }
}