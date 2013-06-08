using System.Data.Entity.ModelConfiguration;

namespace BackEndAplication.Models.TerminalDBModel.Mapping
{
    public class TbTerminalMap : EntityTypeConfiguration<TbTerminal>
    {
        public TbTerminalMap()
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
            ToTable("dbo.TbTerminal");
            Property(t => t.IDTerminal).HasColumnName("IDTerminal");
            Property(t => t.FkIDOT).HasColumnName("FkIDOT");
            Property(t => t.NumPda).HasColumnName("NumPda");
            Property(t => t.MacAddress3G).HasColumnName("MacAddress3G");
            Property(t => t.MacAddressWireless).HasColumnName("MacAddressWireless");
            Property(t => t.TerminalAccessKey).HasColumnName("TerminalAccessKey");

            // Relationships
            HasRequired(t => t.TbOpcoesTerminal)
                .WithMany(t => t.TbTerminals)
                .HasForeignKey(d => d.FkIDOT);
        }
    }
}