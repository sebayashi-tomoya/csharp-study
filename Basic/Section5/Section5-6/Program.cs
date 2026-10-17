public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next();
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine($"最大値：{numbers.Max()}");
        Console.WriteLine($"最小値：{numbers.Min()}");
        Console.WriteLine($"平均値：{numbers.Average()}");
    }
}