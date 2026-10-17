public class Program
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.Write($"{i} ");

            if (i % 10 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}
