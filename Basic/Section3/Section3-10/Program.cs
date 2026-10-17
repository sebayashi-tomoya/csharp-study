public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("任意のプログラミング言語を入れてください：");
        string input = (Console.ReadLine() ?? string.Empty).Trim();

        if (input.Equals("C#", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("C#言語です");
        }
        else if (input.Equals("Java", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Java言語です");
        }
        else
        {
            Console.WriteLine("その他の言語です");
        }
    }
}
