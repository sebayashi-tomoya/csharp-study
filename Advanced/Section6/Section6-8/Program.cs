namespace Section6_8
{
    public class Program
    {
        private static readonly Dictionary<string, string> fruits = new Dictionary<string, string>
        {
            { "apple", "りんご"},
            { "banana", "バナナ"},
            { "orange", "オレンジ"},
            { "grape", "ぶどう"},
        };

        public static void Main(string[] args)
        {
            Console.Write("英単語を入力してください：");
            var input = Console.ReadLine() ?? string.Empty;

            if (fruits.TryGetValue(input, out var japanese))
            {
                Console.WriteLine(japanese);
            }
            else
            {
                Console.WriteLine("対応なし");
            }
        }
    }
}
