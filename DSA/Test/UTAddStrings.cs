using DSA.leetcode;

/*
    Best Practices : https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices
*/
namespace Test
{
    public class UTAddStrings
    {
        [Theory]
        [InlineData("11", "123", "134")]
        [InlineData("456", "77", "533")]
        [InlineData("0", "0", "0")]
        public void Solution_MultipleTwoStrings_ReturnsExpected(string firstNum, string secondNum, string expected)
        {
            //Arrange
            //Act
            var result = AddStrings.Solution(firstNum, secondNum);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}
