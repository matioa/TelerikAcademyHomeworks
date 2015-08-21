namespace _01.Shapes
{
    class Triangle: Shape
    {
        public Triangle(double width, double height)
            : base(width, height)
        { 
        }

        public override double CalculateSurface()
        {
            double result = 0;
            result = (this.Width * this.Height) / 2;
            return result;
        }
    }
}
