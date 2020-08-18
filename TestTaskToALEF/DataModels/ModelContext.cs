using Microsoft.EntityFrameworkCore;

namespace TestTaskToALEF.DataModels
{
    public class ModelContext : DbContext
    {
        public ModelContext(DbContextOptions<ModelContext> options):base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ModelData>().HasData(new ModelData { Id = 1, Value = "066", Name = "Vodafone" });
            modelBuilder.Entity<ModelData>().HasData(new ModelData { Id = 2, Value = "093", Name = "Lifecell" });
        }

        public DbSet<ModelData> Models { get; set; }
    }
}
