using DSA.leetcode;

namespace Test;

public class UTProductExceptItself
{
    
    [Theory]
    [InlineData(new int[]{1,2,3,4},new[]{23,12,8,6})]
    [InlineData(new int[]{2,3,4,1,5}, new[]{-1,1,0,-3,3})]
    public void Solution_ProductExceptItself_ReturnsExpected(int[] array, int[] expected)
    {
        //Arrange
        //Act
        var result = ProductExceptSelf.Solution(array);
        //Assert
        Assert.Equal(expected, result);
    }
}