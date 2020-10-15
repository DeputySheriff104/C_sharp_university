namespace MyLogicLib.Task7Logic.Shapes
{
    public class Rectangle : IShape
    { 
        private double Height
        {
            get;
            set;
        }
        
        private double Width
        {
            get;
            set;
        }
        
        public Rectangle()
        {}

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public double GetArea()
        {
            return Height * Width;
        }

        public double GetPerimeter()
        {
            return 2 * (Height + Width);
        }
        
        public double GetSpecialForRectangle()
        {
            return Height + Width;
        }
    }
}