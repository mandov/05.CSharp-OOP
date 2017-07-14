using System;
using Students;
using System.Linq;

class Startup
{
    static void Main()
    {
        var students = new Student[]
        {
         new Student { firsName = "Georgi", lastName = "Ivanov" },
         new Student { firsName = "Babatunde", lastName = "Adenji",age = 21 },
         new Student { firsName = "Francis", lastName = "Nahr",age = 22 }
        };

        var firstBeforeLast = students
            .Where(st => st.firsName.CompareTo(st.lastName) < 0)
            .OrderBy(st => st.firsName)
            .Select(st => st.firsName + " " + st.lastName);

        foreach (var student in firstBeforeLast)
        {
            Console.WriteLine(student);
        }
    }
}