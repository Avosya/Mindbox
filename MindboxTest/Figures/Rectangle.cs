using MindboxTest.Interfaces;

namespace MindboxTest.Figures
{
    /// <summary>
    /// Прямоугольник.
    /// </summary>
    public class Rectangle : ICalculateArea
    {
        /// <summary>
        /// Сторона А.
        /// </summary>
        public double A { get; set; }
        /// <summary>
        /// Сторона B.
        /// </summary>
        public double B { get; set; }

        public Rectangle() { }
        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public double CalculateArea()
        {
            return A * B;
        }
    }
}
