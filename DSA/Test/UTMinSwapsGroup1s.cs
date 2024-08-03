using DSA.practice;

namespace Test;

public class UTMinSwapsGroup1s
{
    [Theory]
    [InlineData(new int[]{1,0,1,0,1},1)]
    [InlineData(new int[]{1,0,1,0,1,1},1)]
    public void Solution_MinSwapsGroup1s_ReturnsExpected(int[] array, int expected)
    {
        //Arrange
        //Act
        var result = MinSwapsGroup1s.MinSwaps(array);
        //Assert
        Assert.Equal(expected, result);
    }
}