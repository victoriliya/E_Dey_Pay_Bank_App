using CGLogistics.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CGLogistics.Core
{
    public interface IOrderRepository : ICRUDRepository
    {
        public List<Product> Products { get; set; }
        public Order GetOrder(int id);
    }
}
