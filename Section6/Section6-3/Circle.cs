namespace Section6_3
{
    class Circle
    {
        private const double Pi = 3.14;

        private readonly double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public double Circumference()
        {
            return 2 * radius * Pi;
        }

        public double Area()
        {
            return radius * radius * Pi;
        }
    }
}
