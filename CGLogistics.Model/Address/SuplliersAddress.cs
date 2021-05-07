using System;
using System.Collections.Generic;
using System.Text;

namespace CGLogistics.Model.Address
{
    public class SuplliersAddress
    {
        public int Id { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public State State { get; set; }
        public string ZipCode { get; set; }
        public int SupplierId { get; set; }
    }
}
