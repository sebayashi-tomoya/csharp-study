public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(0, 101);
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("60未満");
        foreach (int value in numbers.Where(n => IsLessThanSixty(n)))
        {
            Console.WriteLine(value);
        }

        Console.WriteLine("60~80未満");
        foreach (int value in numbers.Where(n => !IsLessThanSixty(n) && !IsNoLessThanEighty(n)))
        {
            Console.WriteLine(value);
        }

        Console.WriteLine("80以上");
        foreach (int value in numbers.Where(n => IsNoLessThanEighty(n)))
        {
            Console.WriteLine(value);
        }
    }

    private static bool IsLessThanSixty(int number)
    {
        return number < 60;
    }

    private static bool IsNoLessThanEighty(int number)
    {
        return number >= 80;
    }
}