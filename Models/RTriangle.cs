namespace AreaLibrary.Models
{
    public class RTriangle : Triangle
    {
        public RTriangle(double a, double b) : base(a, b, Math.Sqrt(a * a + b * b))
        {
        }

        public override double Area()
        {
            return 0.5 * A * B; 
        }
    }
}
