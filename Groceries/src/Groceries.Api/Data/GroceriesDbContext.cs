using Groceries.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Groceries.Api.Data
{
    public class GroceriesDbContext : DbContext
    {
        public GroceriesDbContext(DbContextOptions options)
        : base(options)
        {
        }

        public DbSet<Grocery> Groceries { get; set; }
    }
}
