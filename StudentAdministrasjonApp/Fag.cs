using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministrasjonApp
{
    internal class Fag
    {
       int FagKode {  get; set; }
       string Fagnavn { get; set; }
       int AntallStudiePoeng { get; set; }
        
        public Fag(int fagkode, string fagnavn, int antallstudiepoeng) 
        {
            FagKode = fagkode;
            Fagnavn = fagnavn;
            AntallStudiePoeng = antallstudiepoeng;
        }

        public void FagInfo()
        {
            Console.WriteLine($"Fagkode:{FagKode}\n  Fagnavn: {Fagnavn}\n  Antall studiepoeng: {AntallStudiePoeng}\n ");
        }

      
            
        
        
            
        
        
        
        
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}

//Egenskaper: Fagkode, Fagnavn, AntallStudiepoeng.













