public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();

        // 3x3の作成
        int[,] numbers = new int[3, 3];

        // 乱数を代入
        for(int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                numbers[i, j] = random.Next();
                Console.WriteLine(numbers[i, j]);
            }
        }

        // 最大値・最小値をコンソール出力
        int[] flat = numbers.Cast<int>().ToArray();
        Console.WriteLine($"最大値：{flat.Max()}");
        Console.WriteLine($"最小値：{flat.Min()}");
    }
}
