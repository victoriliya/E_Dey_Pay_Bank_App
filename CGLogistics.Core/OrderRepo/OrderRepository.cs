﻿using CGLogistics.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CGLogistics.Core
{
    class OrderRepository : IOrderRepository
    {
        public List<Product> Products { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Add<T>(T model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update<T>(T model)
        {
            throw new NotImplementedException();
        }
    }
}
