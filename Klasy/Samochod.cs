using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    class Samochod
    {
        private string marka;
        private int predkoscMax;

        public Samochod(string marka, int predkoscMax)
        {
            this.marka = marka;
            this.predkoscMax = predkoscMax;

        }
            // deklaracja wlasciwosci klasy (property)


         public int LiczbaDrzwi { get; set; }

        public int Predkosc { 
        get { return predkoscMax; } 
            set {
                if (value <=0)
                {
                    Console.WriteLine("Prędkość większa od zera");
                    string s = Console.ReadLine();
                    predkoscMax = Convert.ToInt32(s);
                }
                else
                {
                    
                    predkoscMax = value;
                }
            }
                
            
    }
       
        /// <summary>
        /// Metoda zmienia prędkość maksymalną.
        /// </summary>
        /// <param name="nowaPredkoscMax"></param>
        public void UstawPredkoscMax (int nowaPredkoscMax)
        {
            predkoscMax = nowaPredkoscMax;
        }

        public int PodajPredkoscMax()
        {
            return predkoscMax;
        }


    }
}
