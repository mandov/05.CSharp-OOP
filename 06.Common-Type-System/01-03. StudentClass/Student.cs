namespace StudentClass
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Student : IEnumerable, ICloneable, IComparable<Student>
    {
        public string firstName { get; set; }

        public string middleName { get; set; }

        public string lastName { get; set; }

        public int ssn { get; set; }

        public string permanentAdress { get; set; }

        public string mobilePhone { get; set; }

        public string email { get; set; }

        public int course { get; set; }

        public List<Specialty> specialties;

        public List<Faculty> faculties;

        public List<University> universities;

        public Student(string firstName, string middleName, string lastName)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
        }

        public IEnumerator GetEnumerator()
        {

            for (int i = 0; i < specialties.Count; i++)
            {
                yield return this.specialties[i];
            }

            Console.WriteLine();
            for (int i = 0; i < universities.Count; i++)
            {
                yield return this.universities[i];

            }

            Console.WriteLine();
            for (int i = 0; i < faculties.Count; i++)
            {
                yield return this.faculties[i];
            }
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (student is null)
            {
                return false;
            }

            if (student.firstName == this.firstName && student.middleName == this.middleName && student.lastName == this.lastName)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.firstName.GetHashCode() ^ this.lastName.GetHashCode();
        }

        public override string ToString()
        {
            return this.firstName + " " + this.middleName + " " + this.lastName + " " + this.course;
        }

        public object Clone()
        {
            Student copy = (Student)this.MemberwiseClone();

            var faculties = new List<Faculty>();
            for (int i = 0; i < this.faculties.Count; i++)
            {
                faculties.Add(this.faculties[i]);
            }

            var universities = new List<University>();
            for (int i = 0; i < this.universities.Count; i++)
            {
                universities.Add(this.universities[i]);
            }

            var specialties = new List<Specialty>();
            for (int i = 0; i < this.specialties.Count; i++)
            {
                specialties.Add(this.specialties[i]);
            }

            copy.faculties = faculties;
            copy.universities = universities;
            copy.specialties = specialties;

            return copy;
        }

        public int CompareTo(Student other)
        {
            if (this.firstName.CompareTo(other.firstName) == 0)
            {
                return this.ssn.CompareTo(other.ssn);
            }

            return this.firstName.CompareTo(other.firstName);
        }

        public static bool operator ==(Student student, Student anotherStudent)
        {
            if (student.Equals(anotherStudent))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Student student, Student anotherStudent)
        {
            return !student.Equals(anotherStudent);
        }
    }
}