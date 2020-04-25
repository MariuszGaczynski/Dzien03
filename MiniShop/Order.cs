using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class Order
    {
        enum OrderStatus
        {
            NewOrder,Complete, Confirmed, Shipped,Returned, Cancelled
        }


        private string orderNumber;
        private List<OrderItem> items = new List<OrderItem>(); //utworzona pusta lista
        private byte discount = 0;
        private string customerName;
        private string shipAddress;
       
        private DateTime orderDate; //data zamówienia
        private  OrderStatus status = OrderStatus.NewOrder;


        public double TotalAmount { get { return CalcTotalAmount(); } }  // całkowita wartośc zamówienie
        //metody

        public bool AddProduct(Product product, int qnty)
        {
            //akcja dodania produktu do ListChangedType produktow

            //sprawdzic jaki jest stan zamowienia przed dodaniem produktu (if)
            //products.Add(product);

            if (status == OrderStatus.NewOrder && qnty > 0 && product != null)
            {
                items.Add(new OrderItem(product, qnty));
                    return true;
            }
            else
            {
                return false;
            }

        }


        public bool Clear()
        {
            if (status == OrderStatus.NewOrder)
            { 
               items.Clear();
                return true;
            }
            else
            {
                return false;
            }

        }

        private double CalcTotalAmount()
        {
            double amount = 0.0;

            foreach (var item in items)
            {
                amount += item.ProductPrice * item.Qnty;
            }


            if (discount >0 && discount <=100)
            {
                amount *= (100 - discount) / 100.0;
            }

            return amount;
        }

        public void Print ()
        {
            Console.WriteLine("Elementy zamówienia: ");

            foreach (var item in items)
            {
                Console.WriteLine($"{XXXXXX}\t{item.Qnty}\t{item.ProductPrice}\t{item.ProductPrice *item.Qnty}");
            }

            Console.WriteLine("Do zapłaty : " + CalcTotalAmount());
        }

    }
}
