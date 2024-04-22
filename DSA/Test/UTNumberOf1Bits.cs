using DSA.leetcode;

namespace Test;

public class UTNumberOf1Bits
{
    [Theory]
    [InlineData(11, 3)]
    [InlineData(128, 1)]
    [InlineData(2147483645, 30)]
    public void Solution_Numberof1Bits_ReturnsExpected(int n, int expected)
    {
        //Arrange
        var instance = new NumberOf1Bits();
        //Act
        var result = instance.HammingWeight(n);
        //Assert
        Assert.Equal(expected, result);
    }
}