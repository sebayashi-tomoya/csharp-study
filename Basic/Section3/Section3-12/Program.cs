public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("b=");
            int b = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("c=");
            int c = int.Parse(Console.ReadLine() ?? string.Empty);

            int[] ints = [a, b, c];
            Console.WriteLine($"最大値は {ints.Max()} です");
        }
        catch (FormatException)
        {
            Console.WriteLine("無効な値が入力されました。このまま終了します。");
        }
    }
}
