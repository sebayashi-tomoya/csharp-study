namespace Section7_3
{
    public class Calculation
    {
        private int number1;
        private int number2;

        public int Number1
        {
            get => this.number1;
            set { this.number1 = value; }
        }

        public int Number2
        {
            get => this.number2;
            set { this.number2 = value; }
        }

        public Calculation(int n1, int n2)
        {
            this.number1 = n1;
            this.number2 = n2;
        }

        public int Add()
        {
            return this.number1 + this.number2;
        }

        public int Sub()
        {
            return this.number1 - this.number2;
        }
    }
}
