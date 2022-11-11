using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set2
{
    class Program
    {
        // ---------------------------------------------- FUNCTII AJUTATOARE --------------------------------------------------------------

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

        // ---------------------------------------------------- MAIN ---------------------------------------------------------------------

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
                case  1: CatePare(indicatii[1]); break;
                case  2: CateNegZeroPoz(indicatii[2]); break;
                case  3: SumaProdUnuLaN(indicatii[3]); break;
                case  4: Find(indicatii[4]); break;
                case  5: CatePoz(indicatii[5]); break;
                case  6: OrdineCrescatoare(indicatii[6]); break;
                case  7: MaxMin(indicatii[7]); break;
                case  8: FibonacciN(indicatii[8]); break;
                case  9: Monoton(indicatii[9]); break;
                case 10: MaxConsecutiveEgale(indicatii[10]); break;
                case 11: SumaInverselor(indicatii[11]); break;
                case 12: CateGrupuri(indicatii[12]); break;
                case 13: CrescatorRotit(indicatii[13]); break;
                case 14: MonotonRotit(indicatii[14]); break;
                case 15: Bitonic(indicatii[15]); break;
                case 16: BitonicRotit(indicatii[16]); break;
                case 17: Paranteze(indicatii[17]); break;
                
                default: break;
            }
        }

        // -------------------------------------------------- REZOLVARI ------------------------------------------------------------------

        //  1. Se da o secventa de n numere.
        //     Sa se determine cate din ele sunt pare.
        static void CatePare(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti un sir de {n} numere:");
            int nr = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x % 2 == 0) nr++;
            }

            Console.WriteLine($"\nIn sirul dat sunt {nr} numere pare.");
        }

        //  2. Se da o secventa de n numere.
        //     Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.
        static void CateNegZeroPoz(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti un sir de {n} numere:");
            int nrNeg = 0, nrZero = 0, nrPoz = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x < 0) nrNeg++;
                else if (x == 0) nrZero++;
                else nrPoz++;
            }

            Console.WriteLine($"\nIn sirul dat sunt {nrNeg} numere negative, {nrZero} valori de zero si {nrPoz} numere pozitive.");
        }

        //  3. Calculati suma si produsul numerelor de la 1 la n.
        static void SumaProdUnuLaN(string indicatie)
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

        //  4. Se da o secventa de n numere.
        //     Determinati pe ce pozitie se afla in secventa un numara a.
        //     Se considera ca primul element din secventa este pe pozitia 0.
        //     Daca numarul nu se afla in secventa raspunsul va fi -1.
        static void Find(string indicatie)
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

        //  5. Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa.
        //     Se considera ca primul element din secventa este pe pozitia 0.
        static void CatePoz(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

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

        //  6. Se da o secventa de n numere.
        //     Sa se determine daca numerele din secventa sunt in ordine crescatoare.
        static void OrdineCrescatoare(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

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

            if (crescator) Console.WriteLine("Da, secventa este in ordine crescatoare.");
            else Console.WriteLine("Nu, secventa nu este in ordine crescatoare.");
        }

        //  7. Se da o secventa de n numere.
        //     Sa se determine cea mai mare si cea mai mica valoare din secventa.
        static void MaxMin(string indicatie)
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

        //  8. Determianti al n-lea numar din sirul lui Fibonacci.
        //     Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2)
        //     Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
        static void FibonacciN(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

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

            Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacii: {fN}");
        }

        //  9. Sa se determine daca o secventa de n numere este monotona.
        //     Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.
        static void Monoton(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

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

            if (monotonie == 0)
                Console.WriteLine("Secventa nu este monotona.");
            else if (monotonie == 1)
                Console.WriteLine("Secventa este monoton crescatoare.");
            else if (monotonie == 2)
                Console.WriteLine("Secventa este monoton descrescatoare.");
            else
                Console.WriteLine("Secventa este monotona. Toate elementele sunt egale.");
        }

        // 10. Se da o secventa de n numere.
        //     Care este numarul maxim de numere consecutive egale din secventa.
        static void MaxConsecutiveEgale(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti un sir de {n} numere:");
            int maxConsecutiveEgale = -1, curentConsecutiveEgale = 1, nrAnterior = -1;
            for (int i = 0; i < n; i++)
            {
                int nrCurent = int.Parse(Console.ReadLine());

                if (i != 0 && nrAnterior == nrCurent)
                {
                    curentConsecutiveEgale++;
                }
                else
                {
                    if (curentConsecutiveEgale > maxConsecutiveEgale)
                        maxConsecutiveEgale = curentConsecutiveEgale;

                    curentConsecutiveEgale = 1;
                }

                nrAnterior = nrCurent;
            }

            if (curentConsecutiveEgale > maxConsecutiveEgale)
                maxConsecutiveEgale = curentConsecutiveEgale;

            Console.WriteLine($"Numarul maxim de numere consecutive egale: {maxConsecutiveEgale}");
        }

        // 11. Se da o secventa de n numere.
        //     Se cere sa se caculeze suma inverselor acestor numere.
        static void SumaInverselor(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

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

        // 12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.
        //     Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.
        //     De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.
        static void CateGrupuri(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti un sir de {n} numere:");
            int nrGrupuri = 0, nAnterior = 0;
            for (int i = 0; i < n; i++)
            {
                int nCurent = int.Parse(Console.ReadLine());

                if (nCurent != 0)
                {
                    if (nAnterior == 0)
                    {
                        nrGrupuri++;
                    }
                }

                nAnterior = nCurent;
            }

            Console.WriteLine($"Grupuri de numere consecutive diferite de 0: {nrGrupuri}");
        }

        // 13. O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare
        //     sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive.
        //     Determinati daca o secventa de n numere este o secventa crescatoare rotita.
        //     Rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga & primul element devine ultimul
        static void CrescatorRotit(string indicatie)
        {

        }

        // 14. O <secventa monotona rotita> este o secventa de numere monotona
        //     sau poate fi transformata intr-o secventa montona prin rotiri succesive.
        //     Determinati daca o secventa de n nu//mere este o secventa monotona rotita.
        static void MonotonRotit(string indicatie)
        {

        }

        // 15. O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator.
        //     Se da o secventa de n numere. Sa se determine daca este bitonica.
        //     De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica.
        static void Bitonic(string indicatie)
        {

        }

        // 16. O <secventa bitonica rotita> este o secventa bitonica
        //     sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive.
        //     Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita.
        //     Rotire = primul element devine ultimul
        static void BitonicRotit(string indicatie)
        {

        }

        // 17. Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa.
        //     Determinati daca secventa reprezinta o secventa de paranteze corecta si,
        //     daca este, determinati nivelul maxim de incuibare a parantezelor.
        //     De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2, pe cand 0 0 1 1 1 0 este incorecta.
        static void Paranteze(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine($"Introduceti o secventa 0 si 1: ");
            string paranteze = Console.ReadLine();

            int nrDeschise = 0, incuibareMax = 0, lungime = paranteze.Length;
            bool ok = true;
            for (int i = 0; i < lungime; i += 2)
            {
                if (paranteze[i] == '0')
                {
                    nrDeschise++;
                    if (nrDeschise > incuibareMax) incuibareMax = nrDeschise;
                }
                else
                {
                    nrDeschise--;
                    if (nrDeschise < 0) ok = false;
                } 
            }

            if (ok)
                Console.WriteLine($"Secventa {paranteze} este corecta si are nivelul maxim de incuibare {incuibareMax}.");
            else
                Console.WriteLine($"Secventa {paranteze} nu este corecta.");
        }
    }
}