using DSA.grokking;

namespace Test;
public class UTAverageOfSubarrayOfSizeK
{
    [Theory]
    [InlineData(new int[]{ 1, 3, 2, 6, -1, 4, 1, 8, 2}, 5, new double[]{2.2, 2.8, 2.4, 3.6, 2.8})]
    public void Solution_MinSizeSubArraySum_ReturnsExpected(int[] array, int k, double[] expected)
    {
        //Arrange
        //Act
        var result = AverageOfSubarrayOfSizeK.Solution(k, array);
        //Assert
        Assert.Equal(expected, result);
    }

}