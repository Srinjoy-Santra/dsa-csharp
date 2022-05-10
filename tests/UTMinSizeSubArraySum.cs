using dsa.grokking;

namespace tests;
using Xunit;

public class UTMinSizeSubArraySum
{
    [Theory]
    [InlineData(new int[]{2,1,5,2,3,2},7, 2)]
    [InlineData(new int[]{2,1,5,2,8},7, 1)]
    public void Solution_MinSizeSubArraySum_ReturnsExpected(int[] array, int k, int expected)
    {
        //Arrange
        //Act
        var result = MinSizeSubArraySum.Solution(array, k);
        //Assert
        Assert.Equal(expected, result);
    }

}