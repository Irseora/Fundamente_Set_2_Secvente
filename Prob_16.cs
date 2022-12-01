using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 16. O <secventa bitonica rotita> este o secventa bitonica
//     sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive.
//     Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita.
//     Rotire = primul element devine ultimul

namespace Rezolvari
{
    class Prob_16
    {
        /// <summary> Determina daca o secventa este o secventa bitonica rotita. Date de intrare: n, secventa </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void BitonicRotit(string indicatie)
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