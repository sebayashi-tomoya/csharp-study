namespace Section6_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var nums = new List<int>();
            while (true)
            {
                var num = Random.Shared.Next(0, 11);

                // 0ならループを抜ける
                if (num == 0) break;

                nums.Add(num);
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
