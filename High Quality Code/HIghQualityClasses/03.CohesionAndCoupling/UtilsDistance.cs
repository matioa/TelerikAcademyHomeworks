using System;

namespace CohesionAndCoupling
{
    static class UtilsDistance
    {
        public static double CalculateDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            if (Double.IsPositiveInfinity(distance))
            {
                throw new OverflowException("CalculateDistance2D exceeds double max value");
            }
            return distance;
        }

        public static double CalculateDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            if (Double.IsPositiveInfinity(distance))
            {
                throw new OverflowException("CalculateDistance3D exceeds double max value");
            }
            return distance;
        }


    }
}