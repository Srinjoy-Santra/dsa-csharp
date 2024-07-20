using DSA.leetcode;

namespace Test;

public class UTProductExceptItself
{
    
    [Theory]
    [InlineData(new int[]{1,2,3,4},new[]{24,12,8,6})]
    [InlineData( new[]{-1,1,0,-3,3}, new []{0,0,9,0,0})]
    public void Solution_ProductExceptItself_ReturnsExpected(int[] array, int[] expected)
    {
        //Arrange
        //Act
        var result = ProductExceptSelf.Solution(array);
        //Assert
        Assert.Equal(expected, result);
    }
}