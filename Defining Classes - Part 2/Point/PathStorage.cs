namespace Point
{
    using System;
    using System.IO;
    using System.Linq;

    public static class PathStorage
    {
        public static void SavePath(Path sequence)
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Gabriel\\Desktop\\Telerik\\05.CSharp-OOP\\Defining Classes - Part 2\\path.txt"))

            {
                foreach (var path in sequence.PointsCollection)
                {
                    sw.WriteLine("{0,3} {1,3} {2,3}", path.X, path.Y, path.Y);
                }
            }
        }

        public static Path LoadPath()
        {
            var pathToLoad = new Path();

            using (StreamReader sr = new StreamReader("C:\\Users\\Gabriel\\Desktop\\Telerik\\05.CSharp-OOP\\Defining Classes - Part 2\\path.txt"))
            {
                string line = sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {
                    int[] xyz = line.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a => int.Parse(a)).ToArray();
                    pathToLoad.AddPoint(new Point3D(xyz[0], xyz[1], xyz[2]));
                    line = sr.ReadLine();
                }
            }

            return pathToLoad;
        }
    }
}
