namespace _01.Structure
{
    public struct Point3D
    {
        //problem 2
        private static readonly Point3D startPoint;
        
        //problem 1
        public Point3D(double xPosition, double yPosition, double zPosition)
            :this()
        {
            this.X = xPosition;
            this.Y = yPosition;
            this.Z = zPosition;
        }

        //problem 2
        static Point3D()
        {
            startPoint = new Point3D(0, 0, 0);
        }

        //problem 1
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public static Point3D StartPoint
        {
            get
            {
                return startPoint;
            }
        }


        //problem 1
        public override string ToString()
        {
            return string.Format("X:{0}, Y: {1}, Z:{2}",this.X, this.Y,this.Z);
        }
    }
}
