public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("任意の文字を入れてください：");
        string input = (Console.ReadLine() ?? string.Empty).Trim();

        if (input.Equals("yes", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("はい");
        }
        else
        {
            Console.WriteLine("いいえ");
        }
    }
}
