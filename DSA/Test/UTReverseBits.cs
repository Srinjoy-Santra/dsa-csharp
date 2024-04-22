using DSA.leetcode;

namespace Test;

public class UTReverseBits
{
    [Theory]
    [InlineData(43261596, 964176192)]
    [InlineData(4294967293, 3221225471 )]
    public void Solution_UTReverseBits_ReturnsExpected(uint n, uint expected)
    {
        //Arrange
        var instance = new ReverseBits();
        //Act
        var result = instance.Solution(n);
        //Assert
        Assert.Equal(expected, result);
    }
}