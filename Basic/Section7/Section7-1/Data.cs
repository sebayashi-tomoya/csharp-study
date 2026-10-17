namespace Section7_1
{
    public class Data
    {
        private int number = 0;
        private string comment = string.Empty;

        public int Number
        {
            get => this.number;
            set { this.number = value; }
        }

        public string Comment
        {
            get => this.comment;
            set { this.comment = value; }
        }
    }
}
