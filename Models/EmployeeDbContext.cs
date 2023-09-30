using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace React_ImageUpload_Core_API.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }

        public DbSet<EmployeeModel> Employees { get; set; }
    }
}
