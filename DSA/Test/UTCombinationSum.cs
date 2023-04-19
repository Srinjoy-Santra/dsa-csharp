using DSA.leetcode;

namespace Test;

public class UTCombinationSum
{
    
    [Fact]
    public void Solution_CombinationSum_ExampleTwo_ReturnsExpected()
    {
        //Arrange
        int[] candidates = { 2,3,5 };
        int target = 8;
        var expected = new List<List<int>>
        {
            new() { 2,2,2,2 },
            new() { 2,3,3 },
            new() { 3,5 },
        };

        //Act
        var output = CombinationSum.Solution(candidates, target);
        //Assert
        Assert.Equal(output, expected);
    }

    [Fact]
    public void Solution_CombinationSum_ExampleThree_ReturnsExpected()
    {
        //Arrange
        int[] candidates = { 2 };
        int target = 1;
        var expected = new List<List<int>>();

        //Act
        var output = CombinationSum.Solution(candidates, target);
        //Assert
        Assert.Equal(output, expected);
    }

}