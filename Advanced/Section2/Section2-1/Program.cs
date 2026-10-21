namespace Section2_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 5, b = 2;
            Console.WriteLine("{0} + {1} = {2}", a, b, Calc.Add(a, b));
            Console.WriteLine("{0} - {1} = {2}", a, b, Calc.Sub(a, b));
        }
    }
}
