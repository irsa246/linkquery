using Microsoft.EntityFrameworkCore;

namespace linkquery.Data
{
    public class WebDbContext:DbContext
    {
        public WebDbContext(DbContextOptions<WebDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Enrolled> Enrolled { get; set; }
        public DbSet<Department> Departments { get; set; }


    }
}
