namespace Section8_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1〜100 の整数のうち、3の倍数または3を含む数をすべて表示します。");

            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 || ContainsThree(i))
                {
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine();
        }

        private static bool ContainsThree(int num)
        {
            return num.ToString().Contains("3");
        }
    }
}
