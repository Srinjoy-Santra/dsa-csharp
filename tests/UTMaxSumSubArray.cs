using dsa.grokking;
using Xunit;

namespace tests;

public class UTMaxSumSubArrayOfSizeK
{
    [Theory]
    [InlineData(new int[]{2,1,5,1,3,2},3, 9)]
    [InlineData(new int[]{2,3,4,1,5},2, 7)]
    public void Solution_MaxSum_ReturnsExpected(int[] array, int k, int expected)
    {
        //Arrange
        //Act
        var result = MaxSumSubArrayOfSizeK.Solution(array, k);
        //Assert
        Assert.Equal(expected, result);
    }

}