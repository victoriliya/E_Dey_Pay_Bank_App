using System;
using System.Collections.Generic;
using System.Text;

namespace CGLogistics.Model
{
    public class SuppliersPhoneNumber
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Number { get; set; }
        public int SupplierId { get; set; }
    }

}
