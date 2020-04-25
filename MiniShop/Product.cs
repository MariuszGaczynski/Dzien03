using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    public class Product
    {
        private int id;
        private string name;
        private double price;
        private string descr = String.Empty; // to samo co ""
        private UInt16 version = 0;
        private bool promo = false;
        private bool active = true;

        public double Price { get { return price; } }

        public void SetParam(int id, string name, double price, string descr = "")
        {

        }
        public void ChangePrice(double newPrice)
        {
            // zastanowic się nad mechanizmem histori logowania zmian cen.
            //ma byc mozlwosc zobaczenie historii zmian ceny
        }
        public void ChangeDescription (string newDescr)
        {

        }
        public void SetActive(bool isActive)
        {
            this.active = isActive;
        }


    }

    
}
