public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("数字1：");
        string input1 = ReadInput();

        Console.Write("数字2：");
        string input2 = ReadInput();

        if (!int.TryParse(input1, out int number1) || !int.TryParse(input2, out int number2))
        {
            Console.WriteLine("無効な値が入力されました。このまま終了します。");
            return;
        }

        if (number1 == number2)
        {
            Console.WriteLine("等しい");
        }
        else
        {
            Console.WriteLine("等しくない");
        }
    }

    private static string ReadInput()
    {
        return Console.ReadLine() ?? string.Empty;
    }
}

