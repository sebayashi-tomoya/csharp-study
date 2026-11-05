namespace Section6_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var nums = new List<int>();

            for (var i = 0; i < 10; i++)
            {
                nums.Add(Random.Shared.Next(0, 101));
            }

            // 一の位の数字ごとにグループ化
            var dictionary = new Dictionary<int, List<int>>();
            for (var i = 0; i <= 9; i++)
            {
                var matchedList = nums
                    .Where(n => Math.Abs(n) % 10 == i)
                    .ToList();

                dictionary[i] = matchedList;
            }

            foreach (var pairs in dictionary)
            {
                Console.WriteLine($"一の位が{pairs.Key}の数");

                foreach (var num in pairs.Value)
                {
                    Console.Write($"{num} ");
                }

                Console.WriteLine();
            }
        }
    }
}
