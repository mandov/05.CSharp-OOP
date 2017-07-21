using System;
using RangeExceptions;

class DemoRangeExceptions
{
    static void Main()
    {
        int number = 101;

        try
        {
            if (number > 100 || number < 0)
            {
                throw new InvalidRangeException<int>(0, 100);
            }
        }
        catch (InvalidRangeException<int> ire)
        {

            Console.WriteLine(ire.Message);
        }

        var dateTime = new DateTime(1999, 12, 25);

        try
        {
            if (dateTime.Year > 1000 || dateTime.Year < 0)
            {
                throw new InvalidRangeException<DateTime>(new DateTime(1, 1, 1), new DateTime(1000, 1, 1));
            }
        }
        catch (InvalidRangeException<DateTime> ire)
        {

            Console.WriteLine(ire.Message);
        }
    }
}