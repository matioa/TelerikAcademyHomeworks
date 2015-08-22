using System;

namespace CohesionAndCoupling
{
    public class Figure3D
    {

        private double width;
        private double height;
        private double debth;

        public Figure3D(double width, double height, double debth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = debth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                ValidateIfPositive(value, "Figure width");
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
                ValidateIfPositive(value, "Figure height");
                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.debth;
            }
            set
            {
                ValidateIfPositive(value, "Figure debth");
                this.debth = value;
            }
        }


        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = UtilsDistance.CalculateDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalcDiagonalXY()
        {
            double distance = UtilsDistance.CalculateDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = UtilsDistance.CalculateDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = UtilsDistance.CalculateDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }

        private static void ValidateIfPositive(double value, string valueName)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(valueName + " cannot be negative or 0.");
            }
        }
    }
}
