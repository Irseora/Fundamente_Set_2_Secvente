using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  4. Se da o secventa de n numere.
//     Determinati pe ce pozitie se afla in secventa un numara a.
//     Se considera ca primul element din secventa este pe pozitia 0.
//     Daca numarul nu se afla in secventa raspunsul va fi -1.

namespace Rezolvari
{
    class Prob_4
    {
        public static void Find(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Numarul cautat: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti un sir de {n} numere:");
            int poz = -1;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == a) poz = i;
            }

            Console.WriteLine($"Pozitia numarului {a} in sir: {poz}");
        }
    }
}