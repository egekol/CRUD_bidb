using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : db tabloları ile proje classları bağlanacak
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //database'i bağlayamazsan: https://stackoverflow.com/questions/33590030/the-tcp-ip-connection-to-the-host-localhost-port-1433-has-failed-error-need-as?rq=1
            
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        
    }
}