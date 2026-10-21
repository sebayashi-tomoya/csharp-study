namespace Section2_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 10);
            int b = rnd.Next(1, 10);
            Console.WriteLine($"a：{a}");
            Console.WriteLine($"b：{b}");

            Console.Write("c：");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int c))
            {
                Console.WriteLine("無効な値が入力されました。このまま処理を終了します。");
                return;
            }

            Console.WriteLine("a * b * c = {0}", Calc.Mul(a, b, c));
        }
    }
}
