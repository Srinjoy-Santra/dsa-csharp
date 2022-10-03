using DSA.leetcode;

namespace Test
{
    public class UTMaxSubArray
    {
        [Theory]
        [InlineData(new int[]{-2,1,-3,4,-1,2,1,-5,4}, 6)]
        [InlineData(new int[]{1}, 1)]
        [InlineData(new int[]{5,4,-1,7,8}, 23)]
        public void Solution_ReturnsExpected(int[] prices, int expected)
        {
            //Arrange
            //Act
            var result = MaxSubArray.Solution(prices);
            //Assert
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(new int[]{-2,1,-3,4,-1,2,1,-5,4}, 6)]
        [InlineData(new int[]{1}, 1)]
        [InlineData(new int[]{5,4,-1,7,8}, 23)]
        public void Solution2_ReturnsExpected(int[] prices, int expected)
        {
            //Arrange
            //Act
            var result = MaxSubArray.Solution2(prices);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}
