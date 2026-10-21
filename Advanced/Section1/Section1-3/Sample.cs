namespace Section1_3
{
    public class Sample
    {
        public Sample()
        {
            Console.WriteLine("スタート");
        }

        ~Sample()
        {
            Console.WriteLine("エンド");
        }

        public void Func1()
        {
            Console.WriteLine("func1");
        }
    }
}