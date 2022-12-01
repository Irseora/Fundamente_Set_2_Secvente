using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  3. Calculati suma si produsul numerelor de la 1 la n.

namespace Rezolvari
{
    class Prob_3
    {
        /// <summary> Calculeaza suma si produsul numerelor de la 1 la n. Date de intrare: n </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void SumaProdUnuLaN(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");
            Console.WriteLine($"----------------------------------------");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti un sir de {n} numere:");
            int suma = 0, produs = 1;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
                produs *= i;
            }

            Console.WriteLine($"----------------------------------------");
            Console.WriteLine($"{Environment.NewLine}Suma: {suma}{Environment.NewLine}Produsul: {produs}");
        }
    }
}