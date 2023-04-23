using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDuperMarket.DAL
{
    public class Product
    {
        public string name;
        public int purchaseLevel;
        public double price;
        public int Id { get; set; }
        public string Name
        {
            get => name;
            set
            {
                /*We must not allow to set a value that is null or when some stupid people enter spaces*/
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Name cannot be empty");
                name = value;
            }
        }
        public int Remaining { get; set; }
        public int Priority { get; set; }
        public int PurchaseLevel
        {
            get => purchaseLevel;
            set
            {
                if (purchaseLevel == 0)
                    throw new Exception("Purchase level can not be equal to zero");
                purchaseLevel = value;
            }
        }
        public double Price
        {
            get => price;
            set
            {
                if (price == 0) throw new Exception("Price can not be equal to zero");
            }
        }

        public Product()
        {

        }

        public Product(int id, string name, int remaining, int priority, int purchaseLevel, double price)
        {
            Id = id;
            Name = name;
            Remaining = remaining;
            Priority = priority;
            PurchaseLevel = purchaseLevel;
            Price = price;
        }
    }
}
