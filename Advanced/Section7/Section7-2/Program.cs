namespace Section7_2
{
    public class Program
    {
        private delegate void MyAction(int count);

        public static void Main(string[] args)
        {
            var f = new MyAction(ShowStars);
            f += new MyAction(ShowBoxes);
            f += new MyAction(ShowPlus);

            // f(4) の1行だけで3つのメソッドがすべて実行される
            f(4);
        }

        private static void ShowStars(int count)
        {
            WriteShapes(count, "☆");
        }

        private static void ShowBoxes(int count)
        {
            WriteShapes(count, "■");
        }

        private static void ShowPlus(int count)
        {
            WriteShapes(count, "＋");
        }

        private static void WriteShapes(int count, string shape)
        {
            for (var i = 0; i < count; i++)
            {
                Console.Write(shape);
            }
            Console.WriteLine();
        }
    }
}
