namespace Students

{
    using System.Collections.Generic;

    public class Student
    {
        public string firstName { get; set; }

        public string lastName { get; set; }

        public int fN { get; set; }

        public string telNum { get; set; }

        public string eMail { get; set; }

        public List<int> marks { get; set; }

        public int groupNumber { get; set; }

        public Group group; 
}
}
