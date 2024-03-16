using ConsoleApp1.services;

[TestClass]
public class CalculatorServiceTests
{
    [TestMethod]
    public void TestDivisionByZero()
    {
        List<double> results = CalculatorService.Calculate(1, 0, 10);
        Assert.IsTrue(results.Count < 10, "Error: Division by zero");
    }

    [TestMethod]
    public void TestRangeOverflow()
    {
        List<double> results = CalculatorService.Calculate(1, 1, 10);
        Assert.IsTrue(results.Count < 10, "Error: Out of range");
    }

    [TestMethod]
    public void TestPositive()
    {
        List<double> results = CalculatorService.Calculate(0.5, 1, 10);
        Assert.IsTrue(results.Last() == -2, "Error: The successful test failed");
    }
}