using CGLogistics.Model.Address;
using System;
using System.Collections.Generic;
using System.Text;

namespace CGLogistics.Model
{
    public class Supplier
    {
        public Supplier()
        {
            SuppliersPhoneNumbers = new List<SuppliersPhoneNumber>();
            SuppliersAddresses = new List<SuplliersAddress>();
        }
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string SupplierRegNumber { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierPassword { get; set; }
        public List<SuppliersPhoneNumber> SuppliersPhoneNumbers { get; set; }
        public List<SuplliersAddress> SuppliersAddresses { get; set; }
        
    }
}
