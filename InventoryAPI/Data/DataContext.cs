using InventoryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }

/*        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }*/
    }
}
