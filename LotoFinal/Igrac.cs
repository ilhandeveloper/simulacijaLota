using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoFinal
{
    class Igrac
    {
        string ime;
        double uplata;
        public string Ime { get { return ime; } set { ime = value; } }
        public double Uplata { get { return uplata; } set { uplata = value; } }

        public HashSet<int> kombinacija = new HashSet<int>();



        public Igrac(string i, double u)
        {
            ime = i;
            uplata = u;
        }

        /* 
            funkcija uplacivanjeTiketa je po tipu void i prihvata broj igraca iz Klase Igra.
            U njoj se nalazi for petlja koja sluzi za upisivanje kombinacije od strane Igraca.
            Prvi if unutar for petlje omogucava da se brojevi ne ponavljaju sto je karakteristika
            igre loto i da budu u rasponu od 7 do 39, jer smo konkretno taj loto isprogramirali.
            
            */
        public void uplacivanjeTiketa(int n)
        {
            int broj = 0;


            Console.WriteLine($"{Ime} unesite vasu zeljenu kombinaciju: ");
            for (int i = 0; i < 7; i++)
            {
                loop1:
                Console.Write((i + 1) + ". broj =  ");

                broj = Convert.ToInt32(Console.ReadLine());

                if (kombinacija.Contains(broj))
                {
                    Console.WriteLine("Vec si uneo taj broj");
                    goto loop1;

                }

                else if (broj > 0 && broj < 39)
                {
                    kombinacija.Add(broj);

                }

                else
                {
                    Console.WriteLine("Loto je 7/39. Moras uneti broj u tom rasponu!");
                    goto loop1;
                }


            }
        }
    }
}
