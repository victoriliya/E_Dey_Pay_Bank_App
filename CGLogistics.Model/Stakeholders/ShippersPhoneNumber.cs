using System;
using System.Collections.Generic;
using System.Text;

namespace CGLogistics.Model
{
    public class ShippersPhoneNumber
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Number { get; set; }
        public int ShipperId { get; set; }
    }
}
