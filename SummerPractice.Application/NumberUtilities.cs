namespace SummerPractice.Application;

public class NumberUtilities
{
    public static double CalculateAverage(string numbers)
    {
        if (string.IsNullOrWhiteSpace(numbers))
        {
            throw new ArgumentException("Input string is empty or null", nameof(numbers));
        }

        var numberArray = numbers.Split(',')
            .Select(n => n.Trim())
            .Where(n => int.TryParse(n, out _))
            .Select(int.Parse)
            .ToArray();

        if (numberArray.Length == 0)
        {
            throw new ArgumentException("No valid integers found in input string", nameof(numbers));
        }

        return numberArray.Average();
    }
}