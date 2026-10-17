public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            int a, b;
            Console.Write("a=");
            a = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("b=");
            b = int.Parse(Console.ReadLine() ?? string.Empty);

            if (a > b)
            {
                Console.WriteLine("aはbより大きいです");
            }
            else if (a < b)
            {
                Console.WriteLine("bはaより大きいです");
            }
            else
            {
                Console.WriteLine("aとbは同値です");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("無効な値が入力されました。このまま終了します。");
        }
    }
}
