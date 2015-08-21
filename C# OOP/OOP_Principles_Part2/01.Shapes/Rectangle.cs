
namespace _01.Shapes
{
    class Rectangle: Shape
    {
        
        public Rectangle(double width, double height)
            :base(width,height)
        { }

        public override double CalculateSurface()
        {
            double result = 0;
            result = this.Width * this.Height;
            return result;
        }
    }
}
