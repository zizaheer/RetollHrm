using Microsoft.EntityFrameworkCore;
using RetollHrm.Models;

namespace RetollHrm.Data;
    public class HrmContext : DbContext {
        public HrmContext() { }
        public HrmContext(DbContextOptions<HrmContext> options) : base (options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-H7FKF69\SQLDEV2019;Initial Catalog=DBName;Integrated Security=True; User Id: retollhr; Password: retollHr@1234");
        }

        public DbSet<Employee>? Employees { get; set; }
    }
