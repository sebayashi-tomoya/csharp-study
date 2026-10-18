namespace Section8_8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1~10,000までのリストを作成
            var nums = Enumerable.Range(1, 10000).ToList();

            Console.WriteLine("1~10,000までの完全数：");
            foreach (var num in nums)
            {
                // 自分自身以外の約数をリスト化
                var divisors = new List<int>();
                for (var i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        divisors.Add(i);
                    }
                }

                // 総和が自分自身と等しい数でなければスキップする
                if (divisors.Sum() != num)
                {
                    continue;
                }

                // "自分自身 (約数1 + 約数2 + ... = 自分自身)" に成形して出力
                Console.Write($"{num} (");
                foreach (var divisor in divisors)
                {
                    var sign = divisor == divisors.Last()
                        ? "="
                        : "+";

                    Console.Write($"{divisor}{sign}");
                }
                Console.WriteLine($"{num})");
            }
        }
    }
}
