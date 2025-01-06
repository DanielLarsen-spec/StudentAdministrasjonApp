using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjonApp
{
    internal class Karakterer
    {
        
        public Fag fag;
        public double KarakterVerdi { get; set; }   
        
        public Karakterer(double karakterverdi, Fag newFag)
        {
            fag = newFag;
             
            KarakterVerdi = karakterverdi;
            

        }
        
        public void KarakterInfo()
        {
            Console.WriteLine($"Studentinformasjon: \n Fag: {fag}\n Karakterverdiene: {KarakterVerdi}\n");
        }
        
        
    
    
    
    
    }
}
