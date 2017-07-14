using System;
using System.Linq;

class Startup
{
    static void Main()
    {
        string[] arr = new string[] { "Gosho", "Peshov", "MacaMacurana" };

        var longestString = arr
            .OrderBy(w => w.Length)
            .ElementAt(arr.Length - 1);

        Console.WriteLine(String.Join(" ",arr));
        Console.WriteLine("The longest string:");
        Console.WriteLine(longestString);
    }
}

