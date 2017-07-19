namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Class : Interfaces.IComentable
    {
        private List<Student> students = new List<Student>();
                                           
        private List<Teacher> teachers = new List<Teacher>();

        private string textIdentifier;

        public Class()
        {
         
        }

        public Class(List<Student> students, List<Teacher> teachers, string textIdentifier)
        {
            this.students = students;
            this.teachers = teachers;
            this.textIdentifier = textIdentifier;
        }

        public string TextIdentifier
        {
            get { return this.textIdentifier; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Comment dont must be empty");
                }

                this.textIdentifier = value;
            }
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public string GetStudents()
        {
            StringBuilder st = new StringBuilder();
            for (int i = 0; i < this.students.Count; i++)
            {
                st.AppendFormat("{0}\n", this.students[i]);
            }

            return st.ToString();
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public string Comment { get; set; }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine(textIdentifier);
            st.AppendLine("Teachers:");
            foreach (var teacher in teachers)
            {
                st.AppendLine(teacher.ToString());
            }

            st.AppendLine("Students:");

            foreach (var student in this.students)
            {
                st.AppendLine(student.ToString());
            }

            return st.ToString();
        }
    }
}