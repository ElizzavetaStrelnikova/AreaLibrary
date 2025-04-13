using AreaLibrary.Models;

namespace AreaLibrary
{
    public class AreaLibrary
    {
        public static double calcArea(FlatFigure f)
        {
            return f.Area();
        }
        public static void main(String[] args)
        {
            Console.WriteLine(calcArea(new Triangle(2, 5, 2)));

            var figure = FigureFactory.CreateFigure(3, 4, 5); 
            double area = figure.Area();
        }
    }
}
