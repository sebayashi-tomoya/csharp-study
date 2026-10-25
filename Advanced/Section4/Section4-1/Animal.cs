namespace Section4_1
{
    abstract class Animal
    {
        protected string name;

        public void ShowName()
        {
            Console.WriteLine("名前:" + name);
        }

        public abstract void Bark();
        public abstract void Move();
    }
}
