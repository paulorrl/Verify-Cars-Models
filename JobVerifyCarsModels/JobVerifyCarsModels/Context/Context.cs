using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using JobVerifyCarsModels.Mapping;
using JobVerifyCarsModels.Model;

namespace JobVerifyCarsModels.Context
{
    public class Context : DbContext
    {
        public Context()
            : base("AutoContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Carro> Carros { get; set; }

        public DbSet<AnoModeloCarro> AnoModeloCarros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new AnoModeloCarroMap());
            modelBuilder.Configurations.Add(new CarroMap());
        }
    }
}