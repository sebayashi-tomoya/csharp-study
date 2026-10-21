namespace Section1_2
{
    public class Calc
    {
        private readonly int num1;
        private readonly int num2;

        public Calc() : this(1, 2) { }

        public Calc(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public void ShowAdd()
        {
            Console.WriteLine($"{this.num1} + {this.num2} = {this.num1 + this.num2}");
        }
    }
}