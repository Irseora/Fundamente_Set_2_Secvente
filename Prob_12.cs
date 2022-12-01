using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.
//     Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.
//     De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.

namespace Rezolvari
{
    class Prob_12
    {
        /// <summary> Determina cate grupuri de numere consecutive diferite de 0 sunt in secventa. Date de intrare: n, secventa </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void CateGrupuri(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");
            Console.WriteLine($"----------------------------------------");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti un sir de {n} numere:");
            int nrGrupuri = 0, nAnterior = 0;
            for (int i = 0; i < n; i++)
            {
                int nCurent = int.Parse(Console.ReadLine());

                if (nCurent != 0)
                {
                    if (nAnterior == 0)
                    {
                        nrGrupuri++;
                    }
                }

                nAnterior = nCurent;
            }

            Console.WriteLine($"----------------------------------------");
            Console.WriteLine($"Grupuri de numere consecutive diferite de 0: {nrGrupuri}");
        }
    }
}