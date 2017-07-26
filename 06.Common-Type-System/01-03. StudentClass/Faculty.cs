namespace StudentClass
{
    public class Faculty
    {
        private string name;

        public Faculty(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
