public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101);
        }

        Console.WriteLine("50以上の数");
        foreach (int value in numbers.Where(n => IsFiftyOrMore(n)))
        {
            Console.WriteLine(value);
        }

        Console.WriteLine("50未満の数");
        foreach (int value in numbers.Where(n => !IsFiftyOrMore(n)))
        {
            Console.WriteLine(value);
        }
    }

    private static bool IsFiftyOrMore(int number)
    {
        return number >= 50;
    }
}
