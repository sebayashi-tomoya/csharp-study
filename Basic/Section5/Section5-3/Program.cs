public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next();
        }

        Console.WriteLine($"偶数の個数：{numbers.Count(n => IsEven(n))}個");
        Console.WriteLine($"奇数の個数：{numbers.Count(n => !IsEven(n))}個");
    }

    private static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}
