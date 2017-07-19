using System;
using System.Linq;
using StudentsAndWorkers;
using System.Collections.Generic;

class DemoStudentsAndWorkers
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student("Georgi","Ignatov",6),
            new Student("Tihomir","Krastanov",3),
            new Student("Teodor","Komardjiev",6),
            new Student("Krasen","Velev",2),
            new Student("Andre","Gomez",4),
            new Student("Luis","Suarez",4),
            new Student("Sergio","Bus",3),
            new Student("Kiril","Alabashev",5),
            new Student("Daniel","Nikov",5),
            new Student("Radi","Conev",7),
            new Student("Yanka","Yankova",2)
        };

        var orderByGrade = students
            .OrderBy(s => s.Grade)
            .Select(s => s.FirstName + " " + s.LastName + " " + s.Grade);

        Console.WriteLine("Ordered students by grade:");
        foreach (var student in orderByGrade)
        {
            Console.WriteLine(student);
        }

        var workers = new List<Worker>
        {
            new Worker("Pesho","Terziev",1000,8) ,
            new Worker("Grozio","Gochev",700,12) ,
            new Worker("Radomir","Kozaliev",150,4) ,
            new Worker("Roman","Prohazkha",400,4) ,
            new Worker("Denis","Suarez",350,4) ,
            new Worker("Gencho","Vylchanov",1200,8) ,
            new Worker("Dimitar","Dimitrov",1500,8) ,
            new Worker("Stoicho","Karaobaliev",380,6) ,
            new Worker("Petyr","Kolarov",200,4) ,
            new Worker("Dinko","Valev",250,4)
        };

        var orderByMoneyPerHour = workers
            .OrderBy(w => w.MoneyPerHour())
            .Select(w => w.FirstName + " " + w.LastName + " " + string.Format("{0:F2}", w.MoneyPerHour()));

        Console.WriteLine("\nOrdered workers by money per hour:");
        foreach (var worker in orderByMoneyPerHour)
        {
            Console.WriteLine(worker);
        }

        var studentsAndWorkers = new List<Human>();
        studentsAndWorkers.AddRange(students);
        studentsAndWorkers.AddRange(workers);

        var sortByFirstAndLastName = studentsAndWorkers
            .OrderBy(saw => saw.FirstName)
            .ThenBy(saw => saw.LastName)
            .Select(saw => saw.FirstName + " " + saw.LastName);

        Console.WriteLine("\nStudents and Workers sorted by first and last names:");
        foreach (var saw in sortByFirstAndLastName)
        {
            Console.WriteLine(saw);
        }
    }
}