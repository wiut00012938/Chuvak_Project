using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDuperMarket.DAL
{
    public class ToOrder
    {
        public int Difference;
        public string ProductName { get; set; }
        public int Priority { get; set; }
        public int Remaining { get; set; }
        public int PurchaseLevel { get; set; }
        public int To_Order
        {
            get
            {
                Difference = PurchaseLevel - Remaining;
                return Difference;
            }
            set
            {
                Difference = value;
            }
        }
        public double Price { get; set; }

        public ToOrder()
        {

        }
        public ToOrder(string productName, int priority, int remaining, int purchaseLevel, int to_Order, double price)
        {
            ProductName = productName;
            Priority = priority;
            Remaining = remaining;
            PurchaseLevel = purchaseLevel;
            To_Order = to_Order;
            Price = price;
        }
    }
}
