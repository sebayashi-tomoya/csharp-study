public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("行数を入力してください：");
        string input = Console.ReadLine() ?? string.Empty;

        if (!int.TryParse(input, out int rowCount) || rowCount < 0)
        {
            Console.WriteLine("無効な値が入力されました。このまま終了します。");
            return;
        }

        for (int i = 1; i <= rowCount; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("★");
            }

            Console.WriteLine();
        }
    }
}
