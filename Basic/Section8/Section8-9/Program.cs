namespace Section8_9
{
    public class Program
    {
        private const int OutputCount = 20;

        public static void Main(string[] args)
        {
            Console.WriteLine($"フィボナッチ数列の先頭から{OutputCount}個を出力します。");
            // 直前の2項
            var prev = 0;
            var current = 1;

            var count = 0;
            while (count < OutputCount)
            {
                Console.Write($"{current} ");

                (prev, current) = (current, prev + current);
                count++;
            }

            Console.WriteLine();
        }
    }
}
