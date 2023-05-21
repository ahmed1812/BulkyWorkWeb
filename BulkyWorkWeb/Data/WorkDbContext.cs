using BulkyWorkWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWorkWeb.Data
{
    public class WorkDbContext : DbContext
    {
        public WorkDbContext(DbContextOptions<WorkDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
