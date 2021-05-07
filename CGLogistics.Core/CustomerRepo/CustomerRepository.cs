using CGLogistics.Data;
using CGLogistics.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGLogistics.Core
{

    /// <summary>
    /// This class performs logic for user operation
    /// </summary>
    class CustomerRepository : ICustomerRepository
    {

        private readonly CGLogisticsContext context;

        // Injects interface
        public CustomerRepository(CGLogisticsContext ctx)
        {
            context = ctx;
        }

        public List<Customer> Customers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // Displays report of 13 cusotmers
        public void DisplaysalesReport()
        {
            List<Order> orders = new List<Order>();
            orders = context.Order.ToList();

            Utilities.Utilities.Logger("\n\n\t\t\t--> SALES REPORT <--\n");

            for (int j = 1; j < 13; j++)
            {
                var Country = context.Country.Find(156);
                var customer = context.Customer.Find(j);
                Utilities.Utilities.Logger($"\n {j.ToString()}. ");

                Utilities.Utilities.Logger($"{customer.FirstName} {customer.SecondName} | ");

                Utilities.Utilities.Logger($"{FindAddress(customer.Id)}\n");

                FindOrder(orders, customer.Id);

            }

        }

        // Finds and logs the customers registered
        public void FindOrder(List<Order> orders, int id) {
            orders = context.Order.Where(x => x.CustomerId == id).ToList();
            if (orders != null)
            {
                bool flag = true;
                int i = 0;
                foreach (var order in orders)
                {
                    if (flag)
                    {
                        flag = false;

                        Utilities.Utilities.Logger($" --> Items Purchased\n");
                        Utilities.Utilities.Logger("   |-----|-----------------|------------|----------------|----------------|\n");
                        Utilities.Utilities.Logger("   | S/N |    Item Name    |   Amount   |  Date Of Order | date Of Receipt|\n");
                        Utilities.Utilities.Logger("   |-----|-----------------|------------|----------------|----------------|\n");
                    }
                    i++;
                    var product = context.Product.Find(order.ProductId);
                    var orderDetails = context.OrderDetails.Find(id);
                    string strFormat = String.Format("   |{0, -5}|{1, -17}|{2, -12}|{3, -16}|{4, -16}|\n", i, product.ProductName, product.DiscountPrice, orderDetails.DateOfOrder.ToString("dd/MM/yyyy"), orderDetails.DateOfReceipt.ToString("dd/MM/yyyy"));
                    Utilities.Utilities.Logger(strFormat);
                    Utilities.Utilities.Logger("   |-----|-----------------|------------|----------------|----------------|\n");
                }
                if (flag == true)
                {
                    Utilities.Utilities.Logger("   --> No item purchased yet\n");
                }
            }
        }

        // Find Orders greate than 50000
        public void FindHighOrder(List<Order> orders, int id)
        {
            orders = context.Order.Where(x => x.CustomerId == id).ToList();



            if (orders != null)
            {
                
                int i = 0;
                bool flag = true;
                foreach (var order in orders)
                {
                    
                    i++;
                    var product = context.Product.Find(order.ProductId);
                    if (product.DiscountPrice > (decimal)49999.00)
                    {
                        if (flag == true)
                        {
                            flag = false;
                            Utilities.Utilities.Logger("   |-----|-----------------|------------|\n");
                            Utilities.Utilities.Logger("   | S/N |    Item Name    |   Amount   |\n");
                            Utilities.Utilities.Logger("   |-----|-----------------|------------|\n");
                        }
                        var orderDetails = context.OrderDetails.Find(id);
                        string strFormat = String.Format("   |{0, -5}|{1, -17}|{2, -12}|\n", i, product.ProductName, product.DiscountPrice);
                        Utilities.Utilities.Logger(strFormat);
                        Utilities.Utilities.Logger("   |-----|-----------------|------------|\n");
                    }
                }
            }
        }

        // Logs all orders greater than 50000
        public void DisplayHighOrder() {
            List<Product> products = new List<Product>();
            var orders = context.Order.ToList();

            products = context.Product.Where(x => x.DiscountPrice > 49000).ToList();

            List<State> states = new List<State>();

            states.Add(context.State.Find(25));
            states.Add(context.State.Find(1));
            states.Add(context.State.Find(2));
            states.Add(context.State.Find(3));
            states.Add(context.State.Find(4));

            List<Customer> customers = new List<Customer>();

            int i = 0;

            foreach (var state in states)
            {
                i++;
                Utilities.Utilities.Logger($"\n {i.ToString()}. ");
                Utilities.Utilities.Logger($"{state.StateName}");
                var customersAddresses = context.CustomersAddress.Where(x => x.StateId == state.Id).ToList();
                foreach (var addresses in customersAddresses)
                {
                    var customer = context.Customer.Find(addresses.CustomerId);
                    Utilities.Utilities.Logger($"\n    Customers Name => {customer.FirstName} {customer.SecondName}\n");
                    FindHighOrder(orders, customer.Id);
                }


            }

        }

        // Return the address of a stakeholder
        public string FindAddress(int Id) {
            var customersAddresses = context.CustomersAddress.Find(Id);
            if (customersAddresses != null)
            {
                var state = context.State.Find(customersAddresses.StateId);
                var country = context.Country.Find(customersAddresses.CountryId);
                return $"{ customersAddresses.Address} {state.StateName}, {country.CountryName}";
            }
            return "";
        }

        // Returns all the city and corresponding customers
        public void CustomerByCity()
        {
            List<Product> products = new List<Product>();
            var orders = context.Order.ToList();

            products = context.Product.Where(x => x.DiscountPrice > 49000).ToList();

            var states = context.State.ToList();

            List<Customer> customers = new List<Customer>();

            int i = 0;

            foreach (var state in states)
            {
                i++;
                Utilities.Utilities.Logger($"\n {i.ToString()}. ");
                Utilities.Utilities.Logger($"{state.StateName}");
                var customersAddresses = context.CustomersAddress.Where(x => x.StateId == state.Id).ToList();
                foreach (var addresses in customersAddresses)
                {
                    var customer = context.Customer.Find(addresses.CustomerId);
                    Utilities.Utilities.Logger($"\n    Customers Name => {customer.FirstName} {customer.SecondName}\n");
                }


            }

        }

        // Return top 5 deals
        public void TopFiveDeals() {
            
            var products = context.Product.ToList();
            var top = context.Product.OrderByDescending(x => x.PercentageOff);
            int i = 0;
            Utilities.Utilities.Logger($"\n\n    --TOP FIVE DEALS--\n");
            foreach (var product in top)
            {
                i++;
                if (i > 5) break;
                Utilities.Utilities.Logger($" {i.ToString()}.");
                Utilities.Utilities.Logger($" {product.ProductName}");
                Utilities.Utilities.Logger($" => {product.PercentageOff}% off");
                Utilities.Utilities.Logger($"\n  -> Market price #{product.Price.ToString()}");
                Utilities.Utilities.Logger($"\n  -> Discount price #{product.DiscountPrice}\n\n");              
            }
        }

        public bool Add<T>(T model)
        {
            bool returnValue = false;
            context.Add(model);
            var saved = context.SaveChanges();

            if (saved >= 1)
                returnValue = true;
            Console.WriteLine(returnValue);
            return returnValue;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(string email)
        {
            throw new NotImplementedException();
        }

        public bool Update<T>(T model)
        {
            throw new NotImplementedException();
        }
    }
}
