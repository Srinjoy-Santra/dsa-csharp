using DSA.ctci;

namespace Test;

public class UTZeroMatrix
{
    [Fact]
    public void MySolution_ZeroMatrix_ReturnsExpected()
    {
        //Arrange
        int[,] orgMatrix = new int[,] {
            {1,0,3},
            {4,5,6},
            {0,8,9},
        }, expected = {
            {0,0,0},
            {0,0,6},
            {0,0,0},
        } ;
        //Act
        var result = ZeroMatrix.MySolution(orgMatrix);
        //Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Solution_ZeroMatrix_ReturnsExpected()
    {
        //Arrange
        int[,] orgMatrix = new int[,] {
            {1,0,3},
            {4,5,6},
            {7,8,9},
        }, expected = {
            {0,0,0},
            {4,0,6},
            {7,0,9},
        } ;
        //Act
        ZeroMatrix.Solution(orgMatrix);
        //Assert
        Assert.Equal(expected, orgMatrix);
    }
}
