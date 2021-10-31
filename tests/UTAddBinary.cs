using dsa.leetcode;
using Xunit;

/*
    Best Practices : https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices
*/
namespace tests
{
    public class UTAddBinary
    {
        [Fact]
        public void Solution_TwoNumbers_ReturnsExpected()
        {
            //Arrange
            const string firstNum = "1010", secondNum = "1011", expected = "10101";
            //Act
            var result = AddBinary.Solution(firstNum, secondNum);
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Solution_TwoNumbers_DoesNotReturnExpected()
        {
            //Arrange
            const string firstNum = "1010", secondNum = "1011", expected = "10001";
            //Act
            var result = AddBinary.Solution(firstNum, secondNum);
            //Assert
            Assert.NotEqual(result, expected);
        }

        [Theory]
        [InlineData("11", "1", "100")]
        [InlineData("1010", "1011", "10101")]
        public void Solution_MultipleTwoNumbers_ReturnsExpected(string firstNum, string secondNum, string expected)
        {
            //Arrange
            //Act
            var result = AddBinary.Solution(firstNum, secondNum);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}
