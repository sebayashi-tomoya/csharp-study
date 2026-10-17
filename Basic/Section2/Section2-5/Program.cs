public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("str1 = ");
        string str1 = ReadInput();

        Console.Write("str2 = ");
        string str2 = ReadInput();

        // 無効値チェック
        if (string.IsNullOrWhiteSpace(str1) || string.IsNullOrWhiteSpace(str2))
        {
            Console.WriteLine("無効な値が入力されました。このまま終了します。");
            return;
        }

        Console.WriteLine($"{str1}{str2}");
    }

    private static string ReadInput()
    {
        return Console.ReadLine() ?? string.Empty;
    }
}
