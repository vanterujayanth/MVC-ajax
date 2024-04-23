using Microsoft.EntityFrameworkCore;
using Mvc_Ajax.Entity;

namespace Mvc_Ajax
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
