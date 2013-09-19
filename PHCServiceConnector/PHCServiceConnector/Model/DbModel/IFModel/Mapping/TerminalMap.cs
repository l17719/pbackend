using System.Data.Entity.ModelConfiguration;

namespace PHCServiceConnector.Model.DbModel.IFModel.Mapping
{
    public class TerminalMap : EntityTypeConfiguration<Terminais>
    {
        public TerminalMap()
        {
            // Primary Key
            HasKey(t => t.IDTerminal);

            // Properties
            Property(t => t.NumPda)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.MacAddress3G)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.MacAddressWireless)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("TbTerminal");
            Property(t => t.IDTerminal).HasColumnName("IDTerminal");
            Property(t => t.FkIdot).HasColumnName("FkIDOT");
            Property(t => t.NumPda).HasColumnName("NumPda");
            Property(t => t.MacAddress3G).HasColumnName("MacAddress3G");
            Property(t => t.MacAddressWireless).HasColumnName("MacAddressWireless");
            Property(t => t.TerminalAccessKey).HasColumnName("TerminalAccessKey");

            // Relationships
            HasRequired(t => t.ListaOpcoesTerminal)
                .WithMany(t => t.ListaTerminais)
                .HasForeignKey(d => d.FkIdot);
        }
    }
}