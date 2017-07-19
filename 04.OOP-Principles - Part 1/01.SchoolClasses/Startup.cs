using System;
using Data;
using SchoolClasses;
using System.Collections.Generic;

class Startup
{
    static void Main()
    {
        var firstClass = new Class(
            new List<Student>
            {
            new Student("Branco","Petkov",1),
            new Student("Nikola","Kirilov",2),
            new Student("Pancho","Vladigerov",3),
            },
            new List<Teacher>
            {
            new Teacher("Georgi", "Ivanov",new Discipline(DisciplineName.Math,10,10)),
            new Teacher("Kolio", "Chirpanov",new Discipline(DisciplineName.Art,25,5)),
            new Teacher("Gancho", "Pipkov",new Discipline(DisciplineName.Geography,20,6))
            },
            "4b"
            );

        var secondClass = new Class(
            new List<Student>
            {
            new Student("Ivan","Ivanov",1),
            new Student("Petyr","Gavazov",2),
            new Student("Stanimir","Georgiev",3),
            },
            new List<Teacher>
            {
            new Teacher("Sadula", "Chetin",new Discipline(DisciplineName.Chemistry,10,15)),
            new Teacher("Krasimir", "Urmanov",new Discipline(DisciplineName.Biology,5,10)),
            new Teacher("Doncho", "Petrov",new Discipline(DisciplineName.Math,20,10))
            },
            "6a"
            );

        var school = new School();
        school.AddClass(firstClass);
        school.AddClass(secondClass);

        Console.WriteLine(school);
    }
}