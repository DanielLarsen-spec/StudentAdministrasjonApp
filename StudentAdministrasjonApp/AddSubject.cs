using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjonApp
{
    internal class AddSubject
    {
        public AddSubject(List<Fag>fag) 
        {
            SubjectAdder(fag);
        }
        
        public static void SubjectAdder(List<Fag>fag)
        {
            Console.Clear();
            int fagKode;
            string subjectName;
            int StudyPoints;
            Console.WriteLine("Legg til ett eller flere fag.");
            Console.WriteLine("Skriv inn fagkoden til faget");
            fagKode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv inn navnet på faget");
            subjectName = Console.ReadLine();
            Console.WriteLine("Skriv inn antall studiepoeng for faget");
            StudyPoints = Convert.ToInt32(Console.ReadLine());
            if (fagKode == 0 || subjectName == "" || StudyPoints == 0) 
            {
                return;
            }
            fag.Add(new Fag(fagKode, subjectName, StudyPoints));
        }
    }
}

