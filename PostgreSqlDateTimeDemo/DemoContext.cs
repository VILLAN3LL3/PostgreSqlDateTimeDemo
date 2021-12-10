using Microsoft.EntityFrameworkCore;

namespace PostgreSqlDateTimeDemo
{
    public class DemoContext : DbContext
    {
        public DbSet<DemoEntity> DemoEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("host=localhost;database=demo;User Id=postgres;Password=postgres;Include Error Detail=true;");
        }
    }
}
