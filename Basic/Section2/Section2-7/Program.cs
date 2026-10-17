public class Program
{
    private const decimal TaxRate = 0.1M;

    public static void Main(string[] args)
    {
        Console.Write("価格を入力：");
        string input = Console.ReadLine() ?? string.Empty;

        if (decimal.TryParse(input, out decimal price))
        {
            decimal taxAmount = price * TaxRate;
            Console.WriteLine($"税込価格：{Math.Truncate(price + taxAmount)}");
        }
        else
        {
            Console.WriteLine("無効な値が入力されました。このまま終了します。");
        }
    }
}
