using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjonApp
{
    internal class Karakterer
    {
        public List<Studenter> Students { get; set; }
        public List<Fag> fagene {  get; set; }
        public int KarakterVerdi { get; set; }   
        
        public Karakterer(string karakterverdi)
        {
            Students = new List<Studenter>();
            fagene = new List<Fag>();
            KarakterVerdi = 0;

        }
        
        public void KarakterInfo()
        {
            Console.WriteLine($"");
        }
    
    
    
    
    
    }
}
