using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace ConnectorService.Model.PHCModel.Mapping
{
    public class StobsMap:EntityTypeConfiguration<Stobs>
    {
        public StobsMap()
        {
            HasKey(t => t.StobsRef);

            Property(t => t.Stobsstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.StobsRef)
                .HasMaxLength(18)
                .IsRequired()
                .IsFixedLength()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Ousrinis)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            Property(t => t.Ousrhora)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            Property(t => t.Docdescription)
                .IsRequired();

            Property(t => t.Btnfont)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            Property(t => t.Txtord)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(60);

            Property(t => t.Motiseimp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(60);

            Property(t => t.Codmotiseimp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            ToTable("stobs");
            Property(t => t.Stobsstamp).HasColumnName("stobsstamp");
            Property(t => t.StobsRef).HasColumnName("ref");
            Property(t => t.StobsObs).HasColumnName("stobs");
            Property(t => t.Ousrinis).HasColumnName("ousrinis");
            Property(t => t.Ousrdata).HasColumnName("ousrdata");
            Property(t => t.Ousrhora).HasColumnName("ousrhora");
            Property(t => t.Usrinis).HasColumnName("usrinis");
            Property(t => t.Usrdata).HasColumnName("usrdata");
            Property(t => t.Usrhora).HasColumnName("usrhora");
            Property(t => t.Marcada).HasColumnName("marcada");
            Property(t => t.Docdescription).HasColumnName("docdescription");
            Property(t => t.Lepeso).HasColumnName("lepeso");
            Property(t => t.Precotouch).HasColumnName("precotouch");
            Property(t => t.Pvverificador).HasColumnName("pvverificador");
            Property(t => t.Objusacor).HasColumnName("objusacor");
            Property(t => t.Objcolor).HasColumnName("objcolor");
            Property(t => t.Objusacortit).HasColumnName("objusacortit");
            Property(t => t.Objusacorval).HasColumnName("objusacorval");
            Property(t => t.Objcorval).HasColumnName("objcorval");
            Property(t => t.Objusacortec).HasColumnName("objusacortec");
            Property(t => t.Objcortec).HasColumnName("objcortec");
            Property(t => t.Objmudafonte).HasColumnName("objmudafonte");
            Property(t => t.Btnfont).HasColumnName("btnfont");
            Property(t => t.Btnfontsize).HasColumnName("btnfontsize");
            Property(t => t.Btnfontbold).HasColumnName("btnfontbold");
            Property(t => t.Btnfontitalic).HasColumnName("btnfontitalic");
            Property(t => t.Objcortit).HasColumnName("objcortit");
            Property(t => t.Txtord).HasColumnName("txtord");
            Property(t => t.Usafefo).HasColumnName("usafefo");
            Property(t => t.Motiseimp).HasColumnName("motiseimp");
            Property(t => t.Codmotiseimp).HasColumnName("codmotiseimp");



        }
    }
}
