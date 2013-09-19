using System.Data.Entity.ModelConfiguration;

namespace ConnectorService.Model.PHCModel.Mapping
{
    public class Bi2Map : EntityTypeConfiguration<Bi2>
    {
        public Bi2Map()
        {
            // Primary Key
            HasKey( t=> new {t.Bi2Stamp});

            // Properties
            Property(t => t.Bi2Stamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Precatstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Lobsauto)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Alvstamp1)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Identificacao1)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Szzstamp1)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Zona1)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.Alvstamp2)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Identificacao2)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Szzstamp2)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Zona2)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.Ooobranome)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Oonmdos)
                .IsRequired()
                .HasMaxLength(24);

            Property(t => t.Origbistamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Fnstamp)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Fodocnome)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Foadoc)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Bostamp)
                .IsRequired()
                .IsFixedLength()
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

            Property(t => t.Fistamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Descfx)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(60);

            Property(t => t.Ofcstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Cladrsdesc)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Morada)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Local)
                .IsRequired()
                .HasMaxLength(43);

            Property(t => t.Codpost)
                .IsRequired()
                .HasMaxLength(45);

            Property(t => t.Cladrszona)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Telefone)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Contacto)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(45);

            Property(t => t.Cladrsstamp)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Tkhposlstamp)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Pscmori)
                .IsRequired()
                .HasMaxLength(2);

            Property(t => t.Pscmoridesc)
                .IsRequired()
                .HasMaxLength(70);

            // Table & Column Mappings
            ToTable("bi2");
            Property(t => t.Bi2Stamp).HasColumnName("bi2stamp");
            Property(t => t.Precatstamp).HasColumnName("precatstamp");
            Property(t => t.Qttadj).HasColumnName("qttadj");
            Property(t => t.Qttmedida).HasColumnName("qttmedida");
            Property(t => t.Qttmedidaval).HasColumnName("qttmedidaval");
            Property(t => t.Eqttmedidaval).HasColumnName("eqttmedidaval");
            Property(t => t.Qttmedidaperc).HasColumnName("qttmedidaperc");
            Property(t => t.Tbrmais).HasColumnName("tbrmais");
            Property(t => t.Tbrmaisval).HasColumnName("tbrmaisval");
            Property(t => t.Etbrmaisval).HasColumnName("etbrmaisval");
            Property(t => t.Qttapr).HasColumnName("qttapr");
            Property(t => t.Qttaprval).HasColumnName("qttaprval");
            Property(t => t.Eqttaprval).HasColumnName("eqttaprval");
            Property(t => t.Qttnoapr).HasColumnName("qttnoapr");
            Property(t => t.Qttnoaprval).HasColumnName("qttnoaprval");
            Property(t => t.Eqttnoaprval).HasColumnName("eqttnoaprval");
            Property(t => t.Tbrmenos).HasColumnName("tbrmenos");
            Property(t => t.Tbrmenosval).HasColumnName("tbrmenosval");
            Property(t => t.Etbrmenosval).HasColumnName("etbrmenosval");
            Property(t => t.Qttfalta).HasColumnName("qttfalta");
            Property(t => t.Qttfaltaval).HasColumnName("qttfaltaval");
            Property(t => t.Eqttfaltaval).HasColumnName("eqttfaltaval");
            Property(t => t.Qttnew).HasColumnName("qttnew");
            Property(t => t.Valnew).HasColumnName("valnew");
            Property(t => t.Evalnew).HasColumnName("evalnew");
            Property(t => t.Percnew).HasColumnName("percnew");
            Property(t => t.Noaprov).HasColumnName("noaprov");
            Property(t => t.Lobsauto).HasColumnName("lobsauto");
            Property(t => t.Qtttbrmais).HasColumnName("qtttbrmais");
            Property(t => t.Qtttbrmenos).HasColumnName("qtttbrmenos");
            Property(t => t.Qttnew2).HasColumnName("qttnew2");
            Property(t => t.Noaprov2).HasColumnName("noaprov2");
            Property(t => t.Alvstamp1).HasColumnName("alvstamp1");
            Property(t => t.Identificacao1).HasColumnName("identificacao1");
            Property(t => t.Szzstamp1).HasColumnName("szzstamp1");
            Property(t => t.Zona1).HasColumnName("zona1");
            Property(t => t.Alvstamp2).HasColumnName("alvstamp2");
            Property(t => t.Identificacao2).HasColumnName("identificacao2");
            Property(t => t.Szzstamp2).HasColumnName("szzstamp2");
            Property(t => t.Zona2).HasColumnName("zona2");
            Property(t => t.Qttcompra).HasColumnName("qttcompra");
            Property(t => t.Qttenc).HasColumnName("qttenc");
            Property(t => t.Ooobranome).HasColumnName("ooobranome");
            Property(t => t.Ooobrano).HasColumnName("ooobrano");
            Property(t => t.Ooboano).HasColumnName("ooboano");
            Property(t => t.Oonmdos).HasColumnName("oonmdos");
            Property(t => t.Origbistamp).HasColumnName("origbistamp");
            Property(t => t.Desemb).HasColumnName("desemb");
            Property(t => t.Fnstamp).HasColumnName("fnstamp");
            Property(t => t.Fodocnome).HasColumnName("fodocnome");
            Property(t => t.Foadoc).HasColumnName("foadoc");
            Property(t => t.Semserprv).HasColumnName("semserprv");
            Property(t => t.Bostamp).HasColumnName("bostamp");
            Property(t => t.Ousrinis).HasColumnName("ousrinis");
            Property(t => t.Ousrdata).HasColumnName("ousrdata");
            Property(t => t.Ousrhora).HasColumnName("ousrhora");
            Property(t => t.Usrinis).HasColumnName("usrinis");
            Property(t => t.Usrdata).HasColumnName("usrdata");
            Property(t => t.Usrhora).HasColumnName("usrhora");
            Property(t => t.Marcada).HasColumnName("marcada");
            Property(t => t.Fistamp).HasColumnName("fistamp");
            Property(t => t.Aviado).HasColumnName("aviado");
            Property(t => t.Temfx).HasColumnName("temfx");
            Property(t => t.Descfx).HasColumnName("descfx");
            Property(t => t.Ofcstamp).HasColumnName("ofcstamp");
            Property(t => t.Cladrsdesc).HasColumnName("cladrsdesc");
            Property(t => t.Morada).HasColumnName("morada");
            Property(t => t.Local).HasColumnName("local");
            Property(t => t.Codpost).HasColumnName("codpost");
            Property(t => t.Cladrszona).HasColumnName("cladrszona");
            Property(t => t.Telefone).HasColumnName("telefone");
            Property(t => t.Contacto).HasColumnName("contacto");
            Property(t => t.Email).HasColumnName("email");
            Property(t => t.Cladrsstamp).HasColumnName("cladrsstamp");
            Property(t => t.Tkhpmp).HasColumnName("tkhpmp");
            Property(t => t.Tkhcodcmb).HasColumnName("tkhcodcmb");
            Property(t => t.Tkhposlstamp).HasColumnName("tkhposlstamp");
            Property(t => t.EftaxamtA).HasColumnName("eftaxamt_a");
            Property(t => t.EftaxamtB).HasColumnName("eftaxamt_b");
            Property(t => t.FtaxamtA).HasColumnName("ftaxamt_a");
            Property(t => t.FtaxamtB).HasColumnName("ftaxamt_b");
            Property(t => t.Pscmori).HasColumnName("pscmori");
            Property(t => t.Pscmoridesc).HasColumnName("pscmoridesc");
            Property(t => t.Mcomercial).HasColumnName("mcomercial");
            Property(t => t.Usamcomercial).HasColumnName("usamcomercial");
            Property(t => t.Qttatrib).HasColumnName("qttatrib");
            //Property(t => t.Qttorcamento).HasColumnName("qttorcamento");
            //Property(t => t.Ecustoindorcamento).HasColumnName("ecustoindorcamento");
            //Property(t => t.Custoindorcamento).HasColumnName("custoindorcamento");
            //Property(t => t.Ecustototalorcamento).HasColumnName("ecustototalorcamento");
            //Property(t => t.Custototalorcamento).HasColumnName("custototalorcamento");
            //Property(t => t.Emargemorcamento).HasColumnName("emargemorcamento");
            //Property(t => t.Margemorcamento).HasColumnName("margemorcamento");
            //Property(t => t.Qttdif).HasColumnName("qttdif");
            //Property(t => t.Ecustoinddif).HasColumnName("ecustoinddif");
            //Property(t => t.Custoinddif).HasColumnName("custoinddif");
            //Property(t => t.Ecustototaldif).HasColumnName("ecustototaldif");
            //Property(t => t.Custototaldif).HasColumnName("custototaldif");
            //Property(t => t.Emargemdif).HasColumnName("emargemdif");
            //Property(t => t.Margemdif).HasColumnName("margemdif");
            //Property(t => t.Qttdifperc).HasColumnName("qttdifperc");
            //Property(t => t.Custoinddifperc).HasColumnName("custoinddifperc");
            //Property(t => t.Custototaldifperc).HasColumnName("custototaldifperc");
        }
    }
}