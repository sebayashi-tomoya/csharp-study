namespace Section3_2
{
    public class NewCalc : FundCalc
    {
        public void Mul()
        {
            var product = this.Number1 * this.Number2;
            this.Write("*", product);
        }

        public void Div()
        {
            var quotient = this.Number1 / this.Number2;
            this.Write("/", quotient);
        }
    }
}
