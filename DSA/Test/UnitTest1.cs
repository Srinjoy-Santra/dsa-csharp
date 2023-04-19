using DSA;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(1,1);
    }
    
    [Fact]
    public void Solution_TwoNumbers_ReturnsExpected()
    {
        //Arrange
        const string firstNum = "1010", secondNum = "1011", expected = "10101";
        //Act
        var result = Class1.Solution(firstNum, secondNum);
        //Assert
        Assert.Equal(expected, result);
    }
}