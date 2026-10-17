public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{i + 1}個めの数字を入力してください：");
            string input = Console.ReadLine() ?? string.Empty;

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("無効な値が入力されました。このまま終了します。");
                return;
            }

            numbers[i] = number;
        }

        Console.WriteLine($"正の数の個数：{numbers.Count(n => n > 0)}");
        Console.WriteLine($"負の数の個数：{numbers.Count(n => n < 0)}");
        Console.WriteLine($"ゼロの個数：{numbers.Count(n => n == 0)}");
    }
}