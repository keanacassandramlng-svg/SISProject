using SISProject.Models;
using System.Text.Json;

namespace SISProject.Data
{
    public class StudentJsonData
    {
        private List<Student> students = new List<Student>();
        private string filePath = "students.json";

        public StudentJsonData()
        {
            Load();
        }

        // ADD student
        public void Add(Student student)
        {
            Load();
            students.Add(student);
            Save();
        }

        // GET all students
        public List<Student> GetAll()
        {
            Load();
            return students;
        }

        // GET by ID
        public Student GetById(string studentNumber)
        {
            Load();
            return students.FirstOrDefault(s => s.StudentNumber == studentNumber);
        }

        // UPDATE student
        public void Update(Student student)
        {
            Load();

            var existing = students.FirstOrDefault(s => s.StudentNumber == student.StudentNumber);

            if (existing != null)
            {
                existing.Name = student.Name;
                existing.Birthday = student.Birthday;
                existing.Address = student.Address;
                existing.Contact = student.Contact;
                existing.Status = student.Status;
            }

            Save();
        }

        // SAVE to JSON file
        private void Save()
        {
            File.WriteAllText(filePath,
                JsonSerializer.Serialize(students, new JsonSerializerOptions
                {
                    WriteIndented = true
                }));
        }

        // LOAD from JSON file
        private void Load()
        {
            if (!File.Exists(filePath))
            {
                students = new List<Student>();
                return;
            }

            var json = File.ReadAllText(filePath);

            students = JsonSerializer.Deserialize<List<Student>>(json)
                       ?? new List<Student>();
        }
    }
}
