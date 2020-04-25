using Dziedziczenie.Figury;
using Dziedziczenie.KlasaAbstrakcyjna;
using Dziedziczenie.KlasaStatyczna;
using Dziedziczenie.MetodyWirtualne;
using Dziedziczenie.Pojazdy;
using Dziedziczenie.Przeciazanie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {

            Prostokat prostokat = new Prostokat(2.5, 3);

            double pole = prostokat.ObliczPole();
            Console.WriteLine("Pole prostokata = " + pole);

            Kwadrat kwadrat = new Kwadrat(5);
            pole = kwadrat.ObliczPole();

            Console.WriteLine("pole kwadratu " + pole);
            Console.WriteLine("Czy kwadrat ? :" + kwadrat.CzyKwadrat());


            Console.ReadLine();


            Samochod samochod = new Samochod();
            samochod.Uruchom();
            samochod.Zatankuj();
            samochod.Zatrzymaj();

            SamochodElektryczny samElektryk = new SamochodElektryczny();
            samElektryk.Uruchom();
            samElektryk.Zatankuj();
            samElektryk.Zatrzymaj();

            Console.ReadLine();

            Console.WriteLine("Nazwa Hosta " + Utils.hostname);
            Console.WriteLine("wartosc max = " + Utils.GetMaxValue (2, -23, 5,7,9, 34));

            Console.ReadLine();

            Product ap = new Product("mleko", 2.99);
            ap.ShowPrice();

            Console.ReadLine();

            Wektor wektor1 = new Wektor(2, -4);
            Wektor wektor2 = new Wektor(-2, 3);
            Wektor wektor3 = wektor1.Add(wektor2);

            Wektor wektor = wektor1 + wektor2;

            wektor.Print();

            Wektor wektor4 = wektor1 + 2;
            wektor4.Print();

            Console.ReadLine();

            Kot kot = new Kot();
            Console.WriteLine(kot);

            Console.ReadKey();
        }

       
    }
}
