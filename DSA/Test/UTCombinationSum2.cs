using DSA.leetcode;

namespace Test;

public class UTCombinationSum2
{
    
    [Fact]
    public void Solution_CombinationSum2_ExampleTwo_ReturnsExpected()
    {
        //Arrange
        int[] candidates = { 2,5,2,1,2 };
        int target = 5;
        var expected = new List<List<int>>
        {
            new() { 1,2,2 },
            new() { 5 }
        };

        //Act
        var output = CombinationSum2.Solution(candidates, target);
        //Assert
        Assert.Equal(output, expected);
    }

    [Fact]
    public void Solution_CombinationSum2_ExampleOne_ReturnsExpected()
    {
        //Arrange
        int[] candidates = { 10,1,2,7,6,1,5 };
        int target = 8;
        var expected = new List<List<int>>
        {
            new() { 1,1,6 },
            new() { 1,2,5 },
            new() { 1,7 },
            new() { 2,6 },
        };

        //Act
        var output = CombinationSum2.Solution(candidates, target);
        //Assert
        Assert.Equal(output, expected);
    }

}