public class Program
{
    private enum Weekday
    {
        Sunday = 1,
        Monday = 2,
        Tuesday = 3,
        Wednesday = 4,
        Thursday = 5,
        Friday = 6,
        Saturday = 7,
    }

    public static void Main(string[] args)
    {
        Console.Write("曜日を入力（1=日 2=月 3=火 4=水 5=木 6=金 7=土）：");
        string input = Console.ReadLine() ?? string.Empty;

        if (!int.TryParse(input, out int value) || !Enum.IsDefined(typeof(Weekday), value))
        {
            Console.WriteLine("無効な値が入力されました。このまま終了します。");
            return;
        }

        Weekday day = (Weekday)value;

        switch (day)
        {
            case Weekday.Sunday:
                Console.WriteLine("日曜日");
                break;
            case Weekday.Monday:
                Console.WriteLine("月曜日");
                break;
            case Weekday.Tuesday:
                Console.WriteLine("火曜日");
                break;
            case Weekday.Wednesday:
                Console.WriteLine("水曜日");
                break;
            case Weekday.Thursday:
                Console.WriteLine("木曜日");
                break;
            case Weekday.Friday:
                Console.WriteLine("金曜日");
                break;
            case Weekday.Saturday:
                Console.WriteLine("土曜日");
                break;
        }
    }
}
