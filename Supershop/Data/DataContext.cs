using Microsoft.EntityFrameworkCore;
using Supershop.Data.Entities;

namespace Supershop.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
