using System.Data.Entity.ModelConfiguration;

namespace BackEndAplication.Models.PHCDBModel.Mapping
{
    public class FltstMap : EntityTypeConfiguration<Fltst>
    {
        public FltstMap()
        {
            HasKey(t => t.Stamp);

            //properties
            Property(t => t.Fltststamp)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Ftitulo)
                .IsRequired()
                .HasMaxLength(50);

            //ver campo texto e xbase
            Property(t => t.Texto)
                .IsRequired();

            Property(t => t.Xbase)
                .IsRequired();
            //
            Property(t => t.Stamp)
                .IsRequired()
                .HasMaxLength(25);

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

            //table & column mappings
            ToTable("dbo.fltst");
            Property(t => t.Altera).HasColumnName("altera");
            Property(t => t.Fltststamp).HasColumnName("fltststamp");
            Property(t => t.Ftitulo).HasColumnName("ftitulo");
            Property(t => t.Marcada).HasColumnName("marcada");
            Property(t => t.Ousrdata).HasColumnName("ousrdata");
            Property(t => t.Ousrhora).HasColumnName("ousrhora");
            Property(t => t.Ousrinis).HasColumnName("ousrinis");
            Property(t => t.Privado).HasColumnName("privado");
            Property(t => t.Stamp).HasColumnName("stamp");
            Property(t => t.Temvar).HasColumnName("temvar");
            Property(t => t.Texto).HasColumnName("texto");
            Property(t => t.Usrdata).HasColumnName("usrdata");
            Property(t => t.Usrhora).HasColumnName("usrhora");
            Property(t => t.Usrinis).HasColumnName("usrinis");
            Property(t => t.Xbase).HasColumnName("xbase");
        }
    }
}