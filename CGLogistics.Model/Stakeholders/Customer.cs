using System;
using System.Collections.Generic;

namespace CGLogistics.Model
{
    public class Customer
    {
        public Customer()
        {
            Orders = new List<Order>();
            CustomersAddresses = new List<CustomersAddress>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string OtherName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string OrderId { get; set; }
        public List<CustomersAddress> CustomersAddresses { get; set; }
        public List<Order> Orders { get; set; }

    }
}
