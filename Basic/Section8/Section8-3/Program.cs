namespace Section8_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("好きな数字を入力してください：");
            var input = Console.ReadLine();

            if (!int.TryParse(input, out var number) || number < 0)
            {
                Console.WriteLine("無効な値が入力されました。このまま終了します。");
                return;
            }

            long result = 1;
            for (var i = 1; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine($"{number}! = {result}");
        }
    }
}
