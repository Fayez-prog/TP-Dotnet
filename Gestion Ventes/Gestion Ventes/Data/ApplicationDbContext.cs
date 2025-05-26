using Gestion_Ventes.Models;
using Microsoft.EntityFrameworkCore;

namespace Gestion_Ventes.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<LigneOrder> LigneOrders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
