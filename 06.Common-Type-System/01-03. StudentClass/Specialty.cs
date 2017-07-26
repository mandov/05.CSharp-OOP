
namespace StudentClass
{
   public class Specialty
    {
        private string name;

        public Specialty(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
