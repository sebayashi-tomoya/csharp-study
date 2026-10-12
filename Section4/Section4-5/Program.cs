public class Program
{
    public static void Main(string[] args)
    {
        for (int i = 2; i <= 8; i++)
        {
            if (i % 2 != 0)
            {
                continue;
            }

            Console.WriteLine(i);
        }
    }
}
