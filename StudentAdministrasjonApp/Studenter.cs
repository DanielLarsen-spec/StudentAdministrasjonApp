using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjonApp
{
    internal class Studenter
    {
       public string Navn { get; set; }
       public int Alder { get; set; }
       public string Studieprogram { get; set; }
       public int StudentId { get; set; }
    
        public Studenter(string name, int alder, string studieprogram, int studentid) 
        {
            Navn = name;
            Alder = alder;
            Studieprogram = studieprogram;
            StudentId = studentid;
        }

        public void AddStudents()
        {
            List<Studenter> students = new List<Studenter>();
            Studenter student1 = new Studenter("Daniel", 27, "Programmering", 1);
            Studenter student2 = new Studenter("Lars Ronny", 29, "Informatikk", 2);
            Studenter student3 = new Studenter("Daniel Winther", 30, "Jus", 3);
            Studenter student4 = new Studenter("Magnus", 28, "Genetikk", 4);

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            Console.WriteLine("Student oversikt:");

            foreach (Studenter student in students)
            {
                Console.WriteLine($"Studentens Navn:{student.Navn} Alder: {Alder} Studieprogram: {Studieprogram} StudentId: {StudentId}");
            }

        }


        public void SkrivUtInfo()
        {
            AddStudents();
        }



































    }
    
    
}




/*
 Navn, Alder, Studieprogram, StudentID.
 */
 