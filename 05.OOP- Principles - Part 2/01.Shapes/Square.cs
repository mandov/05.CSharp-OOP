namespace Shapes
{
    public class Square : Shape
    {
        public Square(double width)
            : base(width, width)
        {
        }

        public override double CalculateSurface()
        {
            return Height * Width;
        }
    }
}