using DSA.ctci;

namespace Test;

public class UTSortStack
{
    [Fact]
    public void Solution_AnimalShelter_ReturnsExpected()
    {
        //Arrange
        SortStack stack = new();

        //Act
        var result = stack.IsEmpty();
        //Assert
        Assert.Equal(true, result);
        
        
        //Act
        int input = 10;
        stack.Push(input);
        int output = stack.Peek();
        //Assert
        Assert.Equal(input, output);
        
        //Act
        int input2 = 16;
        stack.Push(input2);
        output = stack.Pop();
        //Assert
        Assert.Equal(input, output);
       

    }
}