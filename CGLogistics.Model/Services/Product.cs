namespace CGLogistics.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; } 
        public decimal DiscountPrice { get; set; } 
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int PercentageOff { get; set; }
        public Category Category { get; set; }

    }
}