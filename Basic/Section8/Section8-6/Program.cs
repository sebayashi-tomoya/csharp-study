using System.Diagnostics.CodeAnalysis;

namespace Section8_6
{
    public class Program
    {
        private const string InputErrorMsg = "無効な値が入力されました。このまま終了します。";

        public static void Main(string[] args)
        {
            Console.WriteLine("1つめの分数を入力します。");
            if (!TryInputFraction(out var fraction1))
            {
                Console.WriteLine(InputErrorMsg);
                return;
            }

            Console.WriteLine("2つめの分数を入力します。");
            if (!TryInputFraction(out var fraction2))
            {
                Console.WriteLine(InputErrorMsg);
                return;
            }

            var sum = fraction1.Add(fraction2);
            Console.WriteLine($"{fraction1.GetFraction()} + {fraction2.GetFraction()} = {sum.GetFraction()}");
        }

        /// <summary>
        /// コンソールから分数を入力する
        /// </summary>
        /// <param name="fraction">入力された分数（失敗時はnull）</param>
        /// <returns>入力に成功したらtrue</returns>
        private static bool TryInputFraction([NotNullWhen(true)] out Fraction? fraction)
        {
            fraction = null;

            Console.Write("分子を入力してください：");
            if (!int.TryParse(Console.ReadLine(), out int numerator) || numerator < 0)
            {
                return false;
            }

            Console.Write("分母を入力してください：");
            if (!int.TryParse(Console.ReadLine(), out int denominator) || denominator <= 0)
            {
                return false;
            }

            fraction = new Fraction(numerator, denominator);
            return true;
        }
    }
}
