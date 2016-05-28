using System.Data.Entity.ModelConfiguration;
using JobVerifyCarsModels.Model;

namespace JobVerifyCarsModels.Mapping
{
    public class AnoModeloCarroMap : EntityTypeConfiguration<AnoModeloCarro>
    {
        public AnoModeloCarroMap()
        {
            // Primary Key
            this.HasKey(t => t.AnoModeloCarroId);

            // Properties
            // Table & Column Mappings
            this.ToTable("AnoModeloCarro");
            this.Property(t => t.AnoModeloCarroId).HasColumnName("AnoModeloCarroId");
            this.Property(t => t.CarroId).HasColumnName("CarroId");
            this.Property(t => t.Ano).HasColumnName("Ano");
        }
    }
}