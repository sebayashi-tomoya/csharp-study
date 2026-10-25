namespace Section3_2
{
    public class FundCalc
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public void Add()
        {
            var sum = this.Number1 + this.Number2;
            this.Write("+", sum);
        }

        public void Sub()
        {
            var diff = this.Number1 - this.Number2;
            this.Write("-", diff);
        }

        protected void Write(string sign, int result)
        {
            Console.WriteLine($"{this.Number1} {sign} {this.Number2} = {result}");
        }
    }
}
