namespace Section7_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var calc = new Calculation(8, 9);

            Console.WriteLine($"{calc.Number1} + {calc.Number2} = {calc.Add()}");
            Console.WriteLine($"{calc.Number1} - {calc.Number2} = {calc.Sub()}");
        }
    }
}
