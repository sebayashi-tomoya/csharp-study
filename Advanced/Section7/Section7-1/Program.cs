namespace Section7_1
{
    public class Program
    {
        private delegate void DelFunc();

        public static void Main(string[] args)
        {
            var df = new DelFunc(Func1);
            
            // デリゲートをFunc2に入れかえて実行
            df = new DelFunc(Func2);
            df();
        }

        private static void Func1()
        {
            Console.WriteLine("Func1");
        }

        private static void Func2()
        {
            Console.WriteLine("Func2");
        }
    }
}
