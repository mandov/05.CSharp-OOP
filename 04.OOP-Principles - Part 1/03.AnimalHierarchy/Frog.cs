namespace AnimalHierarchy
{
    using System;
    using AnimalHierarchyInterface;

    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, Sex sex)
            : base(name, age, sex)
        {
            this.species = Species.Frog;
        }

        public void MakeSound()
        {
            Console.WriteLine("croak, croak !");
        }
    }
}
