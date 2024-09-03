using CalcLibProj;
using FluentAssertions;
using Xunit.Abstractions;

namespace CalcLibProj.Tets.Unit;

public class CalculatorTests : IAsyncLifetime
{
    // Arrange
    private readonly CalcLib _systemUnderTest = new();

    private readonly ITestOutputHelper _testOutputHelper;

    // Setup
    public CalculatorTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;

        _testOutputHelper.WriteLine("Hello from ctor setup...");
    }


    [Theory]
    [InlineData(5, 4, 9)]
    [InlineData(1, 1, 2)]
    [InlineData(-1, 1, 0)]
    public void Add_ShouldAddTwoNumbers_WhenToNumbersAreIntegers(int n1, int n2, int expected)
    {
        // Act
        var result = _systemUnderTest.Add(n1, n2);

        // Assert
        result.Should().Be(expected);
        _testOutputHelper.WriteLine($"Hello from Add_ShouldAddTwoNumbers_WhenToNumbersAreIntegers({n1}, {n2}, {expected})...");
    }

    [Theory]
    [InlineData(5, 4, 1)]
    [InlineData(1, 1, 0)]
    [InlineData(-1, 1, -2, Skip = "Unneeded test in this stage!")]
    public void Subtract_ShouldSubtractTwoNumbers_WhenToNumbersAreIntegers(int n1, int n2, int expected)
    {
        // Act
        var result = _systemUnderTest.Sub(n1, n2);

        // Assert
        result.Should().Be(expected);

        _testOutputHelper.WriteLine($"Hello from Subtract_ShouldSubtractTwoNumbers_WhenToNumbersAreIntegers({n1}, {n2}, {expected})...");
    }
    
    [Theory]
    [InlineData(5, 4, 20)]
    [InlineData(1, 1, 1)]
    [InlineData(-1, 1, -1)]
    public void Multiply_ShouldMultiplyTwoNumbers_WhenToNumbersAreIntegers(int n1, int n2, int expected)
    {
        // Act
        var result = _systemUnderTest.Mul(n1, n2);

        // Assert
        result.Should().Be(expected);

        _testOutputHelper.WriteLine($"Hello from Multiply_ShouldMultiplyTwoNumbers_WhenToNumbersAreIntegers({n1}, {n2}, {expected})...");
    }
    
    [Theory]
    [InlineData(4, 2, 2)]
    [InlineData(1, 1, 1)]
    [InlineData(-1, 1, -1)]
    public void Divide_ShouldDivideTwoNumbers_WhenToNumbersAreIntegers(int n1, int n2, int expected)
    {
        // Act
        var result = _systemUnderTest.Div(n1, n2);

        // Assert
        result.Should().Be(expected);

        _testOutputHelper.WriteLine($"Hello from Divide_ShouldDivideTwoNumbers_WhenToNumbersAreIntegers({n1}, {n2}, {expected})...");
    }

    public Task InitializeAsync()
    {
        _testOutputHelper.WriteLine("Hello from async setup ...");
        return Task.CompletedTask;
    }

    public Task DisposeAsync()
    {
        _testOutputHelper.WriteLine("Hello from teardown!...");
        return Task.CompletedTask;
    }
}