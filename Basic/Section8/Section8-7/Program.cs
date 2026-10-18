namespace Section8_7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var num = Random.Shared.Next(1, 1001);

            Console.WriteLine($"生成された数字：{num}");
            Console.Write("約数：");

            for (var i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine();
        }
    }
}
