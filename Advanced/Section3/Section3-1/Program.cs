namespace Section3_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var airplane = new Airplane();
            var fighter = new Fighter();

            airplane.Fly();
            fighter.Fly();
            fighter.Fight();
        }
    }
}
