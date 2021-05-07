using System;
using System.Collections.Generic;
using System.Text;
namespace CGLogistics.Model
{
    public class OrderDetails
    {
        public OrderDetails()
        {
            Orders = new List<Order>();
        }
        public int Id { get; set;}
        public DateTime DateOfOrder { get; set; }
        public DateTime DateOfReceipt { get; set; }
        public int SupplierId { get; set; }
        public int ShipperId { get; set; }
        public decimal TotalPrice { get; set; }
        public int OrderId { get; set; }

        public List<Order> Orders { get; set; }


    }
}
