using Microsoft.EntityFrameworkCore;
using CompanyDb.Models;

namespace CompanyDb.Data{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext>options)
            :base(options) { }

        public DbSet<Employee> Employees {get; set; }
        public DbSet<Company> Company { get; set; }
    }


}