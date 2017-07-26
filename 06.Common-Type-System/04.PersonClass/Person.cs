namespace PersonClass
{
    public class Person
    {
        private string name;

        private int? age = null;

        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            if (this.age == null)
            {
                System.Console.WriteLine("Age field don't have value !");
            }

            return this.name + " " + this.age;
        }
    }
}