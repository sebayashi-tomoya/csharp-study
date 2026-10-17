public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int[] numbers = new int[7];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 6);
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("★へ変換");
        foreach (int value in numbers)
        {
            for (int i = 0; i < value; i++)
            {
                Console.Write("★");
            }
            Console.WriteLine();
        }
    }
}