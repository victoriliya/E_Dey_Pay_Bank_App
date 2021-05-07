namespace CGLogistics.Model
{
    public class CustomersAddress
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public string ZipCode { get; set; }
        public int CustomerId { get; set; }

    }
}