using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  1. Se da o secventa de n numere.
//     Sa se determine cate din ele sunt pare.

namespace Rezolvari
{
    class Prob_1
    {
        /// <summary> Determina cate numere dintr-o secventa de n numere sunt pare. Date de intrare: n, secventa </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void CatePare(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");
            Console.WriteLine($"----------------------------------------");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti un sir de {n} numere:");
            int nr = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x % 2 == 0) nr++;
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"{Environment.NewLine}In sirul dat sunt {nr} numere pare.");
        }
    }
}