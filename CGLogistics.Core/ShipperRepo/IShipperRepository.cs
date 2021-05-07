using CGLogistics.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CGLogistics.Core
{
    interface IShipperRepository : ICRUDRepository
    {
        public List<Shipper> Shippers { get; set; }
        public Shipper GetShipper();
    }
}
