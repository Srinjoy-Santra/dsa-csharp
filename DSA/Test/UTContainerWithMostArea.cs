using DSA.leetcode;

namespace Test;

public class UTContainerWithMostArea
{
    [Theory]
    [InlineData(new[]{1,8,6,2,5,4,8,3,7}, 49)]
    [InlineData(new[]{1,1}, 1)]
    public void Solution_Numberof1Bits_ReturnsExpected(int[] heights, int expected)
    {
        //Arrange
        var instance = new ContainerWithMostWater();
        //Act
        var result = instance.MaxArea(heights);
        //Assert
        Assert.Equal(expected, result);
    }
}