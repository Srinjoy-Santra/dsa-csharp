using DSA.ctci;

namespace Test;

public class UTIsUnique
{
    [Theory]
    [InlineData("aabcef", false)]
    [InlineData("abcdefgh", true)]
    public void Solution_MultipleTwoNumbers_ReturnsExpected(string str, bool expected)
    {
        //Arrange
        //Act
        var result = IsUnique.Solution(str);
        //Assert
        Assert.Equal(expected, result);
    }
}
    


