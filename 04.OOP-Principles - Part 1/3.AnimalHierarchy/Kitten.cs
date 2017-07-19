namespace AnimalHierarchy
{

    public class Kitten : Cat
    {
        public Kitten(string name, int age)
            :base(name,age,Sex.Female)
        {
            this.species = Species.Kitten;
        }

    }
}
