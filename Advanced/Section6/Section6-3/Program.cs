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

            // 位置の位の数字ごとにグループ化
            var lookup = nums.ToLookup(n => Math.Abs(n) % 10);
            
            foreach (var group in lookup.OrderBy(l => l.Key))
            {
                Console.WriteLine($"一の位が{group.Key}の数");
                
                foreach (var value in group)
                {
                    Console.Write($"{value} ");
                }

                Console.WriteLine();
            }
        }
    }
}
