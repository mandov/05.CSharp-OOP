namespace Point
{
    using System.Collections.Generic;
    using System.Text;

    public class Path
    {
        private List<Point3D> pointsCollection;

        public Path()
        {
            this.pointsCollection = new List<Point3D>();
        }

        public List<Point3D> PointsCollection
        {
            get { return pointsCollection; }
           
        }

        public void AddPoint(Point3D point)
        {
            this.pointsCollection.Add(point);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (var points in this.pointsCollection)
            {
                result.AppendFormat("X = {0, 3} Y = {1, 3} Z = {2, 3}\n", points.X, points.Y, points.Z);
            }

            return result.ToString().TrimEnd('\n');
        }
    }
}
