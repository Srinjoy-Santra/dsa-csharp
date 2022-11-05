using DSA.leetcode;

namespace Test;

public class UTTwoSum
{
    [Theory]
    [InlineData(new[]{2,7,11,15}, 9, new[]{0,1})]
    [InlineData(new[]{3,2,4}, 6, new[]{1,2})]
    [InlineData(new[]{3,3}, 6, new[]{0,1})]
    public void Solution_TwoSum_ReturnsExpected(int[] nums, int target, int[] expected)
    {
        //Arrange
        //Act
        int[] output = TwoSum.Solution(nums, target);
        //Assert
        Assert.Equal(output, expected);
    }
}