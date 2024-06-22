using DSA.ctci;

namespace Test;

public class UTPalindromePermutation
{
    [Theory]
    [InlineData("Tact Coba", false)]
    [InlineData("Tact Coa", true)]
    public void Solution_PalindromePermutation_ReturnsExpected(string str, bool expected)
    {
        //Arrange
        //Act
        var result = PalindromePermutation.Solution(str);
        //Assert
        Assert.Equal(expected, result);
    }
}
