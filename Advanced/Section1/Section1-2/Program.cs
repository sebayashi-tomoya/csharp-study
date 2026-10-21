namespace Section1_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var calc1 = new Calc();
            var calc2 = new Calc(3, 1);

            calc1.ShowAdd();
            calc2.ShowAdd();
        }
    }
}