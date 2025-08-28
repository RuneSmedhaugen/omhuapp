using Microsoft.EntityFrameworkCore;
using TaskApp.API.Models;

namespace TaskApp.API.Data {
    public class DataContext : DbContext {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}