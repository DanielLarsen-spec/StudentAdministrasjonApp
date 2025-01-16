using StudentAdministrasjonApp;

var fag = new List <Fag>();
fag.Add(new Fag(1, "OOP", 10));
fag.Add(new Fag(2, "DNA forskning", 10));
fag.Add(new Fag(3, "Databaser og SQL", 5));
fag.Add(new Fag(4, "Funksjonell programmering", 10));
fag.Add(new Fag(5, "Anatomi", 5));
fag.Add( new Fag(6, "Kjemi", 10));
 

 var student = new List<Studenter>
                {
                    new Studenter("Daniel", 27, "Programmering", 1, new List<Fag> { fag[0] }, new List<Karakterer> { new Karakterer(4, fag[0]) }),
                    new Studenter("Daniel", 27, "Programmering", 1, new List<Fag> { fag[3] }, new List<Karakterer> { new Karakterer(4, fag[2]) }),
                    new Studenter("Daniel", 27, "Programmering", 1, new List<Fag> { fag[0] }, new List<Karakterer> { new Karakterer(4, fag[3]) }),



                    new Studenter("Lars", 29, "Genetikk", 2, new List<Fag> { fag[1] }, new List<Karakterer> { new Karakterer(5, fag[1]) }),
                    new Studenter("Lars", 29, "Genetikk", 2, new List<Fag> { fag[1] }, new List<Karakterer> { new Karakterer(5, fag[4]) }),
                    new Studenter("Lars", 29, "Genetikk", 2, new List<Fag> { fag[1] }, new List<Karakterer> { new Karakterer(5, fag[5]) })
                };

var skole = new Skole();
skole.Run(fag, student);




