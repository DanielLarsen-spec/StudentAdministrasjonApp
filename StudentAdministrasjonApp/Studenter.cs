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
        public List<Fag> fagene { get; set; }
        public List<Karakterer> karakterer { get; set; }
        public Studenter(string name, int alder, string studieprogram, int studentid, List<Fag> fagliste, List<Karakterer>Karakterliste) 
        {
            
            fagene = fagliste;
            Navn = name;
            Alder = alder;
            Studieprogram = studieprogram;
            StudentId = studentid;
            karakterer = Karakterliste;
        }

        
        
        public void StudentInfo()
        {
            Console.WriteLine($"Studentnavn:{Navn}\n Alder: {Alder}\n Studieprogram: {Studieprogram}\n StudentID: {StudentId}");
        }
            
            
           
       


            
















































    }
    
    
}




/*
 Navn, Alder, Studieprogram, StudentID.
 */
 