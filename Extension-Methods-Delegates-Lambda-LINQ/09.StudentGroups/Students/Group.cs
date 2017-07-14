namespace Students
{
    public class Group
    {
        public int groupNumber { get; set; }

        public string departmentName { get; set; }

        public Group(int groupNumber ,string departmentName)
        {
            this.groupNumber = groupNumber;
            this.departmentName = departmentName;
        }
    }
}
