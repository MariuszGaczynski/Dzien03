using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod("FIAT", 180);

            //samochod.UstawPredkoscMax(200);
            
            samochod.Predkosc = 222;
            Console.WriteLine("samochodowa predkosc" + samochod.Predkosc);
            samochod.Predkosc = -10;
            Console.WriteLine("samochod predkosc po zmianie " + samochod.Predkosc);
            samochod.LiczbaDrzwi = 2;
             Console.WriteLine  ("Liczba dzrwi = " + samochod.LiczbaDrzwi);
            Console.ReadLine();
        }
    }
}
