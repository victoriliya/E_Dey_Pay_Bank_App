using CGLogistics.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CGLogistics.Core
{
    class SupplierRepository : ISupplierRepository
    {
        public List<Supplier> Suppliers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Add<T>(T model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Supplier GetSupplier(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update<T>(T model)
        {
            throw new NotImplementedException();
        }
    }
}
