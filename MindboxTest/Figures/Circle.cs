using MindboxTest.Interfaces;

namespace MindboxTest.Figures
{
    /// <summary>
    /// Круг.
    /// </summary>
    public class Circle : ICalculateArea
    {
        /// <summary>
        /// Радиус.
        /// </summary>
        public double R { get; set; }

        public Circle() { }
        public Circle(double r) 
        { 
            R = r;
        }

        public double CalculateArea()
        {
            return Math.PI * R * R;
        }
    }
}
