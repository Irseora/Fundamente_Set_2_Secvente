using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 11. Se da o secventa de n numere.
//     Se cere sa se caculeze suma inverselor acestor numere.

namespace Rezolvari
{
    class Prob_11
    {
        /// <summary> Determina suma inverselor numerelor din secventa. Date de intrare: n, secventa </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void SumaInverselor(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");
            Console.WriteLine($"----------------------------------------");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti un sir de {n} numere:");
            double suma = 0;
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                suma += (1.0 / x);
            }

            Console.WriteLine($"----------------------------------------");
            Console.WriteLine($"Suma inverselor numerelor din sir: {suma}");
        }
    }
}