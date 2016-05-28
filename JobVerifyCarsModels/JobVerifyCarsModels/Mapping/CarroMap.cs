using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using JobVerifyCarsModels.Model;

namespace JobVerifyCarsModels.Mapping
{
    public class CarroMap : EntityTypeConfiguration<Carro>
    {
        public CarroMap()
        {
            // Primary Key
            this.HasKey(t => t.CarroId);

            Property(x => x.CarroId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Carro");
            this.Property(t => t.CarroId).HasColumnName("CarroId");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.MontadoraId).HasColumnName("MontadoraId");

        }
    }
}