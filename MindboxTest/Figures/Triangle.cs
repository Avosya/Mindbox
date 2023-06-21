using MindboxTest.Interfaces;

namespace MindboxTest.Figures
{
    /// <summary>
    /// Треугольник.
    /// </summary>
    public class Triangle : ICalculateArea
    {
        /// <summary>
        /// Сторона A.
        /// </summary>
        public double A { get; set; }
        /// <summary>
        /// Сторона B.
        /// </summary>
        public double B { get; set; }
        /// <summary>
        /// Сторона C.
        /// </summary>
        public double C { get; set; }

        public Triangle() { }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Определяет является ли треугольник прямоугольным.
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            return A * A + B * B == C * C;
        }
        public double CalculateArea()
        {
            if (IsRightTriangle())
            {
                return A * B / 2;
            }
            else
            {
                var p = (A + B + C) / 2; //полупериметр
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }
    }
}
