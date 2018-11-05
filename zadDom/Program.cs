using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadDom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwsza liczbe: ");
            int podanaLiczba1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj druga liczbe: ");
            int podanaLiczba2 = Convert.ToInt32(Console.ReadLine());

            if (podanaLiczba1 + podanaLiczba2 >= 15) Console.WriteLine(podanaLiczba1+podanaLiczba2);
            else Console.WriteLine($"{podanaLiczba1+podanaLiczba2} Suma mniejsza od 15");
            Console.ReadLine();

        }
    }
}
