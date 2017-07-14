using System;
using System.Linq;
using Students;
using System.Collections.Generic;

class Startup
{
    static void Main()
    {
        var students = new List<Student>()
        {
            new Student{firstName = "Ricardo",lastName = "Carvahlio",fN = 1505,telNum = "0894215547",eMail = "Rico@gmail.com",marks = new List<int>{5,6,5,5,6},groupNumber = 2 ,group = new Group(5,"Biology")},
            new Student{firstName = "Ivan",lastName = "Georgiev",fN = 1506,telNum = "0896615577",eMail = "Vanko@gmail.com",marks = new List<int>{2,2,2,5,6},groupNumber = 1,group = new Group(5,"Mathematics") },
            new Student{firstName = "Plamen",lastName = "Iliev",fN = 1505,eMail = "Paco@abv.bg",marks = new List<int>{5,2,4,4,3},groupNumber = 2 ,group = new Group(5,"Mathematics")},
            new Student{firstName = "David",lastName = "Bechkam",fN = 1507,telNum = "0856212136",eMail = "David@gmail.com",marks = new List<int>{6,6,3,4,6},groupNumber = 4,group = new Group(5,"Geography") },
            new Student{firstName = "Ronaldinho",lastName = "Gaucho",fN = 1506,eMail = "Dinho@yahoo.com",marks = new List<int>{5,4,5,5,3},groupNumber = 2 ,group = new Group(5,"Iconomics")},
        };

        var secondGroup = students
            .Where(st => st.groupNumber == 2)
            .OrderBy(st => st.firstName)
            .Select(st => st.firstName + " " + st.lastName);

        Console.WriteLine("Students from 2 group:");
        foreach (var student in secondGroup)
        {
            Console.WriteLine(student);
        }

        var abv = students
          .Where(st => st.eMail.IndexOf("abv.bg") != -1)
          .Select(st => st.eMail);

        Console.WriteLine("\nStudents with abv mail:");
        foreach (var mail in abv)
        {
            Console.WriteLine(mail);
        }

        var telPhone = students
            .Where(st => st.telNum != null)
            .Select(st => st.firstName + " " + st.lastName + " " + st.telNum);

        Console.WriteLine("\nStudents with phone numbers:");
        foreach (var student in telPhone)
        {
            Console.WriteLine(student);
        }

        var excellentMarks = students
            .Where(st => st.marks.Find(x => x == 6) == 6)
            .Select(st => st.firstName + " " + st.lastName + " " + string.Join(" ", st.marks));


        var list = new List<object>();
        Console.WriteLine("\nStudents with excellent marks:");
        foreach (var student in excellentMarks)
        {
            Console.WriteLine(student);
            list.Add(student);
        }

        var poorMarks = students
                .Where(st => st.marks.Find(x => x == 2) == 2)
                .Select(st => st.firstName + " " + st.lastName + " " + string.Join(" ", st.marks));

        Console.WriteLine("\nStudents with poor marks:");
        foreach (var student in poorMarks)
        {
            Console.WriteLine(student);
        }

        var StudentsFromZeroSix = students
            .Where(st => st.fN.ToString().Substring(st.fN.ToString().Length - 2) == "06")
            .Select(st => st.firstName + " " + st.fN + " " + string.Join(" ", st.marks));

        Console.WriteLine("\nStudents that's enrolled in 2006:");
        foreach (var student in StudentsFromZeroSix)
        {
            Console.WriteLine(student);
        }

        var departments = students
            .Where(st => st.group.departmentName == "Mathematics")
            .Select(st => st.firstName + " " + st.lastName + " " + st.group.departmentName);

        Console.WriteLine("\nStudents who are in Mathematics department:");
        foreach (var student in departments)
        {
            Console.WriteLine(student);
        }

        var grouped = students
            .GroupBy(st => st.groupNumber);


        Console.WriteLine("\nGroups:");
        foreach (var groups in grouped)
        {
            Console.WriteLine("{0}:",groups.Key);
            foreach (var student in groups)
            {
                Console.WriteLine(student.firstName);
            }
        }
    }
}