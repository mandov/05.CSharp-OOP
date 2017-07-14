using System;
using System.Linq;
using Students;
using System.Collections.Generic;

class Startup
{
    public static void Main(string[] args)
    {
        var students = new List<Student>()
        {
            new Student{firstName = "Ricardo",lastName = "Carvahlio",fN = 1522,telNum = "0894215547",eMail = "Rico@gmail.com",marks = new List<int>{5,6,5,5,6},groupNumber = 2 },
            new Student{firstName = "Ivan",lastName = "Georgiev",fN = 1512,telNum = "0896615577",eMail = "Vanko@gmail.com",marks = new List<int>{2,2,2,5,6},groupNumber = 1 },
            new Student{firstName = "Plamen",lastName = "Iliev",fN = 1542,telNum = "0845575617",eMail = "Paco@abv.bg",marks = new List<int>{5,2,4,4,3},groupNumber = 2 },
            new Student{firstName = "David",lastName = "Bechkam",fN = 1552,telNum = "0856212136",eMail = "David@gmail.com",marks = new List<int>{6,6,3,4,6},groupNumber = 4 },
            new Student{firstName = "Ronaldinho",lastName = "Gaucho",fN = 1523,telNum = "0896565655",eMail = "Dinho@yahoo.com",marks = new List<int>{5,4,5,5,3},groupNumber = 2 },
        };

        var abv = students
           .Where(st => st.eMail.IndexOf("abv.bg") != -1)
           .Select(st => st.eMail);


        foreach (var mail in abv)
        {
            Console.WriteLine(mail);
        }
    }
}