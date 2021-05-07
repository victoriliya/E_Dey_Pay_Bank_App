using CGLogistics.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CGLogistics.Core
{
    public static class GlobalConfig
    {
        public static ICustomerRepository CustomerInstance { get; set; }

        public static void AddInstance() {
            var context = new CGLogisticsContext();
            CustomerInstance = new CustomerRepository(context);
        }
    }
}
