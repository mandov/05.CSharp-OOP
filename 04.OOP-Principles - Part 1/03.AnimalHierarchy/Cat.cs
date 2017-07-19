namespace AnimalHierarchy

{
    using System;
    using AnimalHierarchyInterface;

    public class Cat : Animal, ISound
    {    
        public Cat(string name, int age, Sex sex)
            : base(name, age, sex)
        {
            this.species = Species.Cat;
        }

        public void MakeSound()
        {
            Console.WriteLine("Myau, Myau !");
        }
    }
}
