using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace ConnectorService.Model.PHCModel.Mapping
{
    public class TaxasivaMap:EntityTypeConfiguration<Taxasiva>
    {
        public TaxasivaMap()
        {
            // Primary Key
            HasKey(t => new { t.Codigo});
            

            //Properties
            Property(t => t.Taxasivastamp)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Codigo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Ousrinis)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.Ousrhora)
                .IsRequired()
                .HasMaxLength(8);
            Property(t => t.Usrinis)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.Usrhora)
                .IsRequired()
                .HasMaxLength(8);
            //

            //table & column mappings
            ToTable("taxasiva");
            Property(t => t.Codigo).HasColumnName("codigo");
            Property(t => t.Marcada).HasColumnName("marcada");
            Property(t => t.Ousrdata).HasColumnName("ousrdata");
            Property(t => t.Ousrinis).HasColumnName("ousrinis");
            Property(t => t.Taxa).HasColumnName("taxa");
            Property(t => t.Taxasivastamp).HasColumnName("taxasivastamp");
            Property(t => t.Usrdata).HasColumnName("usrdata");
            Property(t => t.Usrhora).HasColumnName("usrhora");
            Property(t => t.Usrinis).HasColumnName("usrinis");
            //
        }
    }
}