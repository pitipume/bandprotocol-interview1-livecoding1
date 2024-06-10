public class MaxSumArray
{
    public static void Main(string[] args)
    {
        int[] array = { 5, 4, 19999, 99, 77 };
        int k = 3;
        int i = 0;
        int j = 1;
        int l = 2;
        var sum1 = 0;
        var sum2 = 0;

        for (i = 0; i <= 3; i++)
        {
            if (i <= array.Length || l <= array.Length || j <= array.Length)
            {
                sum1 = array[i] + array[j] + array[l];

            }

            if (sum2 > sum1)
            {
                Console.WriteLine(sum2);

            }
            else
            {
                Console.WriteLine(sum1);
            }
            sum2 = sum1;
            i++;
            j++;
            l++;
        }
        if (sum2 > sum1)
        {
            Console.WriteLine($"Max sum: {sum2}");
        }
        else
        {
            Console.WriteLine($"Max sum: {sum1}");
        }
    }
}
