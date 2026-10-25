namespace Section4_2
{
    class Box : PlaneFigure
    {
        public Box(double w, double h) : base(w, h)
        {
        }

        public override double Area
        {
            get { return width * height; }
        }
    }
}
