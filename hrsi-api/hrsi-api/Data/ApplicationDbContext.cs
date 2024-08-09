using hrsi_api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace hrsi_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> MyProperty { get; set; }
    }
}
