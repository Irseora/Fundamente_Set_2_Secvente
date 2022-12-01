using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  9. Sa se determine daca o secventa de n numere este monotona.
//     Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.

namespace Rezolvari
{
    class Prob_9
    {
        /// <summary> Determina daca o secventa de n numere este monotona. Date de intrare: n, secventa </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void Monoton(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");
            Console.WriteLine($"----------------------------------------");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti un sir de {n} numere:");

            // 0 = nu este monotona, 1 = monoton crescatoare, 2 = monoton descrescatoare, 3 = toate elementele egale
            int monotonie = 0;

            // Cate numere au fost citite pana acum
            int citit = 0;

            // Citeste primele 2 elemente separat
            int anterior = int.Parse(Console.ReadLine()), curent = int.Parse(Console.ReadLine());
            citit = 2;

            // Daca primele 2 valori sunt egale, citeste pana gaseste valori diferite
            while (citit < n && anterior == curent)
            {
                anterior = curent;
                curent = int.Parse(Console.ReadLine());
                citit++;
            }

            // Daca toate valorile au fost egale
            if (citit == n && anterior == curent)
                monotonie = 3;
            else
            {
                if (curent > anterior)
                    monotonie = 1;
                else if (curent < anterior)
                    monotonie = 2;

                // Citeste valorile ramase
                while (citit < n && monotonie != 0)
                {
                    anterior = curent;
                    curent = int.Parse(Console.ReadLine());
                    citit++;

                    // Se opreste dupa prima contrazicere a tipului de monotonitate aflat anterior
                    if (monotonie == 1 && curent < anterior)
                        monotonie = 0;
                    else if (monotonie == 2 && curent > anterior)
                        monotonie = 0;
                }     
            }

            Console.WriteLine($"----------------------------------------");
            if (monotonie == 0)
                Console.WriteLine("Secventa nu este monotona.");
            else if (monotonie == 1)
                Console.WriteLine("Secventa este monoton crescatoare.");
            else if (monotonie == 2)
                Console.WriteLine("Secventa este monoton descrescatoare.");
            else
                Console.WriteLine("Secventa este monotona. Toate elementele sunt egale.");
        }
    }
}