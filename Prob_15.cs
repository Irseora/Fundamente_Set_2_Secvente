using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 15. O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator.
//     Se da o secventa de n numere. Sa se determine daca este bitonica.
//     De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica.

namespace Rezolvari
{
    class Prob_15
    {
        /// <summary> Determina daca o secventa este o secventa bitonica </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void Bitonic(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");
            Console.WriteLine($"----------------------------------------");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti un sir de {n} numere:");
        }
    }
}