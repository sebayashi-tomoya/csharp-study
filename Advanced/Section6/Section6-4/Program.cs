namespace Section6_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var words = new List<string>();
            while (true)
            {
                Console.Write("好きな文字を入力してください（Enterを押すと終了）：");
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                words.Add(input);
            }

            Console.Write("入力された文字列：");
            foreach (var word in words)
            {
                Console.Write($"{word} ");
            }

            Console.WriteLine();
        }
    }
}
