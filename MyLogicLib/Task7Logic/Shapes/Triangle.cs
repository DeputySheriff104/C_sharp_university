using System;

namespace MyLogicLib.Task7Logic.Shapes
{
    public class Triangle : IShape
    {
        
        private double Side1
        {
            get;
            set;
        }
        
        private double Side2
        {
            get;
            set;
        }
        
        private double Side3
        {
            get;
            set;
        }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double GetArea()
        {
            double p = Side1 + Side2 + Side3 / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        public double GetPerimeter()
        {
            return Side1 + Side2 + Side3;
        }
    }
}