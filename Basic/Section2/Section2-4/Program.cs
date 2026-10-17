public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine() ?? string.Empty;

        // 無効値チェック
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("無効な値が入力されました。このまま終了します。");
            return;
        }

        Console.WriteLine(input);
    }
}
