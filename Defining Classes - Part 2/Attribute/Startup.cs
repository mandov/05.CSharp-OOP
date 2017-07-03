using System;
using Animal;
using ProjectVersion;

class Startup
{
    static void Main()
    {
        var attributes = typeof(Cat).GetCustomAttributes(false);
        foreach (var atr in attributes)
        {
            var cast = (ProjectVer)atr;
            Console.WriteLine(cast.Version);
        }
    }
}
