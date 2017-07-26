namespace StudentClass
{
    public class University
    {
        private string name;

        public University(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
