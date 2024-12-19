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
        
        private Fag(int fagkode, string fagnavn, int antallstudiepoeng) 
        {
            FagKode = fagkode;
            Fagnavn = fagnavn;
            AntallStudiePoeng = antallstudiepoeng;
        }

        private void AddFag() 
        { 
        List<Fag> fagene = new List<Fag>();

            Fag fag1 = new Fag(4422, "Automasjon", 30);
            Fag fag2 = new Fag(4555, "Databaser og API", 30);
            Fag fag3 = new Fag(5699, "OOP", 30);

            foreach (Fag fag in fagene) 
            { 
                Console.WriteLine(fag);
            
            }
        }
            
        public void SkrivUtInfo()
        {
            AddFag();
        }
            
        
            
        
        
        
        
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}

//Egenskaper: Fagkode, Fagnavn, AntallStudiepoeng.













