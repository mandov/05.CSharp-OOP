using System;
using System.Collections.Generic;
using IEnumerableExtensions;

class Startup
{
    static void Main()
    {
        List<long> list = new List<long>();
        list.Add(10);
        list.Add(10);
        list.Add(10);
        list.Add(10);
        list.Add(2);

        var min = list.Min();
        var max = list.Max();
        var average = list.Average();
        var sum = list.Sum();
        Console.WriteLine("Max value:{0}", max);
        Console.WriteLine("Min value:{0}", min);
        Console.WriteLine("Sum value:{0}", sum);
        Console.WriteLine("Average value:{0}", average);
    }
}