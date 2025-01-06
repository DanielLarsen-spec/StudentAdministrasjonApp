using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjonApp
{
    internal class Skole
    {
        public List<Fag> fag {  get; set; }
        public List<Studenter> student { get; set; }

        public Skole()
        {
             fag = new List<Fag>
        {
          new Fag(1, "OOP", 10),
          new Fag(2, "DNA forskning", 10),
        };
         student = new List<Studenter>
        {
          new Studenter("Daniel", 27, "Programmering", 1, new List<Fag>{fag[0]}, new List<Karakterer>{new Karakterer(4, fag[0])}),
          new Studenter("Lars", 29, "Genetikk", 2, new List <Fag> { fag[1]}, new List<Karakterer>{new Karakterer(3, fag[1])})

        };

        }

        public void Meny()
        {
            
            bool inMenu = true;
            while (inMenu) 
            {
            
                Console.WriteLine("Velkommen til studentadministrasjonen.\n trykk 1 for studentinfo\n Trykk 2 for faginformasjon\n Trykk 3 for karakterverdi");
                int userinput = Convert.ToInt32(Console.ReadLine());
                

                switch (userinput) 
                {
                    case 1:
                        LoopThroughStudents();
                        break;
                    
                    case 2:
                        LoopThroughFag();
                        break;

                    case 3:
                        LoopThroughGrades();   
                        break;
                }
                Console.Clear();
            }

        }
        private void LoopThroughStudents()
        {
            foreach(Studenter student in student)
            {
                student.StudentInfo();
            }
        }

        private void LoopThroughFag()
        {
            foreach(Fag fag in fag)
            {
                fag.FagInfo();
            }
        }

        private void LoopThroughGrades()
        {
            foreach (Studenter student in student)
            {
              student.PrintGrades();
            }
        }

        public void Run()
        {
            Meny();
        }






       
       



       









        








            
        
        
        
    
    
   
        




    }
}
