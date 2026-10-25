namespace Section4_2
{
    class Triangle : PlaneFigure
    {
        public Triangle(double w, double h) : base(w, h)
        {
        }

        public override double Area
        {
            get { return width * height / 2; }
        }
    }
}

