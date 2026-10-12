public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            int number = random.Next(1, 101);
            Console.WriteLine(number);
        }
    }
}
