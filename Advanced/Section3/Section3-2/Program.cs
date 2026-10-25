namespace Section3_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var calc = new NewCalc();

            calc.Number1 = 10;
            calc.Number2 = 2;

            Console.WriteLine($"Number1：{calc.Number1}");
            Console.WriteLine($"Number2：{calc.Number2}");

            calc.Add();
            calc.Sub();
            calc.Mul();
            calc.Div();
        }
    }
}
