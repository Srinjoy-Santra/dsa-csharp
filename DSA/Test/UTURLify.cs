
using DSA.ctci;
namespace Test;

public class UTURLify
{
    [Theory]
    [InlineData("Mr John Smith    ", 13, "Mr%20John%20Smith")]
    public void Solution_MultipleTwoNumbers_ReturnsExpected(string str, int length, string expected)
    {
        //Arrange
        //Act
        char[] ca = str.ToCharArray();
        URLify.Solution(ca, length);
        //Assert
        Assert.Equal(expected, new string(ca));
    }
}