namespace CGLogistics.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public Customer Customer { get; set; }
    }
}