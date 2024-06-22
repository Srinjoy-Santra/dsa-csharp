using DSA.leetcode;

namespace Test;


public class UTMinimumWindowSubstring
{
    [Theory]
    [InlineData("ADOBECODEBANC","ABC", "BANC")]
    [InlineData("a","a", "a")]
    [InlineData("a","aa", "")]
    public void Solution_MinWindow_ReturnsExpected(string s, string t, string expected)
    {
        //Arrange
        var instance = new MinimumWindowSubstring();
        //Act
        var result = instance.MinWindow2(s,t);
        //Assert
        Assert.Equal(expected, result);
    }
}