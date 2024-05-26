using Microsoft.EntityFrameworkCore;
using CompanyDb.Models;

namespace CompanyDb.Data{
    public class CompanyDbContext(DbContextOptions<CompanyDbContext> options) : DbContext(options)
    {
        public DbSet<AccessLevel> AccessLevel { get; set; }
        public DbSet<BorrowedItem> BorrowedItems { get; set;}
        public DbSet<BranchOffice> BranchOffice { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employees {get; set; }
        public DbSet<EmployeesChild> EmployeesChild { get; set; }
        public DbSet<HealthCheck> HealthCheck { get; set; }
        public DbSet<Hint> Hint { get; set; }
        public DbSet<JobTitle> JobTitle { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<SickLeave> SickLeave { get; set; }
        public DbSet<Vacation> Vacation { get; set; }
        public DbSet<WorkTime> WorkTime { get; set; }
        
        
    }


}