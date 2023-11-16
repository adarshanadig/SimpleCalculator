using SimpleCalculator;

namespace SimpleCalTest;

public class UnitTest1
{
    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(1, 2, 3)]
    [InlineData(-2, 2, 0)]
    [InlineData(-4, -6, -10)]
    public void ShouldAddTwoValues_InlineData(int value1, int value2, int expectedResult)
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(value1, value2);

        // Assert
        Assert.Equal(expectedResult, result);
    }
}
