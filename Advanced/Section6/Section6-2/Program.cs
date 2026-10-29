namespace Section6_2
{
    public class Program
    {
         public static void Main(string[] args)
        {
            var nums = new List<int>();
            while (true)
            {
                nums.Add(Random.Shared.Next(0, 11));

                // 末が0ならループを抜ける
                if (nums.Last() == 0) break;
            }

            // 順番を反転させてから出力
            nums.Reverse();
            Console.Write("数字一覧：");
            foreach (var num in nums)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();
        }
    }
}
