using Dziedziczenie.Figury;
using Dziedziczenie.KlasaStatyczna;
using Dziedziczenie.Pojazdy;
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
        }

       
    }
}
