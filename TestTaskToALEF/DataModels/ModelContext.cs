using Microsoft.EntityFrameworkCore;
using TestTaskToALEF.Models;

namespace TestTaskToALEF.DataModels
{
    public class ModelContext : DbContext
    {
        public ModelContext(DbContextOptions<ModelContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Model> models { get; set; }
    }
}
