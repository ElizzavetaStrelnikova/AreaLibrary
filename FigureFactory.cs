using AreaLibrary.Models;

namespace AreaLibrary
{
    public static class FigureFactory
    {
        public static FlatFigure CreateFigure(params double[] parameters)
        {
            return parameters.Length switch
            {
                1 => new Circle(parameters[0]),
                2 => new RTriangle(parameters[0], parameters[1]),
                3 => new Triangle(parameters[0], parameters[1], parameters[2]),
                _ => throw new ArgumentException("Invalid parameters")
            };
        }
    }
}
