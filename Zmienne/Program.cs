using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmienne
{
    class Program
    {
        static void Main(string[] args)
        {
            //To jest deklaracja lczby całkowitej
            int liczbaCalkowita;
            liczbaCalkowita = 20;

            int liczbaCalkowita2 = liczbaCalkowita;

            int liczbaCalkowita3 = 20;
            //liczba zmiennoprzecinkowa

            double licznaZmiennoprzecinowa = 30.20;

            int liczbaCalkowita5 = (int)licznaZmiennoprzecinowa; 
            int liczbaCalkowita6 = Convert.ToInt32(licznaZmiennoprzecinowa);

            //wartosc logiczna
            bool logika = true;

            bool czyPrawda = 10 > 6;


            //string vs char
            char znak = '1';
            string napis2 = "2";
            //string napis3 = '2';

            //ciezkie rzeczy
            //inkrementacja plus jeden
            //int a = 2;
            //a++;
            //a = a + 1;

            //Console.WriteLine(a++);
            //Console.WriteLine(++a + " " + a--);

            //Console.WriteLine(--a);

            //Console.ReadLine();

            int a = 10;
            a = a + 2;

            int b = 10;
            b += 2; //b=b+2;

            double c = 10;
            c *= b;

            //instrukcje warunkowe
            //if 

            //Czy podana liczba jest wieksza od 10

            Console.WriteLine("Podaj liczbe1: ");
            int podanaLiczba1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj liczbe2: ");
            int podanaLiczba2 = Convert.ToInt32(Console.ReadLine());

            if (podanaLiczba1 > podanaLiczba2) Console.WriteLine($"{podanaLiczba1} jest"); //??? bład co zrobic



            Console.ReadLine();





        }
    }
}
