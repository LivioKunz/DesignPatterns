using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern
{
    public class Calculator
    {
        public double CalculateAverageFor(List<double> values, IAveraginMethod averaginMethod)
        {
            return averaginMethod.AverageFor(values);
        }
    }

    public interface IAveraginMethod
    {
        double AverageFor(List<double> values);
    }

    public class AverageByMean : IAveraginMethod
    {
        public double AverageFor(List<double> values)
        {
            return values.Sum() / values.Count;
        }
    }

    public class AverageByMedian : IAveraginMethod
    {
        public double AverageFor(List<double> values)
        {
            List<double> sortedValues = values.OrderBy(x => x).ToList();

            if (sortedValues.Count % 2 == 1) return sortedValues[(sortedValues.Count - 1) / 2];

            return (sortedValues[sortedValues.Count / 2 - 1] + sortedValues[sortedValues.Count / 2]) / 2;
        }
    }
}