namespace SISProject.Models
{
    public class Student
    {
        public string StudentNumber { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Status { get; set; }

        public Student() { }

        public Student(string name, string birthday, string address, string contact, string studentNumber)
        {
            Name = name;
            Birthday = birthday;
            Address = address;
            Contact = contact;
            StudentNumber = studentNumber;
            Status = "Applicant";
        }
    }
}
