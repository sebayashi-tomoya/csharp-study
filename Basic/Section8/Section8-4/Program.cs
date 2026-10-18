namespace Section8_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var number = Random.Shared.Next(1, 1001);

            Console.WriteLine($"生成された数字：{number}");
            Console.WriteLine($"桁数：{Math.Abs(number).ToString().Length}");
        }
    }
}
