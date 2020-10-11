namespace MyLogicLib.Task3Logic
{
    public class Dot
    {
        private int _x;
        private int _y;

        public int X
        {
            get => _x;
            set => _x = value;
        }

        public int Y
        {
            get => _y;
            set => _y = value;
        }

        public Dot(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}