namespace Section6_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var minMax = new MinMax();

            var n1 = 4;
            var n2 = 2;
            var n3 = 7;

            var max = minMax.Max(n1, n2, n3);
            var min = minMax.Min(n1, n2, n3);

            Console.WriteLine($"{n1}と{n2}と{n3}のうち、最大のものは{max}");
            Console.WriteLine($"{n1}と{n2}と{n3}のうち、最小のものは{min}");
        }
    }
}
