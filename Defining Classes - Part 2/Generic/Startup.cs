using System;
using Generic;

class Program
{
    static void Main()
    {
        GenericList<int> list = new GenericList<int>(2);
        list.AddElement(1);
        list.AddElement(2);
        list.AddElement(3);
        list.AddElement(4);
        list.AddElement(5);
        list.AddElement(6);
        list.AddElement(7);

        list.RemovingElement(5);
        Console.WriteLine(list);
        list.InsertElement(66, 5);
        Console.WriteLine(list);
        Console.WriteLine(list.MaxValue());
        Console.WriteLine(list.MinValue());
    }
}