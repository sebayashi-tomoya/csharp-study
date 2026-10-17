namespace Section7_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var twoStrings = new TwoStrings();

            Console.WriteLine($"一つ目の文字列は{twoStrings.String1}");
            Console.WriteLine($"二つ目の文字列は{twoStrings.String2}");
            Console.WriteLine($"二つの文字列を合成したものは{twoStrings.GetConnectedString()}");
        }
    }
}
