public class Program
{
    private enum Season
    {
        Spring = 1,
        Summer = 2,
        Autumn = 3,
        Winter = 4,
    }

    public static void Main(string[] args)
    {
        Console.Write("季節を入力（1=春 2=夏 3=秋 4=冬）：");
        string input = Console.ReadLine() ?? string.Empty;

        if (!int.TryParse(input, out int value) || !Enum.IsDefined(typeof(Season), value))
        {
            Console.WriteLine("無効な値が入力されました。このまま終了します。");
            return;
        }

        Season season = (Season)value;

        switch (season)
        {
            case Season.Spring:
                Console.WriteLine("春");
                break;
            case Season.Summer:
                Console.WriteLine("夏");
                break;
            case Season.Autumn:
                Console.WriteLine("秋");
                break;
            case Season.Winter:
                Console.WriteLine("冬");
                break;
        }
    }
}
