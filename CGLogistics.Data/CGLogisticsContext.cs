using CGLogistics.Model;
using CGLogistics.Model.Address;
using Microsoft.EntityFrameworkCore;
using System;

namespace CGLogistics.Data
{

    /// <summary>
    /// This class implements the EF core context
    /// </summary>
    public class CGLogisticsContext : DbContext
    {
        #region Tables
        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Category>  Category { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetails> OrderDetails{ get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Shipper> Shipper { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<SuppliersPhoneNumber> SuppliersPhoneNumber { get; set; }
        public DbSet<CustomersPhoneNumber> CustomersPhoneNumber { get; set; }
        public DbSet<ShippersPhoneNumber> ShippersPhoneNumber { get; set; }
        public DbSet<CustomersAddress> CustomersAddress { get; set; }
        public DbSet<ShippersAddress> ShippersAddress { get; set; }
        public DbSet<SuplliersAddress> SuplliersAddress { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-R0IBRK5V;Initial Catalog=CGLogisticsDb;Integrated Security=True");
        }
    }
}
