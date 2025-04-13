namespace AreaLibrary.Models
{
    public class RTriangle : Triangle
    {
        public RTriangle(double a, double b) : base(a, b, Math.Sqrt(a * a + b * b))
        {
            if (!IsRightAngled())
                throw new ArgumentException("Not a right-angled triangle with given sides");
        }

        public override double Area()
        {
            return 0.5 * A * B; 
        }
    }
}
