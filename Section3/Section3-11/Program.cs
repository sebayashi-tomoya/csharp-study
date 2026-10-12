public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("任意の数字を入れてください：");
        string input = Console.ReadLine() ?? string.Empty;

        if (!int.TryParse(input, out int number))
        {
            Console.WriteLine("無効な値が入力されました。このまま終了します。");
            return;
        }

        if (number >= 0 && number <= 100)
        {
            Console.WriteLine("有効な範囲です");
        }
        else
        {
            Console.WriteLine("範囲外です");
        }
    }
}
