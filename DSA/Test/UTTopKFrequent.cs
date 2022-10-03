using DSA.leetcode;

namespace Test;

public class UTTopKFrequent
{

    [Fact]
    public void Solution_Example1_ReturnsExpected()
    {
        //Arrange
        int[] nums = {1,1,1,2,2,3};
        int[] expected = {1,2};
        int k = 2;
        //Act
        var result = TopKFrequent.Solution(nums, k);
        //Assert
        Assert.Equal(expected, result);
    }
    
    
    [Fact]
    public void Solution_Example2_ReturnsExpected()
    {
        //Arrange
        int[] nums = {1};
        int[] expected = {1};
        int k = 1;
        //Act
        var result = TopKFrequent.Solution(nums, k);
        //Assert
        Assert.Equal(expected, result);
    }

    
}