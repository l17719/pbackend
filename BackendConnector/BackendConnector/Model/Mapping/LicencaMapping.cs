using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
namespace BackendConnector.Model.Mapping
{
    public class LicencaMapping:EntityTypeConfiguration<Licenca>
    {
        public LicencaMapping()
        {
            HasKey(t => new {t.Id});
            //

            //properties
            Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasMaxLength(50);

            Property(t => t.MailCliente)
                .IsRequired()
                .HasMaxLength(150);
            Property(t => t.SerialCliente)
                .IsRequired()
                .HasMaxLength(150);
            //
            ToTable("TbLicenca");
            Property(t => t.Id).HasColumnName("ID");
            Property(t => t.KeyIsValid).HasColumnName("KeyIsValid");
            Property(t => t.MailCliente).HasColumnName("MailCliente");
            Property(t => t.SerialCliente).HasColumnName("SerialKeyCliente");
        }
    }
}