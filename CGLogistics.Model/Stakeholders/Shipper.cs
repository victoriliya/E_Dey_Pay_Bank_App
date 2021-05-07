using CGLogistics.Model.Address;
using System;
using System.Collections.Generic;
using System.Text;

namespace CGLogistics.Model
{
    public class Shipper
    {
        public Shipper()
        {
            Suppliers = new List<Supplier>();
            ShippersPhoneNumbers = new List<ShippersPhoneNumber>();
            ShippersAddresses = new List<ShippersAddress>();
        }
        public int Id { get; set; }
        public string ShipperName { get; set; }
        public string ShipperRegNumber { get; set; }
        public string ShipperEmail { get; set; }
        public string ShipperPassword { get; set; }
        public List<Supplier> Suppliers { get; set; }
        public List<ShippersPhoneNumber> ShippersPhoneNumbers { get; set; }
        public List<ShippersAddress> ShippersAddresses { get; set; }
    }
}
