using System;
using System.Collections.Generic;
using StudentClass;

public class Startup
{
    public static void Main()
    {
        var faculties = new List<Faculty>
        {
            new Faculty("Iconmics"),
            new Faculty("Geography"),
            new Faculty("HumanResource"),
            new Faculty("Math"),
        };

        var universities = new List<University>
        {
            new University("Sofian University"),
            new University("UNSS"),
            new University("HTMU"),
            new University("UASG"),
        };

        var spespecialties = new List<Specialty>
        {
            new Specialty("Technology"),
            new Specialty("Engineering"),
            new Specialty("Art"),
        };

        var student = new Student("ivan", "Draganov", "Icanov")
        {
            course = 10,
            ssn = 55,
            faculties = faculties,
            universities = universities,
            specialties = spespecialties
        };

        foreach (var item in student)
        {
            Console.WriteLine(item);
        }

        var anotherStudent = new Student("zeoergi", "Petkov", "Karaqnev");
        var yetAnotherStudent = new Student("Geoergi", "Petkov", "Karaqnev");       
        Console.WriteLine("\nIs anotherStudent is equals to yetAnotherStudent: {0}",anotherStudent.Equals(yetAnotherStudent));
        Console.WriteLine("Is anotherStudent is different than yetAnotherStudent: {0}",anotherStudent != yetAnotherStudent);


        Console.WriteLine("\nStudent HashCode: {0}",student.GetHashCode());
        Console.WriteLine("yetAnotherStudent HashCode: {0}",yetAnotherStudent.GetHashCode());
                                                                    
        Student clone = (Student) student.Clone();
        Console.WriteLine("\nDeep clone of variable student:");
        Console.WriteLine("Student:{0} {1}",student, string.Join(", ",student.specialties));
        Console.WriteLine("Student Clone: {0} {1}",clone, string.Join(", ", clone.specialties));

        Student[] arr = new Student[3];
        arr[0] = student;
        arr[1] = anotherStudent;
        arr[2] = yetAnotherStudent;
        Console.WriteLine("\nSorted Student classes:");
        Array.Sort(arr);
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}