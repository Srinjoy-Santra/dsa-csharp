using DSA.leetcode;

namespace Test;

public class UTValidSudoku
{
    [Fact]
    public void MySolution_ValidSudoku_ReturnsExpected()
    {
        //Arrange
        char[][] orgMatrix = {
            new[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
            new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
            new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
            new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        };
        bool expected = true;
        //Act
        var result = ValidSudoku.Solution(orgMatrix);
        //Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void MySolution_ValidSudoku2_ReturnsExpected()
    {
        //Arrange
        char[][] orgMatrix = {
            new[] { '8', '3', '.', '.', '7', '.', '.', '.', '.' },
            new[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            new[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
            new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
            new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
            new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        };
        bool expected = false;
        //Act
        var result = ValidSudoku.Solution(orgMatrix);
        //Assert
        Assert.Equal(expected, result);
    }

}