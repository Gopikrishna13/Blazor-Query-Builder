using CreatingQueryBuilderSample.Models;
using Microsoft.EntityFrameworkCore;

namespace CreatingQueryBuilderSample.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EmployeeDetails> Employees { get; set; }
    }
}
