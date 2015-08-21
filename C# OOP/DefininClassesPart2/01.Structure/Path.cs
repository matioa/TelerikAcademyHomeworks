namespace _01.Structure
{
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> points;

        public Path()
        {
            this.points = new List<Point3D>();
        }

        public int Count
        {
            get
            {
                return this.points.Count;
            }
        }

        public Point3D this[int index]
        {
            get
            {
                return this.points[index];
            }
            set
            {
                this.points[index] = value;
            }
        }

        public void AddPoint(Point3D p)
        {
            this.points.Add(p);
        }


    }
}
