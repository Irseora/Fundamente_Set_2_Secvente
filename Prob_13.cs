using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 13. O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare
//     sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive.
//     Determinati daca o secventa de n numere este o secventa crescatoare rotita.
//     Rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga & primul element devine ultimul

namespace Rezolvari
{
    class Prob_13
    {
        /// <summary> Determina daca o secventa este o secventa crescatoare rotita. Date de intrare: n, secventa </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void CrescatorRotit(string indicatie)
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