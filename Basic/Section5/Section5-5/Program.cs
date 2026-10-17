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

        Console.WriteLine("3の倍数の数");
        foreach (int value in numbers.Where(n => IsMultipleOfThree(n)))
        {
            Console.WriteLine(value);
        }

        Console.WriteLine("3の倍数でない数");
        foreach (int value in numbers.Where(n => !IsMultipleOfThree(n)))
        {
            Console.WriteLine(value);
        }
    }

    private static bool IsMultipleOfThree(int number)
    {
        return number % 3 == 0;
    }
}
