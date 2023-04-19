using DSA.leetcode;

namespace Test;

public class UTSubsets2
{
    
    [Fact]
    public void Solution_Subsets2_ExampleOne_ReturnsExpected()
    {
        //Arrange
        int[] candidates = { 1,2,2 };
        var expected = new List<List<int>>
        {
            new(),
            new() { 1 },
            new() { 1,2 },
            new() { 1,2,2 },
            new() { 2 },
            new() { 2,2 }
        };

        //Act
        var output = Subsets2.Solution(candidates);
        //Assert
        Assert.Equal(output, expected);
    }

    [Fact]
    public void Solution_Subsets2_ExampleTwo_ReturnsExpected()
    {
        //Arrange
        int[] candidates = { 0 };
        var expected = new List<List<int>>
        {
            new(),
            new() { 0 }
        };

        //Act
        var output = Subsets2.Solution(candidates);
        //Assert
        Assert.Equal(output, expected);
    }

}