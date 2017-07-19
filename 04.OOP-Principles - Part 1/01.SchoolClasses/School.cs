namespace SchoolClasses
{
    using Data;
    using System.Collections.Generic;
    using System.Text;

    public class School
    {
        private List<Class> classes = new List<Class>();

        public School()
        {

        }

        public School(List<Class> classes)
        {
            this.classes = classes;
        }


        public string Classes
        {
            get
            {
                StringBuilder st = new StringBuilder();
                for (int i = 0; i < this.classes.Count; i++)
                {
                    st.AppendFormat("{0}", classes[i]);
                }

                return st.ToString();
            }
        }

        public void AddClass(Class clas)
        {
            this.classes.Add(clas);
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            for (int i = 0; i < this.classes.Count; i++)
            {
                st.AppendLine(classes[i].ToString());
            }

            return st.ToString();
        }
    }
}
