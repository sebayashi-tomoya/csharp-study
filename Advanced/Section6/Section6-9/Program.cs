namespace Section6_9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var hashSet = new HashSet<int>();

            Console.Write("全表示：");
            for (var i = 0; i < 10; i++)
            {
                var num = Random.Shared.Next(1, 11);
                Console.Write($"{num} ");
                hashSet.Add(num);
            }
            Console.WriteLine();

            // HashSetは追加時点で重複排除されているのでそのまま表示
            Console.Write("重複排除後の数字：");
            foreach (var num in hashSet)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}
