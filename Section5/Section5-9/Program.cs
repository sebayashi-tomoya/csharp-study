public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101);
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("50以上の数");
        foreach (int value in numbers.Where(n => n >= 50))
        {
            Console.WriteLine(value);
        }
    }
}