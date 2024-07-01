using AlgorithmicPatterns.TwoPointer.Easy;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        // Test cases to validate the solution
        int[] input1 = { -4, -1, 0, 3, 10 };
        int[] output1 = solution.SortedSquares(input1);
        Console.WriteLine(string.Join(", ", output1)); // Output: 0, 1, 9, 16, 100

        int[] input2 = { -7, -3, 2, 3, 11 };
        int[] output2 = solution.SortedSquares(input2);
        Console.WriteLine(string.Join(", ", output2)); // Output: 4, 9, 9, 49, 121
    }
}