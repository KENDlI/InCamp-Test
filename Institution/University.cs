using InternshipTest.Person;
using System.Collections;
using System.Collections.Generic;


namespace InternshipTest.Institution
{
    public class University
    {
        public string name;
        public List<Student> students = new List<Student>();



        public University(string name)
        {
            this.name = name;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public double GetAvarageKnowledgeLevel()
        {
            double sum=0;

            foreach(Student student in students)
            {
                sum += student.GetKnowledge().GetLevel();
            }

            return sum / students.Count;

        }

        public List<Student> GetStudentsToInternship()
        {
            double avarage = GetAvarageKnowledgeLevel();
            List<Student> result = new List<Student>();
            foreach(Student student in students)
            {
                if (student.GetKnowledge().GetLevel() >= avarage)
                    result.Add(student);
            }
            return result;
        }

      

        
    }
}
