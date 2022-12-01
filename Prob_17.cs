using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 17. Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa.
//     Determinati daca secventa reprezinta o secventa de paranteze corecta si,
//     daca este, determinati nivelul maxim de incuibare a parantezelor.
//     De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2, pe cand 0 0 1 1 1 0 este incorecta.

namespace Rezolvari
{
    class Prob_17
    {
        /// <summary> Determina daca o secventa de paranteze (reprezentate prin 0 - deschisa si 1 - inchisa) este corecta. Date de intrare: n, secventa </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void Paranteze(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");
            Console.WriteLine($"----------------------------------------");

            Console.WriteLine($"Introduceti o secventa 0 si 1: ");
            string paranteze = Console.ReadLine();

            int nrDeschise = 0, incuibareMax = 0, lungime = paranteze.Length;
            bool ok = true;
            for (int i = 0; i < lungime; i += 2)
            {
                if (paranteze[i] == '0')
                {
                    nrDeschise++;
                    if (nrDeschise > incuibareMax) incuibareMax = nrDeschise;
                }
                else
                {
                    nrDeschise--;
                    if (nrDeschise < 0) ok = false;
                } 
            }

            Console.WriteLine($"----------------------------------------");
            if (ok)
                Console.WriteLine($"Secventa {paranteze} este corecta si are nivelul maxim de incuibare {incuibareMax}.");
            else
                Console.WriteLine($"Secventa {paranteze} nu este corecta.");
        }
    }
}