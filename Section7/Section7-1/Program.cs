namespace Section7_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var data = new Data();

            data.Number = 100;
            data.Comment = "Programming C#";

            Console.WriteLine($"number = {data.Number}");
            Console.WriteLine($"comment = {data.Comment}");
        }
    }
}
