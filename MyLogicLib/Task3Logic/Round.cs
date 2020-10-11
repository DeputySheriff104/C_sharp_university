namespace MyLogicLib.Task3Logic
{
    public class Round
    {
        private int _radius;

        public int Radius
        {
            get => _radius;
            set => _radius = value;
        }

        public Round(int radius)
        {
            _radius = radius;
        }

    }
}