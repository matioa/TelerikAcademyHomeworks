namespace Students
{
    public class Group
    {
        public Group()
        {
            this.GroupNumber = 0;
            this.DepartmentName = string.Empty;
        }

        public Group(int groupNumber, string department)
            :this()
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = department;
        }

        public int GroupNumber { get; set; }
        public string DepartmentName { get; set; }
    }
}
