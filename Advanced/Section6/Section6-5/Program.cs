namespace Section6_5
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

            // 5文字未満を削除
            words.RemoveAll(w => w.Length < 5);

            Console.Write("入力された文字列：");
            foreach (var word in words)
            {
                Console.Write($"{word} ");
            }

            Console.WriteLine();
        }
    }
}
