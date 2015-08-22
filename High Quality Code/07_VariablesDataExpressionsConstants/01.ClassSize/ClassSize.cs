namespace _01.ClassSize
{
    using System;

    public class Figure
    {
        private double width = 0;
        private double height = 0;

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width should be greater than 0.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height should be greater than 0.");
                }
                this.height = value;
            }
        }

        public static Figure GetRotatedFigure(Figure initialFigure, double rotationAngle)
        {
            var rotatedFigureWidth = Math.Abs(Math.Cos(rotationAngle)) * initialFigure.width + Math.Abs(Math.Sin(rotationAngle)) * initialFigure.height;
            var rotatedFigureHeight = Math.Abs(Math.Sin(rotationAngle)) * initialFigure.width + Math.Abs(Math.Cos(rotationAngle)) * initialFigure.height;
            var rotatedFigure = new Figure(rotatedFigureWidth, rotatedFigureHeight);

            return rotatedFigure;
        }
    }
}
