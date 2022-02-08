using Microsoft.EntityFrameworkCore;

namespace MVCApp.Models
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options)
        {

        }

        public DbSet<Employee> employees { get; set; }
    }
}
