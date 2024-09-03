using CalcLibProj;
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


    [Fact]
    public void Add_ShouldAddTwoNumbers_WhenToNumbersAreIntegers()
    {
        // Act
        var result = _systemUnderTest.Add(5, 4);

        // Assert
        Assert.Equal(9, result);

        _testOutputHelper.WriteLine("Hello from Add_ShouldAddTwoNumbers_WhenToNumbersAreIntegers...");
    }

    [Fact]
    public void Subtract_ShouldSubtractTwoNumbers_WhenToNumbersAreIntegers()
    {
        // Act
        var result = _systemUnderTest.Sub(5, 4);

        // Assert
        Assert.Equal(1, result);

        _testOutputHelper.WriteLine("Hello from Subtract_ShouldSubtractTwoNumbers_WhenToNumbersAreIntegers...");
    }

    public async Task InitializeAsync()
    {
        _testOutputHelper.WriteLine("Hello from async setup ...");
    }

    public async Task DisposeAsync()
    {
        _testOutputHelper.WriteLine("Hello from teardown!...");
    }
}