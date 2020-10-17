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
        
        public string GetSpecialForRectangle()
        {
            return "Test method working!";
        }
    }
}