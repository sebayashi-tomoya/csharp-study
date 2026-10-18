namespace Section8_6
{
    public class Fraction
    {
        /// <summary>
        /// 分母
        /// </summary>
        public int Denominator { get; }

        /// <summary>
        /// 分子
        /// </summary>
        public int Numerator { get; }

        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        /// <summary>
        /// 分数の和を求める
        /// </summary>
        /// <param name="other">足す分数</param>
        /// <returns>約分済みの和</returns>
        public Fraction Add(Fraction other)
        {
            // a/b + c/d = (a*d + c*b) / (b*d)
            var numerator = this.Numerator * other.Denominator + other.Numerator * this.Denominator;
            var denominator = this.Denominator * other.Denominator;

            return new Fraction(numerator, denominator).Reduce();
        }

        /// <summary>
        /// 約分する
        /// </summary>
        public Fraction Reduce()
        {
            var gcd = Gcd(this.Numerator, this.Denominator);
            return new Fraction(this.Numerator / gcd, this.Denominator / gcd);
        }

        public string GetFraction()
        {
            return this.Denominator == 1
                ? $"{this.Numerator}"
                : $"{this.Numerator}/{this.Denominator}";
        }

        /// <summary>
        /// 最大公約数を求める
        /// </summary>
        private static int Gcd(int a, int b)
        {
            while (b != 0)
            {
                (a, b) = (b, a % b);
            }
            return a;
        }
    }
}
