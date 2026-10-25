namespace Section4_1
{
    class Dog : Animal
    {
        public Dog()
        {
            name = "犬";
        }

        public override void Bark()
        {
            Console.WriteLine("ワンワン");
        }

        public override void Move()
        {
            Console.WriteLine("歩く");
        }
    }
}
