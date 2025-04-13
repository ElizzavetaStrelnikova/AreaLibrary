namespace AreaLibrary.Models
{
    public class Circle : FlatFigure
    {
        private double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public override double Area()
        {
            return Math.PI * r * r;
        }
    }
}
