using AreaLibrary.Models;
using FluentAssertions;
using Xunit;

namespace AreaLibrary.AreaLibraryTests
{
    public class AreaLibraryTests
    {
        [Fact]
        public void AreaCircle_Test()
        {
            var r = 5;
            var expectedArea = 78.53981633974483;

            var circle = new Circle(r);
            var area = circle.Area();

            area.Should().BeApproximately(expectedArea, 0.0001);

        }

        [Fact]
        public void AreaTriangle_Test()
        {
            var a = 15;
            var b = 10;
            var c = 15;
            var expectedArea = 70.71067811865476;

            var triangle = new Triangle(a,b,c);
            var area = triangle.Area();

            area.Should().BeApproximately(expectedArea, 0.0001);

        }
    }
}
