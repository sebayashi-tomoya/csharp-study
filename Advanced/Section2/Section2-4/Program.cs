namespace Section2_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Counter a = new Counter();
            Counter b = new Counter();

            a.Increment();
            Console.WriteLine("total: {0}", Counter.TotalCount);

            a.Increment();
            Console.WriteLine("total: {0}", Counter.TotalCount);

            b.Increment();
            Console.WriteLine("total: {0}", Counter.TotalCount); // インスタンスが異なる a のインクリメントも影響する
        }
    }
}
