using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Context : DbContext
    {
        public Context() : base("Server=ASUS;Database=DepoStokUygulamasi;Integrated Security=true")
        { 
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Warehouse> WareHouses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<StockOperation> StockOperations { get; set; }
        public DbSet<StockOperationDetails> StockOperationDetails { get; set; }

    }
}
