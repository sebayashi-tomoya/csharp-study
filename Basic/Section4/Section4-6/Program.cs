public class Program
{
    public static void Main(string[] args)
    {
        List<int> inputs = [];

        while (true)
        {
            Console.Write("数字を入力してください：");
            string input = Console.ReadLine() ?? string.Empty;

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("無効な値が入力されました。このまま終了します。");
                break;
            }

            if (number < 0)
            {
                Console.WriteLine("負の数が入力されました。このまま終了します。");
                break;
            }

            inputs.Add(number);
            inputs.ForEach(Console.WriteLine);
        }
    }
}
