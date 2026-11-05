namespace Section6_6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var nums = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                nums.Add(Random.Shared.Next(0, 11));
            }

            Console.WriteLine("全表示：");
            WriteNums(nums);

            // 値2を削除
            nums.Remove(2);
            Console.WriteLine("2を削除後：");
            WriteNums(nums);
        }

        private static void WriteNums(IEnumerable<int> nums)
        {
            foreach (var num in nums)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}
