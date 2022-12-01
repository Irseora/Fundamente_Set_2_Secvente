using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  8. Determianti al n-lea numar din sirul lui Fibonacci.
//     Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2)
//     Exemplu: 0, 1, 1, 2, 3, 5, 8 ...

namespace Rezolvari
{
    class Prob_8
    {
        /// <summary> Determina al n-lea numar din sirul Fibonacci. Date de intrare: n </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void FibonacciN(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");
            Console.WriteLine($"----------------------------------------");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            int fN;
            if (n == 1)
                fN = 0;
            else if (n == 2)
                fN = 1;
            else
            {
                int fAnterior = 0, fCurent = 1;
                for (int i = 3; i <= n; i++)
                {
                    fCurent = fAnterior + fCurent;
                    fAnterior = fCurent - fAnterior;
                }
                fN = fCurent;
            }

            Console.WriteLine($"----------------------------------------");
            Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacii: {fN}");
        }
    }
}