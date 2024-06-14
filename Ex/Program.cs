class Program
{
    static void Main()
    {
        int[] numbers = { 3, 1, 4, 1, 5, 9, 2, 6, 5 };

        int min, max, sum, average;
        bool success = CalculateStatistics(numbers, out min, out max, out sum, out average);

        if (success)
        {
            Console.WriteLine($"Array Statistics:");
            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine($"Maximum: {max}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
        }
        else
        {
            Console.WriteLine("Error calculating statistics.");
        }
    }

    static bool CalculateStatistics(int[] array, out int min, out int max, out int sum, out int average)
    {
        min = int.MaxValue;
        max = int.MinValue;
        sum = 0;

        if (array.Length == 0)
        {
            average = 0;
            return false; // Return false if array is empty
        }

        foreach (var num in array)
        {
            if (num < min)
                min = num;
            if (num > max)
                max = num;
            sum += num;
        }

        average = sum / array.Length;
        return true; // Return true if calculation succeeds
    }
}
