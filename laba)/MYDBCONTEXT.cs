using System.Data.Entity;

namespace laba_
{
    public class MYDBCONTEXT : DbContext
    {
        public MYDBCONTEXT() : base("DbConnectionString")
        {
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Tires> Tires { get; set; }
    }
}
