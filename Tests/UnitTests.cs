using MindboxTest.Figures;
using MindboxTest.Interfaces;

namespace Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TriangleTest()
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.IsTrue(triangle.IsRightTriangle());
            Assert.AreEqual(6D, CalculateArea(triangle));

            triangle = new Triangle(2, 2, 2);

            Assert.IsFalse(triangle.IsRightTriangle());
            Assert.AreEqual(Math.Sqrt(3), CalculateArea(triangle));
        }

        [TestMethod]
        public void CircleTest()
        {
            var circle = new Circle(3);

            Assert.AreEqual(28.27D, Math.Round(CalculateArea(circle), 2));
        }

        [TestMethod]
        public void RectangleTest()
        {
            var rectangle = new Rectangle(3, 4);

            Assert.AreEqual(12D, CalculateArea(rectangle));
        }

        private double CalculateArea(ICalculateArea figure)
        {
            return figure.CalculateArea();
        }
    }
}