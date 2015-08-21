namespace _01.Structure
{
    using System;

    public static class Distance
    {
        public static double CalcDistance(Point3D point1, Point3D point2)
        {
            //Problem 3
            double distance = 0;
            double xDistance = Math.Pow((point2.X - point1.X),2);
            double yDistance = Math.Pow((point2.Y - point1.Y), 2);
            double zDistance = Math.Pow((point2.Z - point1.Z), 2);
            distance = Math.Sqrt(xDistance + yDistance + zDistance);
            return distance;
        }
    }
}
