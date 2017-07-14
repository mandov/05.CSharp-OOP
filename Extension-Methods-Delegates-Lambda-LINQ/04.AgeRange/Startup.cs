using System;
using System.Linq;
using Students;

class Startup
{
    public static void Main()
    {
        var students = new Student[] 
        {
        new Student { firsName = "Gosho", lastName = "Georgiev", age = 22 },
        new Student { firsName = "Ivan", lastName = "Sersemov", age = 15 },
        new Student { firsName = "Kylian", lastName = "Mbappe", age = 23 },
        new Student { firsName = "Omar", lastName = "Kosokko", age = 44 }
        };

        var ageGroup = students
                .Where(a => a.age >= 18 && a.age <= 24)
                .OrderBy(a => a.firsName)
                .ThenByDescending(a => a.lastName)
                .Select(a => a.firsName + " " + a.lastName);

        foreach (var student in ageGroup)
        {
            Console.WriteLine(student);
        }
    }
}