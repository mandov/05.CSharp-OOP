using System;
using Point;

class Program
{
    static void Main()
    {
        Point3D point = new Point3D(7, 4, 3);
        Point3D secondpoint = new Point3D(17, 6, 2);
        Path path = new Path();
        path.AddPoint(point);
        path.AddPoint(secondpoint);
        PathStorage.SavePath(path);
        Console.WriteLine(PathStorage.LoadPath());
    }
}