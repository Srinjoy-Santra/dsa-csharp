namespace Test;

public class UTTries
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Solution_Tries_ReturnsExpected()
    {
        //Arrange
        const string firstNum = "1010", secondNum = "1011", expected = "10101";
        //Act
        //var result = Tries.Solution(firstNum, secondNum);
        //Assert
        //Assert.Equal(expected, result);
    }

    private static readonly IEnumerable<object[][]?> TestData = new List<object[][]?>
    {
        new object[][]
        {
            new []{"Trie","insert","search","search","startsWith","insert","search"},
            new []{"","apple","apple","app","app","app","app"},
            //new? []{null,null,true,false,true,null,true},
        }
    };
}