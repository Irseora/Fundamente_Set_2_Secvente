using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  5. Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa.
//     Se considera ca primul element din secventa este pe pozitia 0.

namespace Rezolvari
{
    class Prob_5
    {
        /// <summary> Determina cate elemente dintr-o secventa de n numere sunt egale cu pozitia lor. Date de intrare: n, secventa </summary>
        public static void CatePoz(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti un sir de {n} numere:");
            int nr = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == i) nr++;
            }

            Console.WriteLine($"In secventa sunt {nr} numere care sunt egale cu pozitia pe care apar.");
        }
    }
}