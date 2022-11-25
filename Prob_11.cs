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
        public static void SumaInverselor(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti un sir de {n} numere:");
            double suma = 0;
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                suma += (1.0 / x);
            }

            Console.WriteLine($"Suma inverselor numerelor din sir: {suma}");
        }
    }
}