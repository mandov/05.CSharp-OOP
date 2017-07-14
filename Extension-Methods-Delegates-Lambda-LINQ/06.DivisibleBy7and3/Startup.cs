using System;
using System.Linq;

class Startup
{
    public static void Main()
    {
        int[] numbers = new int[] { 25, 37, 22, 21, 45, 56, 77 };
        Console.WriteLine(string.Join(" ",numbers));

        var divisable = numbers
            .Where(x => x % 7 == 0 && x % 3 == 0);

        foreach (var num in divisable)
        {
            Console.WriteLine(num);
        }
    }
}