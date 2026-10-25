namespace Section4_2
{
    abstract class PlaneFigure
    {
        protected double width;
        protected double height;

        protected PlaneFigure(double w, double h)
        {
            this.width = w;
            this.height = h;
        }

        public abstract double Area { get; }
    }
}
