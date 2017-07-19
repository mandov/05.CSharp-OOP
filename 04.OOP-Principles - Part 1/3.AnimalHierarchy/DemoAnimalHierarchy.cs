using System;
using System.Linq;
using AnimalHierarchy;
using System.Collections.Generic;

class DemoAnimalHierarchy
{
    static void Main()
    {
        var animals = new List<Animal>
        {
            new Dog ("Max",5,Sex.Male),
            new Dog ("Lara",2,Sex.Female),
            new Dog ("Ico",1,Sex.Male),

            new Cat ("vanko",10,Sex.Male),
            new Tomcat("Yrnest",12),
            new Tomcat("Connor",5),

            new Kitten("Sara",6),
            new Kitten("Rita",4),
            new Kitten("Pussy",8),

            new Frog("Kyrmit",1,Sex.Male),
            new Frog("Myrmit",2,Sex.Male)
        };

        Console.WriteLine(Animal.AverageAge(animals));

    }
}