public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();

        while (true)
        {
            int number = random.Next();

            Console.WriteLine(number);

            if (number % 10 == 0)
            {
                Console.WriteLine("10の倍数のため終了します");
                break;
            }
        }
    }
}
