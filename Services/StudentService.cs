using SISProject.Data;
using SISProject.Models;
using SISProject.Utilities;

namespace SISProject.Services
{
    public class StudentService
    {
        private StudentJsonData data = new StudentJsonData();

        // 1. Apply
        public Student Apply(string name, string birthday, string address, string contact)
        {
            string id = IdGenerator.GenerateStudentNumber();

            Student student = new Student(name, birthday, address, contact, id);
            data.Add(student);

            return student;
        }

        // 2. Enroll
        public bool Enroll(string studentNumber)
        {
            var student = data.GetById(studentNumber);
            if (student == null) return false;

            student.Status = "Enrolled";
            data.Update(student);
            return true;
        }

        // 3. Deactivate
        public bool Deactivate(string studentNumber)
        {
            var student = data.GetById(studentNumber);
            if (student == null) return false;

            student.Status = "Deactivated";
            data.Update(student);
            return true;
        }

        // 4. Graduate
        public bool Graduate(string studentNumber)
        {
            var student = data.GetById(studentNumber);
            if (student == null) return false;

            student.Status = "Graduated";
            data.Update(student);
            return true;
        }

        // 5. Leave of Absence
        public bool LeaveOfAbsence(string studentNumber)
        {
            var student = data.GetById(studentNumber);
            if (student == null) return false;

            student.Status = "On Leave";
            data.Update(student);
            return true;
        }

        // 6. Get Student Info
        public Student GetStudent(string studentNumber)
        {
            return data.GetById(studentNumber);
        }
    }
}
