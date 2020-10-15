using System;

namespace MyLogicLib.Task7Logic.Shapes
{
    public class Circle : IShape
    {
        private double Radius
        {
            get;
            set;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}