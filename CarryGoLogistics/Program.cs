using CGLogistics.Core;
using CGLogistics.Data;
using CGLogistics.Model;
using CGLogistics.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarryGoLogistics
{
    class Program
    {
        private static CGLogisticsContext context = new CGLogisticsContext();

        static void Main(string[] args)
        {
            GlobalConfig.AddInstance();
            ICustomerRepository customerRepository = GlobalConfig.CustomerInstance;
            context.Database.EnsureCreated();

            customerRepository.DisplaysalesReport();
            customerRepository.DisplayHighOrder();
            customerRepository.CustomerByCity();
            customerRepository.TopFiveDeals();

        }
    }
}
