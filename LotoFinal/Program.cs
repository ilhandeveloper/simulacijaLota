using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoFinal
{
    class Program
    {
        static void Main(string[] args)
        {

            int exit = 1;
            while (true){

                Console.WriteLine("Dobrodosli u igru Loto za pocetak unesite 1. Za kraj 0!");
                exit = Convert.ToInt32(Console.ReadLine());
                if (exit == 0)
                    break;

                Igra igra = new Igra();
            }



        }
    }
}
