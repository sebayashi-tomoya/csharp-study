namespace Section8_3
{
    public class Program
    {
        /// <summary>
        /// 階乗がlongで表せる上限
        /// </summary>
        private const int MaxNumber = 20;

        public static void Main(string[] args)
        {
            Console.Write($"0〜{MaxNumber}の整数を入力してください：");
            var input = Console.ReadLine();

            if (!int.TryParse(input, out var number) || number < 0 || number > MaxNumber)
            {
                Console.WriteLine($"無効な値が入力されました。0〜{MaxNumber}の整数のみ対応しています。");
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
