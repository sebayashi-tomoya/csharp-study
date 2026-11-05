namespace Section6_7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var nums = new List<int>();
            while (true)
            {
                var num = Random.Shared.Next(0, 21);

                // 0が出たらループを抜ける
                if (num == 0) break;

                // 昇順を保つ位置に挿入
                var index = 0;
                while (index < nums.Count && nums[index] < num)
                {
                    index++;
                }
                nums.Insert(index, num);
            }

            Console.Write("数字一覧：");
            foreach (var num in nums)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();
        }
    }
}
