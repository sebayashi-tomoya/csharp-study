namespace Section6_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var calc = new Calc();

            var n1 = 4.1;
            var n2 = 2.3;

            var sum = calc.Add(n1, n2);
            var dif = calc.Sub(n1, n2);
            var pro = calc.Mul(n1, n2);
            var quo = calc.Div(n1, n2);

            // 実行結果例に合わせて桁数を調整して出力
            Console.WriteLine($"{n1} + {n2} = {ToG15(sum)}");
            Console.WriteLine($"{n1} - {n2} = {ToG15(dif)}");
            Console.WriteLine($"{n1} * {n2} = {ToG15(pro)}");
            Console.WriteLine($"{n1} / {n2} = {ToG15(quo)}");
        }

        private  static string ToG15(double calcResult)
        {
            return $"{calcResult:G15}";
        }
    }
}
