using DSA;
using DSA.leetcode;

namespace Test;

public class UTLongestPalindromicSubstring
{

    [Fact]
    public void Solution_OddLength_ReturnsExpected()
    {
        //Arrange
        const string str = "babad", expected = "bab";
        //Act
        var result = LongestPalindromicSubstring.Solution(str);
        //Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Solution_EvenLength_ReturnsExpected()
    {
        //Arrange
        const string str = "cbbd", expected = "bb";
        //Act
        var result = LongestPalindromicSubstring.Solution(str);
        //Assert
        Assert.Equal(expected, result);
    }
}