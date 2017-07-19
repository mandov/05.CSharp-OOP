
namespace Data
{
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : People
    {
        private List<Discipline> disciplines = new List<Discipline>();

        public Teacher(string firstName, string lastName) 
            : base(firstName, lastName)
        {

        }

        public Teacher(string firstName, string lastName, Discipline discipline)
          : base(firstName, lastName)
        {
            this.disciplines.Add(discipline);
        }

        public Teacher(string firstName, string lastName, List<Discipline> disciplines) 
            : base(firstName, lastName)
        {        
            this.disciplines = disciplines;
        }

        public string Disciplines
        {
            get
            {
                StringBuilder st = new StringBuilder();
                for (int i = 0; i < this.disciplines.Count; i++)
                {
                    st.AppendFormat("{0}\n0", disciplines[i]);
                }

                return st.ToString();
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
