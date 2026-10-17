public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next();
            Console.WriteLine(numbers[i]);
        }

        double average = numbers.Average();

        Console.WriteLine("平均以上の数");
        foreach (int value in numbers.Where(n => n >= average))
        {
            Console.WriteLine(value);
        }

        Console.WriteLine("平均未満の数");
        foreach (int value in numbers.Where(n => n < average))
        {
            Console.WriteLine(value);
        }
    }
}