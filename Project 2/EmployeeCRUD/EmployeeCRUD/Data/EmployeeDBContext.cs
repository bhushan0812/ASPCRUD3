using EmployeeCRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUD.Data
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}
