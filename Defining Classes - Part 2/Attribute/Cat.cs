namespace Animal
{
    using ProjectVersion;

    [ProjectVer(1.1)]
    public class Cat
    {
        private string Name { get; set; }

        private int Age { get; set; }

        private string Owner { get; set; }

        public Cat(string name, int age, string owner)
        {
            this.Name = name;
            this.Age = age;
            this.Owner = owner;
        }
    }
}
