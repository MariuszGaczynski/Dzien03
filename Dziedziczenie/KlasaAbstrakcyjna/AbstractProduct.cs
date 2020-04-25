using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.KlasaAbstrakcyjna
{
    abstract class AbstractProduct
    {
        protected string name;
        protected double price;

        public AbstractProduct(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Info o produkcie {name} - {price}");
        }

        public abstract void ShowPrice();
       
            

    }


}
