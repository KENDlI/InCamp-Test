using InternshipTest.Person;
using System.Collections;
using System.Collections.Generic;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        public string name;
        public List<Student> students = new List<Student>();

        public Internship(string name)
        {
            this.name = name;

        }

        public string GetStudents()
        {
            string result="";

            foreach(Student student in students)
            {
                result += student.name + " " + student.knowledge.level + '\n';
            }
            return result;
        }

        public void AddStudents(List<Student> students)
        {
            foreach(Student student in students)
            {
                this.students.Add(student);
            }
           
        }
       
    }
}
