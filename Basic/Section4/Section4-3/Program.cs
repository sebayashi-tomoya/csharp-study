public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("ループ数を入力してください：");
        string input = Console.ReadLine() ?? string.Empty;

        if (!int.TryParse(input, out int loopCount) || loopCount < 0)
        {
            Console.WriteLine("無効な値が入力されました。このまま終了します。");
            return;
        }

        int i = 0;
        do
        {
            Console.Write("◼︎");
            i++;
        }
        while (i < loopCount);

        Console.WriteLine();
    }
}
