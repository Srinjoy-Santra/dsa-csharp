using DSA.leetcode;

/*
    Best Practices : https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices
*/
namespace Test
{
    public class UTBestTimeToBuyAndSell
    {
        [Theory]
        [InlineData(new int[]{7,1,5,3,6,4}, 5)]
        [InlineData(new int[]{7,6,4,3,1}, 0)]
        public void MaxProfit_(int[] prices, int expected)
        {
            //Arrange
            //Act
            var result = BestTimeToBuyAndSellStock.MaxProfit(prices);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}
