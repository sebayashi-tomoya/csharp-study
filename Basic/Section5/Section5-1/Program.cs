public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int[] numbers = new int[7];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 11);
        }

        foreach (int value in numbers)
        {
            Console.WriteLine(value);
        }
    }
}
