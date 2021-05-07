using CGLogistics.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CGLogistics.Core
{
    public interface IProductRepository : ICRUDRepository
    {
        public List<Product> Products { get; set; }
        public Product GetProduct { get; set; }

    }
}
