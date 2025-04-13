namespace AreaLibrary.Models
{
    public class Triangle : FlatFigure
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            if (!IsValidTriangle())
                Console.WriteLine("bad Triangle");
            else
                Console.WriteLine("ok Triangle");
        }

        private bool IsValidTriangle()
        {
            return C < A + B && B < A + C && A < B + C;
        }

        public override double Area()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRightAngled(double tolerance = 0.0001)
        {
            var sides = new[] { A, B, C }.OrderBy(x => x).ToArray();
            double a = sides[0];
            double b = sides[1];
            double c = sides[2];

            return Math.Abs(a * a + b * b - c * c) < tolerance;
        }
    }
}
