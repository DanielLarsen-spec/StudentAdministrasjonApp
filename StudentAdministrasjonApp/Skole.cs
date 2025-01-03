using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjonApp
{
    internal class Skole
    {

        public List<Studenter> student = new List<Studenter>
        {    
          new Studenter("Daniel", 27, "Programmering", 1),
          new Studenter("Lars", 29, "Genetikk", 2)
        };

        public List<Fag> fag = new List<Fag>
        {
          new Fag(1, "OOP", 10),
          new Fag(2, "DNA forskning", 10),
        };

        public List<Karakterer> karakter = new List<Karakterer>
        {
          new Karakterer("4"),
          new Karakterer("5")
        };

        public void Meny()
        {
            bool inMenu = true;
            while (inMenu) 
            {
            int userinput = Convert.ToInt32(Console.ReadLine());
                

                switch (userinput) 
                {
                    case 1:
                        LoopThroughStudents();
                            break;
                    
                    case 2:
                        LoopThroughFag();
                        break;

                }
            }
        }
        public void LoopThroughStudents()
        {
            foreach(Studenter student in student)
            {
                student.StudentInfo();
            }
        }

        public void LoopThroughFag()
        {
            foreach(Fag fag in fag)
            {
                fag.FagInfo();
            }
        }

        public void LoopThroughGrades()
        {
            foreach(Karakterer karakterer in karakter)
            {
                karakterer.KarakterInfo();

            }
        }




        



        public void Run()
        {
            Meny();
        }






            
        
        
        
    
    
   
        




    }
}
