using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rezolvari;

namespace Set2
{
    class Program
    {
        static int Afis(string[] indicatii)
        {
            Console.Clear();
            for (int i = 0; i < indicatii.Length; i++)
                Console.WriteLine(indicatii[i] + "\n");
            
            int prob = 0;
            while (prob < 1)
            {
                Console.WriteLine("\nAlegeti o problema: ");
                prob = int.Parse(Console.ReadLine());
            }

            return prob;
        }

        static void Main(string[] args)
        {
            string[] indicatii = {"Setul de probleme 2 (Secvente):",
                                  " 1. Se da o secventa de n numere.\n    Sa se determine cate din ele sunt pare.",
                                  " 2. Se da o secventa de n numere.\n    Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.",
                                  " 3. Calculati suma si produsul numerelor de la 1 la n.",
                                  " 4. Se da o secventa de n numere.\n    Determinati pe ce pozitie se afla in secventa un numara a.",
                                            // Se considera ca primul element din secventa este pe pozitia 0.
                                            // Daca numarul nu se afla in secventa raspunsul va fi -1.
                                  " 5. Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa.",
                                            // Se considera ca primul element din secventa este pe pozitia 0.
                                  " 6. Se da o secventa de n numere.\n    Sa se determine daca numerele din secventa sunt in ordine crescatoare.",
                                  " 7. Se da o secventa de n numere.\n    Sa se determine cea mai mare si cea mai mica valoare din secventa.",
                                  " 8. Determianti al n-lea numar din sirul lui Fibonacci.",
                                            // Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2).
                                            // Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
                                  " 9. Sa se determine daca o secventa de n numere este monotona.",
                                            // Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.
                                  "10. Se da o secventa de n numere.\n    Care este numarul maxim de numere consecutive egale din secventa.",
                                  "11. Se da o secventa de n numere.\n    Se cere sa se caculeze suma inverselor acestor numere.",
                                  "12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.\n    Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.",
                                            // De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.
                                  "13. O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare\n    sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive.\n    Determinati daca o secventa de n numere este o secventa crescatoare rotita.",
                                            // Rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga & primul element devine ultimul
                                  "14. O <secventa monotona rotita> este o secventa de numere monotona\n    sau poate fi transformata intr-o secventa montona prin rotiri succesive.\n    Determinati daca o secventa de n numere este o secventa monotona rotita.",
                                  "15. O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator.\n    Se da o secventa de n numere. Sa se determine daca este bitonica.",
                                            // De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica.
                                  "16. O <secventa bitonica rotita> este o secventa bitonica\n    sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive.\n    Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita.",
                                            // Rotire = primul element devine ultimul
                                  "17. Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa.\n    Determinati daca secventa reprezinta o secventa de paranteze corecta si,\n    daca este, determinati nivelul maxim de incuibare a parantezelor.",
                                            // De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2, pe cand 0 0 1 1 1 0 este incorecta.
                                 };

            int prob = Afis(indicatii);
            switch (prob)
            {
                case  1: Prob_1.CatePare(indicatii[1]); break;
                case  2: Prob_2.CateNegZeroPoz(indicatii[2]); break;
                case  3: Prob_3.SumaProdUnuLaN(indicatii[3]); break;
                case  4: Prob_4.Find(indicatii[4]); break;
                case  5: Prob_5.CatePoz(indicatii[5]); break;
                case  6: Prob_6.OrdineCrescatoare(indicatii[6]); break;
                case  7: Prob_7.MaxMin(indicatii[7]); break;
                case  8: Prob_8.FibonacciN(indicatii[8]); break;
                case  9: Prob_9.Monoton(indicatii[9]); break;
                case 10: Prob_10.MaxConsecutiveEgale(indicatii[10]); break;
                case 11: Prob_11.SumaInverselor(indicatii[11]); break;
                case 12: Prob_12.CateGrupuri(indicatii[12]); break;
                case 13: Prob_13.CrescatorRotit(indicatii[13]); break;
                case 14: Prob_14.MonotonRotit(indicatii[14]); break;
                case 15: Prob_15.Bitonic(indicatii[15]); break;
                case 16: Prob_16.BitonicRotit(indicatii[16]); break;
                case 17: Prob_17.Paranteze(indicatii[17]); break;
                
                default: break;
            }
        }
    }
}