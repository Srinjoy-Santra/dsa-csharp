using DSA.leetcode;

namespace Test;

public class UTFindMedianFromDataStream
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void Solution_ReturnsExpected(string[] operations, int?[] inputs, double?[] expects)
    {
        FindMedianFromDataStream instance = null;
        for (int i = 0; i < expects.Length; i++)
        {
            switch (operations[i])
            {
                case "MedianFinder": 
                    instance = new FindMedianFromDataStream();
                    break;
                case "addNum":
                    //Arrange
                    int input = inputs[i] ?? 0;
                    // Act
                    instance.AddNum(input);
                    break;
                case "findMedian":
                default:
                    // Act
                    double result = instance.FindMedian();
                    //Assert
                    Assert.Equal(expects[i], result);
                    break;
            }
        }
    }

    public class TestData : TheoryData<string[], int?[], double?[]>
    {
        public TestData()
        {
            Add(
            new []{
                "MedianFinder", "addNum", "addNum", "findMedian", "addNum", "findMedian"
            },
            new int?[]{ null, 1, 2, null, 3, null},
            new double?[]{
                null, null, null, 1.5, null, 2.0
            });
        }
    }
}