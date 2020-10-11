using System;

namespace MyLogicLib.Task3Logic
{
    public class Circle
    {
        private Dot _center;
        private Round _round;

        public Dot Center
        {
            get => _center;
            set => _center = value;
        }

        public Round Round
        {
            get => _round;
            set => _round = value;
        }

        public Circle(Dot center, Round round)
        {
            _center = center;
            _round = round;
        }

        public bool IsDotInCircle(Dot dot)
        {
            int x = dot.X;
            int y = dot.Y;
            int x0 = _center.X;
            int y0 = _center.Y;
            return (Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2) <= Math.Pow(_round.Radius, 2));
        }
    }
}