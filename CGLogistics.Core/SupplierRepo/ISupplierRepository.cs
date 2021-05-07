using CGLogistics.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CGLogistics.Core
{
    public interface ISupplierRepository : ICRUDRepository
    {
        public List<Supplier> Suppliers { get; set; }
        public Supplier GetSupplier(int id);
    }
}
