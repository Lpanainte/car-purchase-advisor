using Microsoft.EntityFrameworkCore;
using CarPurchaseAdvisor.Models;

namespace CarPurchaseAdvisor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}