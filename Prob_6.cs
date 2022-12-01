using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  6. Se da o secventa de n numere.
//     Sa se determine daca numerele din secventa sunt in ordine crescatoare.

namespace Rezolvari
{
    class Prob_6
    {
        /// <summary> Determina daca numerele dintr-o secventa de n numere sunt in ordine crescatoare. Date de intrare: n, secventa </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void OrdineCrescatoare(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");
            Console.WriteLine($"----------------------------------------");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti un sir de {n} numere:");
            bool crescator = true;
            int anterior = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int curent = int.Parse(Console.ReadLine());

                if (curent < anterior) crescator = false;
                anterior = curent;
            }

            Console.WriteLine($"----------------------------------------");
            if (crescator) Console.WriteLine("Da, secventa este in ordine crescatoare.");
            else Console.WriteLine("Nu, secventa nu este in ordine crescatoare.");
        }
    }
}