namespace Section6_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var odds = new List<int>();
            var evens = new List<int>();

            while (true)
            {
                var num = Random.Shared.Next(0, 11);

                // 0ならループを抜ける
                if (num == 0) break;

                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }

            Console.Write("奇数一覧：");
            foreach (var num in odds)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();

            Console.Write("偶数一覧：");
            foreach (var num in evens)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}
