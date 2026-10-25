namespace Section4_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Box      box = new Box(2, 4);
            Triangle tri = new Triangle(4, 1.5);
            Console.WriteLine("幅{0}、高さ{1}の四角形の面積は{2}", 2, 4, box.Area);
            Console.WriteLine("幅{0}、高さ{1}の三角形の面積は{2}", 4, 1.5, tri.Area);
        }
    }
}
