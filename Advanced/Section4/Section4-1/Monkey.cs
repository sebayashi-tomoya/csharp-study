namespace Section4_1
{
    class Monkey : Animal
    {
        public Monkey()
        {
            this.name = "猿";
        }

        public override void Bark()
        {
            Console.WriteLine("キーキー");
        }

        public override void Move()
        {
            Console.WriteLine("木に登る");
        }
    }
}