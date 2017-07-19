namespace AnimalHierarchy

{
    using System;
    using AnimalHierarchyInterface;

    public class Dog : Animal,ISound
    {
        public Dog(string name,int age,Sex sex)
            :base(name,age,sex)
        {
            this.species = Species.Dog;
        }

        public void MakeSound()
        {
            Console.WriteLine("Bao , Bao !");
        }
    }
}
