public class Program
{
    public static void Main(string[] args)
    {
        // 3x3の作成
        int[,] numbers = new int[3, 3];

        // 1~9を代入
        int count = 1;
        for(int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                numbers[i, j] = count;
                count++;
            }
        }

        // 行ごとにコンソール出力
        for(int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write($"{numbers[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
