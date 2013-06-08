using System.Data.Entity.ModelConfiguration;

namespace BackEndAplication.Models.PHCDBModel.Mapping
{
    public class UsMap : EntityTypeConfiguration<Us>
    {
        public UsMap()
        {
            HasKey(t => t.Userno);

            Property(t => t.Usstamp).IsRequired()
                .HasMaxLength(25);

            Property(t => t.Iniciais)
                .IsRequired()
                .HasMaxLength(3);
            Property(t => t.Usercode)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Username)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.Grupo)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Dpt)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Ugstamp)
                .IsRequired()
                .HasMaxLength(25);


            Property(t => t.Pwautent)
                .IsRequired()
                .HasMaxLength(5);

            Property(t => t.Tecnnm)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.Vendnm)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.Smsemail)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.Aextpw)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Pwpos)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Empregado)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Pestamp)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Profission)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Vsstamp)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Clbnome)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Clbstamp)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Drnome).IsRequired()
                .HasMaxLength(55);

            Property(t => t.Drstamp)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Nivelaprovacao)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Idioma)
                .IsRequired()
                .HasMaxLength(40);

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

            Property(t => t.Imagem)
                .IsRequired()
                .HasMaxLength(120);

            Property(t => t.Tlmvl)
                .IsRequired()
                .HasMaxLength(45);

            Property(t => t.Susername)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.Centrolog)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Area)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Bwspw)
                .IsRequired()
                .HasMaxLength(32);

            Property(t => t.Bwscodigo)
                .IsRequired()
                .HasMaxLength(30);


            ToTable("dbo.us");
            Property(t => t.Usstamp).HasColumnName("usstamp");
            Property(t => t.Iniciais).HasColumnName("iniciais");
            Property(t => t.Usercode).HasColumnName("usercode");
            Property(t => t.Username).HasColumnName("username");
            Property(t => t.Userno).HasColumnName("userno");
            Property(t => t.Grupo).HasColumnName("grupo");
            Property(t => t.Dpt).HasColumnName("dpt");
            Property(t => t.Ugstamp).HasColumnName("ugstamp");
            Property(t => t.Esa).HasColumnName("esa");
            Property(t => t.Pwautent).HasColumnName("pwautent");
            Property(t => t.Vendedor).HasColumnName("vendedor");
            Property(t => t.Tecnico).HasColumnName("tecnico");
            Property(t => t.Tecnnm).HasColumnName("tecnnm");
            Property(t => t.Vendnm).HasColumnName("vendnm");
            Property(t => t.Email).HasColumnName("email");
            Property(t => t.Smsemail).HasColumnName("smsemail");
            Property(t => t.Aextra).HasColumnName("aextra");
            Property(t => t.Aextpw).HasColumnName("aextpw");
            Property(t => t.Pwpos).HasColumnName("pwpos");
            Property(t => t.Autposmv).HasColumnName("autposmv");
            Property(t => t.Maxposmv).HasColumnName("maxposmv");
            Property(t => t.Emaxposmv).HasColumnName("emaxposmv");
            Property(t => t.Mcdata).HasColumnName("mcdata");
            Property(t => t.Mcmes).HasColumnName("mcmes");
            Property(t => t.Empregado).HasColumnName("empregado");
            Property(t => t.Pestamp).HasColumnName("pestamp");
            Property(t => t.Tipoacd).HasColumnName("tipoacd");
            Property(t => t.Profission).HasColumnName("profission");
            Property(t => t.Vsstamp).HasColumnName("vsstamp");
            Property(t => t.Tipoacdvs).HasColumnName("tipoacdvs");
            Property(t => t.Admdpess).HasColumnName("admdpess");
            Property(t => t.Clbno).HasColumnName("clbno");
            Property(t => t.Clbnome).HasColumnName("clbnome");
            Property(t => t.Clbstamp).HasColumnName("clbstamp");
            Property(t => t.Clbadm).HasColumnName("clbadm");
            Property(t => t.Drno).HasColumnName("drno");
            Property(t => t.Drnome).HasColumnName("drnome");
            Property(t => t.Drstamp).HasColumnName("drstamp");
            Property(t => t.Cliadm).HasColumnName("cliadm");
            Property(t => t.Nivelaprovacao).HasColumnName("nivelaprovacao");
            Property(t => t.Idioma).HasColumnName("idioma");
            Property(t => t.Ousrinis).HasColumnName("ousrinis");
            Property(t => t.Ousrdata).HasColumnName("ousrdata");
            Property(t => t.Ousrhora).HasColumnName("ousrhora");
            Property(t => t.Usrinis).HasColumnName("usrinis");
            Property(t => t.Usrdata).HasColumnName("usrdata");
            Property(t => t.Usrhora).HasColumnName("usrhora");
            Property(t => t.Marcada).HasColumnName("marcada");
            Property(t => t.Imagem).HasColumnName("imagem");
            Property(t => t.Peno).HasColumnName("peno");
            Property(t => t.Tlmvl).HasColumnName("tlmvl");
            Property(t => t.Inactivo).HasColumnName("inactivo");
            Property(t => t.Diasani).HasColumnName("diasani");
            Property(t => t.Diascon).HasColumnName("diascon");
            Property(t => t.Abrecalfis).HasColumnName("abrecalfis");
            Property(t => t.Diascalfis).HasColumnName("diascalfis");
            Property(t => t.Agencalfis).HasColumnName("agencalfis");
            Property(t => t.Suserno).HasColumnName("suserno");
            Property(t => t.Susername).HasColumnName("susername");
            Property(t => t.Centrolog).HasColumnName("centrolog");
            Property(t => t.Nusamntlb).HasColumnName("nusamntlb");
            Property(t => t.Area).HasColumnName("area");
            Property(t => t.Usaarea).HasColumnName("usaarea");
            Property(t => t.Temveriprstock).HasColumnName("temveriprstock");
            Property(t => t.Jaidirecto).HasColumnName("jaidirecto");
            Property(t => t.Usavanc).HasColumnName("usavanc");
            Property(t => t.Bwspw).HasColumnName("bwspw");
            Property(t => t.Bwscodigo).HasColumnName("bwscodigo");
            Property(t => t.Tembws).HasColumnName("tembws");
            Property(t => t.Fazfxmanutencao).HasColumnName("fazfxmanutencao");
            Property(t => t.Jaini).HasColumnName("jaini");
            Property(t => t.Verificachamadas).HasColumnName("verificachamadas");
            Property(t => t.Sgqadm).HasColumnName("sgqadm");
        }
    }
}