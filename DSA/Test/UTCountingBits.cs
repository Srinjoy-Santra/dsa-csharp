using DSA.leetcode;

namespace Test;

public class UTCountingBits
{
    [Theory]
    [InlineData(2, new[]{0,1,1})]
    [InlineData(5, new[]{0,1,1,2,1,2})]
    public void Solution_CountingBits_ReturnsExpected(int n, int[] expected)
    {
        //Arrange
        var instance = new CountingBits();
        //Act
        var result = instance.Solution(n);
        //Assert
        Assert.Equal(expected, result);
    }
}