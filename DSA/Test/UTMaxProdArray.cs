using DSA.leetcode;

namespace Test
{
    public class UTMaxProdArray
    {
        [Theory]
        [InlineData(new[]{2,3,-2,4}, 6)]
        [InlineData(new[]{-2,0,-1}, 0)]
        public void Solution_ReturnsExpected(int[] prices, int expected)
        {
            //Arrange
            //Act
            var result = MaxProdArray.Solution(prices);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}
