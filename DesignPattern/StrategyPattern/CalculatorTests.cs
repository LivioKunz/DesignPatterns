using System.Collections.Generic;
using FluentAssertions;
using StrategyPattern;
using Xunit;

public class CalculatorTests
{
    [Fact]
    public void WhenTwoTimesTwo_AverageByMeanIsTwo()
    {
        Calculator calculator = new Calculator();
        double averageByMean = calculator.CalculateAverageFor(new List<double> {2, 2}, new AverageByMean());

        averageByMean.Should().Be(2);
    }

    [Fact]
    public void WhenTwoTimesTwo_AverageByMedianIsTwo()
    {
        Calculator calculator = new Calculator();
        double averageByMedian = calculator.CalculateAverageFor(new List<double> {2, 2}, new AverageByMedian());

        averageByMedian.Should().Be(2);
    }
}