using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  7. Se da o secventa de n numere.
//     Sa se determine cea mai mare si cea mai mica valoare din secventa.

namespace Rezolvari
{
    class Prob_7
    {
        public static void MaxMin(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti un sir de {n} numere:");
            int max = int.MinValue, min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x < min) min = x;
                else if (x > max) max = x;
            }

            Console.WriteLine($"Cea mai mare valoare: {max}\nCea mai mica valoare: {min}");
        }
    }
}