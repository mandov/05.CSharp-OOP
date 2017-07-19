namespace Data
{
    using System;

    public class Discipline : Interfaces.IComentable
    {
        private int numberOfLectures;

        private int numberOfExcercises;

        private DisciplineName disciplineName;

        public Discipline(DisciplineName disciplineName,int numberOfLectures, int numberOfExcercises )
        {                    
            if (numberOfLectures <= 0 || numberOfExcercises <= 0)
            {
                throw new ArgumentException("You must enter positive number");
            }

            this.disciplineName = disciplineName;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExcercises = numberOfExcercises;
        }      

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
        }

        public int NumberOfExcercises
        {
            get { return this.numberOfExcercises; }
        }

        public string Comment { get; set; }
    }
}