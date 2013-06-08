using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace ConnectorService.Model.PHCModel.Mapping
{
    public class PnMap : EntityTypeConfiguration<Pn>
    {
        public PnMap()
        {
            HasKey(t => t.Pnstamp);

            Property(t => t.Pnstamp)
                .HasMaxLength(25)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Ref)
                .IsRequired()
                .HasMaxLength(18);

            Property(t => t.Design)
                .IsRequired()
                .HasMaxLength(18);

            Property(t => t.Nmdoc)
                .IsRequired()
                .HasMaxLength(20);
            Property(t => t.Origem).IsRequired()
                .HasMaxLength(2);

            Property(t => t.Obs)
                .IsRequired()
                .HasMaxLength(70);

            Property(t => t.Usr1)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Usr2)
               .IsRequired()
               .HasMaxLength(20);

            Property(t => t.Usr3)
               .IsRequired()
               .HasMaxLength(35);

            Property(t => t.Usr4)
               .IsRequired()
               .HasMaxLength(20);

            Property(t => t.Usr5)
               .IsRequired()
               .HasMaxLength(120);


            Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Zona)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Fref)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Ccusto)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.NCusto)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Segmento)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Familia)
                .IsRequired()
                .HasMaxLength(18);

            Property(t => t.Tipo)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Vendnm)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Fistamp)
                .IsRequired()
                .HasMaxLength(25);
            
            Property(t => t.Ftstamp)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Snstamp)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Cor)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Tam)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Lote)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.Classe)
                .IsRequired()
                .HasMaxLength(30);

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
            Property(t => t.Area)
                .IsRequired()
                .HasMaxLength(20);

            ToTable("pn");
            Property(t => t.Pnstamp).HasColumnName("pnstamp");
            Property(t => t.Ref).HasColumnName("ref");
            Property(t => t.Design).HasColumnName("design");
            Property(t => t.Fdata).HasColumnName("fdata");
            Property(t => t.Nmdoc).HasColumnName("nmdoc");
            Property(t => t.Fno).HasColumnName("fno");
            Property(t => t.Qtt).HasColumnName("qtt");
            Property(t => t.Pv).HasColumnName("pv");
            Property(t => t.Epv).HasColumnName("epv");
            Property(t => t.Tiliquido).HasColumnName("tiliquido");
            Property(t => t.Etiliquido).HasColumnName("etiliquido");
            Property(t => t.Pcusto).HasColumnName("pcusto");
            Property(t => t.Epcusto).HasColumnName("epcusto");
            Property(t => t.Proces).HasColumnName("proces");
            Property(t => t.Iva).HasColumnName("iva");
            Property(t => t.Tcusto).HasColumnName("tcusto");
            Property(t => t.TabIva).HasColumnName("tabiva");
            Property(t => t.Origem).HasColumnName("origem");
            Property(t => t.Ecomissao).HasColumnName("ecomissao");
            Property(t => t.Cpoc).HasColumnName("cpoc");
            Property(t => t.Extracom).HasColumnName("extracom");
            Property(t => t.Pago).HasColumnName("pago");
            Property(t => t.Pdata).HasColumnName("pdata");
            Property(t => t.Vendedor).HasColumnName("vendedor");
            Property(t => t.Obs).HasColumnName("obs");
            Property(t => t.Usr1).HasColumnName("usr1");
            Property(t => t.Usr2).HasColumnName("usr2");
            Property(t => t.Usr3).HasColumnName("usr3");
            Property(t => t.Usr4).HasColumnName("usr4");
            Property(t => t.Usr5).HasColumnName("usr5");
            Property(t => t.No).HasColumnName("no");
            Property(t => t.Nome).HasColumnName("nome");
            Property(t => t.Pctdesc).HasColumnName("pctdesc");
            Property(t => t.Valbase).HasColumnName("valbase");
            Property(t => t.Valuni).HasColumnName("valuni");
            Property(t => t.Zona).HasColumnName("zona");
            Property(t => t.DataInstal).HasColumnName("datainstal");
            Property(t => t.Fref).HasColumnName("fref");
            Property(t => t.Ccusto).HasColumnName("ccusto");
            Property(t => t.NCusto).HasColumnName("ncusto");
            Property(t => t.Segmento).HasColumnName("segmento");
            Property(t => t.Familia).HasColumnName("familia");
            Property(t => t.Tipo).HasColumnName("tipo");
            Property(t => t.Etcusto).HasColumnName("etcusto");
            Property(t => t.Eextracom).HasColumnName("eextracom");
            Property(t => t.Evalbase).HasColumnName("evalbase");
            Property(t => t.Evaluni).HasColumnName("evaluni");
            Property(t => t.Vendnm).HasColumnName("vendnm");
            Property(t => t.Estab).HasColumnName("estab");
            Property(t => t.Fistamp).HasColumnName("fistamp");
            Property(t => t.Ftstamp).HasColumnName("ftstamp");
            Property(t => t.Valorproc).HasColumnName("valorproc");
            Property(t => t.Evalorproc).HasColumnName("evalorproc");
            Property(t => t.Snstamp).HasColumnName("snstamp");
            Property(t => t.Texteis).HasColumnName("texteis");
            Property(t => t.Cor).HasColumnName("cor");
            Property(t => t.Tam).HasColumnName("tam");
            Property(t => t.Usalote).HasColumnName("usalote");
            Property(t => t.Lote).HasColumnName("lote");
            Property(t => t.Num1).HasColumnName("num1");
            Property(t => t.Classe).HasColumnName("classe");
            Property(t => t.Ousrinis).HasColumnName("ousrinis");
            Property(t => t.Ousrdata).HasColumnName("ousrdata");
            Property(t => t.Ousrhora).HasColumnName("ousrhora");
            Property(t => t.Usrinis).HasColumnName("usrinis");
            Property(t => t.Usrdata).HasColumnName("usrdata");
            Property(t => t.Usrhora).HasColumnName("usrhora");
            Property(t => t.Marcada).HasColumnName("marcada");
            Property(t => t.Area).HasColumnName("area");

        }
    }
}