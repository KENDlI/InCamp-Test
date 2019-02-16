using System;
using System.Collections.Generic;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{

    class Program
    {

        static void Main(string[] args)
        { 
            
            Student student1 = new Student("Andrew Kostenko");
            Student student2 = new Student("Julia Veselkina");
            Student student3 = new Student("Maria Perechrest");

            student1.SetKnowledge(new Knowledge(7));
            student2.SetKnowledge(new Knowledge(4));
            student3.SetKnowledge(new Knowledge(10));

            University university = new University("CH.U.I");
            university.AddStudent(student1);
            university.AddStudent(student2);
            university.AddStudent(student3);

            Internship internship = new Internship("Interlink");
            internship.AddStudents(university.GetStudentsToInternship());

            Console.WriteLine("Students added to internship:");
            Console.WriteLine(internship.GetStudents());

            Console.ReadKey();
        }

    }

}