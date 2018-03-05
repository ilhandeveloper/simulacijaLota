using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoFinal
{
    class Igra
    {
        public Igra()
        {
            igra();
        }

        /*
        
            Funkcija igra je startna funkcija ovog programa. Ona uzima podatke koliko ce igraca da ima
            i koliko prostora da obezbedi za niz tih objekata. Nakon unetih osnovnih podataka
            poziva ostale funkcije bitne za program.
            
            */
        void igra()
        {
            Console.Clear();
            Console.WriteLine("Koliko igraca zeli da igra?");
            int brIgraca = Convert.ToInt32(Console.ReadLine());
            Igrac[] igraci = new Igrac[brIgraca];
            for (int i = 0; i < brIgraca; i++)
            {

                Console.WriteLine("Unesi ime " + (i + 1) + ". igraca (pa enter), kao i njegovu uplatu.");
                igraci[i] = new Igrac(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                igraci[i].uplacivanjeTiketa(brIgraca);

            }
            ispisDobitnika(brIgraca, igraci);
        }


        /*
            Funkcija ispisDobitnika se poziva nakon svih unetih kombinacija od strane svih igraca.
            Ona kao parametre prima broj igraca i sam taj niz igraca, kako bismo ispisali podatke 
            koliko je koji igrac imao pogodjenih brojeva kao i njegov dobitak.
            Dobitak se dobija na osnovu pogodjenih brojeva puta njegova uplata.
            
            */
        void ispisDobitnika(int brIgraca, Igrac[] igraci)
        {
            
            Generator generator = new Generator();

            //LINQ koji uzima rendom kombinaciju i sortira je ui
            var dobitnaKombinacija = generator.kompjuterskaKombinacija().OrderBy(n=> n);

            Console.Clear();


            Console.Write("\nDobitna kombinacija je:");
            foreach (var item in dobitnaKombinacija)
                Console.Write(item + "|");

            int j = 0;

            Console.WriteLine("\n=====================================");
            for (int i = 0; i < brIgraca; i++)
            {
                j = 0;
                /* linija ispod je LINQ komanda koja nalazi presjek izmedju kombinacije svakog igraca 
                    i kompjuterske kombinacije. Zatim sa foreachom se prolazi kroz taj rezultat
                    i ispisuju se pogodjeni brojevi kao i brojac koliko je brojeva pogodjeno.
                    Zatim se dobitak racuna po formuli broj pogodjenih brojeva puta uplata igraca.                
                */
                var rezultat = igraci[i].kombinacija.Intersect(dobitnaKombinacija);

                Console.Write(igraci[i].Ime + " pogodjeno:  ");
                foreach (var item in rezultat)
                {
                    Console.Write(item + "| ");
                    j++;
                }
                Console.WriteLine("Osvojeno = " + (igraci[i].Uplata * j) + " EUR.");
                Console.WriteLine("=======================================");
                
            }
        }
    }
}
