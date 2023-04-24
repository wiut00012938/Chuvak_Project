using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDuperMarket.DAL
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double TotalAmount { get; set; }

        public PurchaseOrder(int id, DateTime date, double totalAmount)
        {
            Id = id;
            Date = date;
            TotalAmount = totalAmount;
        }
        public PurchaseOrder()
        {

        }
    }
}
