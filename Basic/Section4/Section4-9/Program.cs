public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        List<int> numbers = [];

        for (int i = 0; i < 5; i++)
        {
            int number = random.Next();
            Console.WriteLine(number);
            numbers.Add(number);
        }

        Console.WriteLine($"最大値：{numbers.Max()}");
        Console.WriteLine($"最小値：{numbers.Min()}");
    }
}
