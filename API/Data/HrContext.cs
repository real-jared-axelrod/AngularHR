using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data
{
    public class HrContext : DbContext
    {
        public HrContext(DbContextOptions<HrContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}