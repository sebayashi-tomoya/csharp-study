public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("年齢入れてください：");
        string input = Console.ReadLine() ?? string.Empty;

        if (!int.TryParse(input, out int number) || number < 0)
        {
            Console.WriteLine("無効な値が入力されました。このまま終了します。");
            return;
        }

        if (number <= 12)
        {
            Console.WriteLine("子ども");
        }
        else if (number <= 17)
        {
            Console.WriteLine("中高生");
        }
        else if (number <= 64)
        {
            Console.WriteLine("成人");
        }
        else
        {
            Console.WriteLine("高齢者");
        }
    }
}
