namespace Section8_10
{
    public class Program
    {
        private enum SortOrder
        {
            Ascending = 0,
            Descending,
        }

        public static void Main(string[] args)
        {
            var nums = new int[10];

            for (var i = 0; i < nums.Length; i++)
            {
                nums[i] = Random.Shared.Next(1, 101);
            }

            Console.WriteLine("ソート順を選択してください");
            Console.WriteLine("0：昇順");
            Console.WriteLine("1：降順");
            Console.WriteLine("-----------------------");

            var input = Console.ReadLine();

            if (!Enum.TryParse(input, out SortOrder order) || !Enum.IsDefined(order))
            {
                Console.WriteLine("無効な値が入力されました。このまま終了します。");
                return;
            }

            var sorted = order == SortOrder.Ascending
                ? nums.OrderBy(n => n).ToArray()
                : nums.OrderByDescending(n => n).ToArray();

            Console.WriteLine("ソート前：");
            Enumerate(nums);

            Console.WriteLine("ソート後：");
            Enumerate(sorted);
        }

        private static void Enumerate(IEnumerable<int> nums)
        {
            foreach (var num in nums)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}
