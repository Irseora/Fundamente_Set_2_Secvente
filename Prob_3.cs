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
        public static void SumaProdUnuLaN(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti un sir de {n} numere:");
            int suma = 0, produs = 1;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
                produs *= i;
            }

            Console.WriteLine($"\nSuma: {suma}\nProdusul: {produs}");
        }
    }
}