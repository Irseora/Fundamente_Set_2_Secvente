using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 14. O <secventa monotona rotita> este o secventa de numere monotona
//     sau poate fi transformata intr-o secventa montona prin rotiri succesive.
//     Determinati daca o secventa de n nu//mere este o secventa monotona rotita.

namespace Rezolvari
{
    class Prob_14
    {
        /// <summary> Determina daca o secventa este o secventa monotona rotita. Date de intrare: n, secventa </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void MonotonRotit(string indicatie)
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