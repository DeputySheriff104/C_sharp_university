using System;

namespace MyLogicLib.Task3Logic
{
    public class Circle
    {
        public Dot Center
        {
            get;
            set;
        }

        public Round Round
        {
            get;
            set;
        }

        public Circle(Dot center, Round round)
        {
            Center = center;
            Round = round;
        }

        public bool IsDotInCircle(Dot dot)
        {
            int x = dot.X;
            int y = dot.Y;
            int x0 = Center.X;
            int y0 = Center.Y;
            return (Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2) <= Math.Pow(Round.Radius, 2));
        }
    }
}