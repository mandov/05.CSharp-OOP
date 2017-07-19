namespace AnimalHierarchy
{
    using System;
    using System.Linq;
    using AnimalHierarchyInterface;
    using System.Collections.Generic;
    using System.Text;

    public class Animal
    {
        private int age;

        private string name;

        private Sex sex;

        public Animal(string name, int age, Sex sex)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("You need to enter valid name!");
            }

            if (age < 0)
            {
                throw new ArgumentException("You need to enter positive age!");
            }

            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public Species species { get; set; }

        public int GetAge
        {
            get { return this.age; }
        }

        public string GetName
        {
            get { return this.name; }
        }

        public Sex GetSex
        {
            get { return this.sex; }
        }

        public static StringBuilder AverageAge(List<Animal> animals)
        {
            var result = new StringBuilder();

            double averageDogsAge = animals.Where(x => x.species == Species.Dog).Average(x => x.age);
            double averageFrogsAge = animals.Where(x => x.species == Species.Frog).Average(x => x.age);
            double averageCatsAge = animals.Where(x => x.species == Species.Cat|| x.species == Species.Kitten|| x.species == Species.Tomcat).Average(x => x.age);
         
            result.AppendFormat("Average dogs age: {0:F2} \n", averageDogsAge);
            result.AppendFormat("Average frogs age: {0:F2} \n", averageFrogsAge);
            result.AppendFormat("Average cats age: {0:F2}", averageCatsAge);

            return result;

        }
    }
}