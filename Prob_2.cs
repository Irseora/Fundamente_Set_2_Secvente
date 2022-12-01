using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  2. Se da o secventa de n numere.
//     Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.

namespace Rezolvari
{
    class Prob_2
    {
        /// <summary> Determina cate numere dintr-o secventa de lungime n sunt negative, zero si pozitive. Date de intrare: n, secventa </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void CateNegZeroPoz(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");
            Console.WriteLine($"----------------------------------------");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti un sir de {n} numere:");
            int nrNeg = 0, nrZero = 0, nrPoz = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x < 0) nrNeg++;
                else if (x == 0) nrZero++;
                else nrPoz++;
            }

            Console.WriteLine($"----------------------------------------");
            Console.WriteLine($"{Environment.NewLine}In sirul dat sunt {nrNeg} numere negative, {nrZero} valori de zero si {nrPoz} numere pozitive.");
        }
    }
}