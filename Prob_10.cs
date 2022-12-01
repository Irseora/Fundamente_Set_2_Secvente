using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 10. Se da o secventa de n numere.
//     Care este numarul maxim de numere consecutive egale din secventa.

namespace Rezolvari
{
    class Prob_10
    {
        /// <summary> Determina numarul maxim de numere consecutive egale din secventa. Date de intrare: n, secventa </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void MaxConsecutiveEgale(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");
            Console.WriteLine($"----------------------------------------");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti un sir de {n} numere:");
            int maxConsecutiveEgale = -1, curentConsecutiveEgale = 1, nrAnterior = -1;
            for (int i = 0; i < n; i++)
            {
                int nrCurent = int.Parse(Console.ReadLine());

                if (i != 0 && nrAnterior == nrCurent)
                {
                    curentConsecutiveEgale++;
                }
                else
                {
                    if (curentConsecutiveEgale > maxConsecutiveEgale)
                        maxConsecutiveEgale = curentConsecutiveEgale;

                    curentConsecutiveEgale = 1;
                }

                nrAnterior = nrCurent;
            }

            if (curentConsecutiveEgale > maxConsecutiveEgale)
                maxConsecutiveEgale = curentConsecutiveEgale;

            Console.WriteLine($"----------------------------------------");
            Console.WriteLine($"Numarul maxim de numere consecutive egale: {maxConsecutiveEgale}");
        }
    }
}