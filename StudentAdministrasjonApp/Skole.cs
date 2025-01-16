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
        public List<AddSubject> addSubjects { get; set; }
        public Skole()
        {




           




        }
        public void Meny(List<Fag>fag, List<Studenter>studenter)
        {
            
            bool inMenu = true;
            while (inMenu) 
            {
                
                Console.WriteLine("Velkommen til studentadministrasjonen.\n trykk 1 for studentinfo\n Trykk 2 for faginformasjon\n Trykk 3 for karakterverdi\n Trykk 4 for å legge til ett nytt fag");
                string userinput = Console.ReadLine();
                

                switch (userinput) 
                {
                    case "1":
                        Console.Clear();
                        LoopThroughStudents(studenter);
                        break;
                    
                    case "2":
                        Console.Clear();
                        LoopThroughFag();
                        break;

                    case "3":
                        Console.Clear();
                        LoopThroughGrades();   
                        break;
                    
                    case "4":
                        Console.Clear();
                        AddSubject.SubjectAdder(fag);

                        break;



                    case "5":
                        System.Environment.Exit(0);
                        break;
                    
                }
            }
        }

        private void LoopThroughStudents(List<Studenter>studenter)
        {
            foreach(Studenter student in studenter)
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
        private void GetAddSubject()
        {
           
            
            
        }

        public void Run(List<Fag>fag, List<Studenter>studenter)
        {
            Meny(fag, studenter);
            
        }






       
       



       









        








            
        
        
        
    
    
   
        




    }
}
