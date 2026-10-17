public class Program
{
    public static void Main(string[] args)
    {
        double[] numbers = [0.2, -5.1, 3.2, 1.8];

        for(int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"a[{i}]={numbers[i]}");
        }
    }
}
