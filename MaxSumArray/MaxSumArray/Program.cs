public class MaxSumArray
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int k = 3; // sum of K number consecutive
        var n = array.Length - k; // number of n loop
        var sum1 = 0;
        var sum2 = 0;

        for (int i = 0; i <= n; i++)
        {
            Console.Write($"Round {i + 1}: ");
            Console.Write("{0}+{1}+{2} = ", array[i], array[i + 1], array[i + 2]);
            if (i <= array.Length)
            {
                sum1 = array[i] + array[i + 1] + array[i + 2];
                Console.WriteLine(sum1);
            }

            if (sum1 > sum2)
            {
                sum2 = sum1;
            }
        }
        Console.WriteLine($"MaxSum: {sum2}");
    }
}
