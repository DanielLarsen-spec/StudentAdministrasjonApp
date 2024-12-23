using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjonApp
{
    internal class Skole
    {





        public void StudentInfo()
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
                Console.WriteLine($"Studentens Navn:{student.Navn} Alder: {student.Alder} Studieprogram: {student.Studieprogram} StudentId: {student.StudentId}");
            }
        }

        public void FagInfo(List<Fag>fagene)
        {
            List<Fag>fag = new List<Fag>();

        }

        public void KarakterInfo(List<Karakterer>karakterer)
        {
            List<Karakterer>karakter = new List<Karakterer>();
        }

        public void SkrivUtInfo()
        {
            bool IfTrue = true;
            Console.WriteLine(" 1.Student overview \n 2.Subject overview \n 3.grades overview");
            
            while (IfTrue)
            { 
               var userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput) 
                {
                    case 1:
                        StudentInfo();    
                        break;

                    case 2:

                
                
                
                
                
                
                }
            
            
            
            
            }
               
        
        
        
        }






        public void Run()
        {
            SkrivUtInfo();

        
        
        
    
    
   
        

        }



    }
}
