using DSA.ctci;

namespace Test;

public class UTCheckPermutation
{
    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    public void Solution_CheckPermutation_ReturnsExpected(string s, string t, bool expected)
    {
        //Arrange
        CheckPermutation cp = new();
        //Act
        var result = cp.IsAnagram(s, t);
        //Assert
        Assert.Equal(expected, result);
    }
}