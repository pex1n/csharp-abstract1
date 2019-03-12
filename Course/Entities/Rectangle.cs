using Course.Entities.Enums;

namespace Course.Entities
{
    class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double height, double width, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double area()
        {
            return Width * Height;
        }
    }
}
