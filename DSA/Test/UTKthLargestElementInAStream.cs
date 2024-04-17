using DSA.leetcode;

namespace Test;

public class UTKthLargestElementInAStream
{
    [Theory]
    [InlineData(new[]{4,5,8,2}, 3, new[]{3,5,10,9,4}, new[]{4,5,5,8,8})]
    // Use TheoryData https://www.milanjovanovic.tech/blog/creating-data-driven-tests-with-xunit
    public void Solution_ReturnsExpected(int[] nums, int k, int[] adds, int[] expects)
    {
        //Arrange
        var instance = new KthLargestElementInAStream(k, nums);

        for(int i=0;i<expects.Length;i++)
        {
            //Act
            var result = instance.Add(adds[i]);
            //Assert
            Assert.Equal(expects[i], result);
        }

    }

}