using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoFinal
{
    class Generator
    {

        /* 
            funkcija ispod vraca Hashset koji dobija random brojeve od 1 do 39 bez ponavljanja (sto nam treba u Lot-u)
            bas zbog te karakteristike Hashseta. Ako se neki broj ponovi nece biti dodat u Hashset 
            i njegova velicina se nece promeniti sto nam daje siguran izlaz iz while petlje
            kada velicina Hashseta bude 7. 
            */
        public HashSet<int> kompjuterskaKombinacija()
        {
            HashSet<int> kombinacija = new HashSet<int>();

            Random rand = new Random();
            Console.WriteLine("Pocinje izvlacenje, za nastavak unesi neki broj");
           
            while (kombinacija.Count != 7)
            {
                
                kombinacija.Add(rand.Next(1, 39));
                foreach (var item in kombinacija)
                {
                    Console.Write(item+" |");
                }

                Console.WriteLine();
                int broj = Convert.ToInt32(Console.ReadLine());
                if (kombinacija.Count == 7)
                    return kombinacija;
               

               
            }
               

            return kombinacija;
        }

    }
}
