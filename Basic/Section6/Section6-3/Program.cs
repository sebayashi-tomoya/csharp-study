namespace Section6_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var radius = 4.0;
            var circle = new Circle(radius);

            Console.WriteLine($"半径{radius:F1}の円の円周の長さは{circle.Circumference():F2}");
            Console.WriteLine($"半径{radius:F1}の円の面積は{circle.Area():F2}");
        }
    }
}
