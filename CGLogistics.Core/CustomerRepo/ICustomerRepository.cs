using CGLogistics.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CGLogistics.Core
{

    /// <summary>
    /// This interface defines the contract for costumer repository
    /// </summary>
    public interface ICustomerRepository : ICRUDRepository
    {
        public List<Customer> Customers { get; set; }
        public Customer GetCustomer(int id);
        public Customer GetCustomer(string email);
        public void DisplaysalesReport();
        public void DisplayHighOrder();
        public void TopFiveDeals();
        public void CustomerByCity();
    }
}
