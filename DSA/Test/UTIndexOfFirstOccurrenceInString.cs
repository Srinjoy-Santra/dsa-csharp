using DSA.leetcode;

namespace Test;

public class UTIndexOfFirstOccurrenceInString
{
    [Theory]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("leetcode", "leeto", -1)]
    [InlineData("fourscoreandsevenyearsagoourfathersbroughtforthuponthiscontinentanewnatio", "ourfathersbroughtforthuponthiscontinentanewnation", 25)]
    public void Solution_StrStrRK_ReturnsExpected(string haystack, string needle, int expected)
    {
        //Arrange
        var instance = new IndexOfFirstOccurenceInString();
        //Act
        var result = instance.StrStrRK(haystack, needle);
        //Assert
        Assert.Equal(expected, result);
    }
}