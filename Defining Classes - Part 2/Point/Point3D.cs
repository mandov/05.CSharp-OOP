namespace Point
{
    public struct Point3D
    {
        private static readonly double o = 0;
        private double x;
        private double y;
        private double z;

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public static double O
        {
            get { return o; }
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", x, y, z);
        }
    }
}