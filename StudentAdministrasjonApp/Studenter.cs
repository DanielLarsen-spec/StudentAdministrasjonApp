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
    
        public Studenter(string name, int alder, string studieprogram, int studentid) 
        {
            
            fagene = new List<Fag>();
            Navn = name;
            Alder = alder;
            Studieprogram = studieprogram;
            StudentId = studentid;
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
 