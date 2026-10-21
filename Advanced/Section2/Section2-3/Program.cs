namespace Section2_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var rows = CreateRandom();
            Console.WriteLine($"縦：{rows}");

            var cols = CreateRandom();
            Console.WriteLine($"横：{cols}");

            Square(rows, cols);
        }

        private static void Square(int rows, int cols)
        {
            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    Console.Write("◼︎");
                }
                // 行ごとに改行
                Console.WriteLine();
            }
        }

        private static int CreateRandom()
        {
            return Random.Shared.Next(1, 11);
        }
    }
}
