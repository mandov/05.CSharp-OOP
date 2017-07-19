namespace AnimalHierarchy
{

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, Sex.Male)
        {
            this.species = Species.Tomcat;
        }
    }
}
