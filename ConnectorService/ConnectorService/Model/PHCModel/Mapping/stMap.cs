using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace ConnectorService.Model.PHCModel.Mapping
{
    public class StMap:EntityTypeConfiguration<St>
    {
        public StMap()
        {
            HasKey(t => new { t.StReferencia });

            //properties
            Property(t => t.Ststamp)
                .HasMaxLength(25)
                .IsRequired();
            
            Property(t => t.StReferencia)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            
            Property(t => t.Design)
                .HasMaxLength(60)
                .IsRequired();

            Property(t => t.Familia)
                .IsRequired()
                .HasMaxLength(18);

            Property(t => t.Forref)
                .HasMaxLength(20)
                .IsRequired();

            Property(t => t.Fornecedor)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Desc3)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Desc2)
               .IsRequired()
               .HasMaxLength(60);

            Property(t => t.Desc1)
               .IsRequired()
               .HasMaxLength(60);

            Property(t => t.Usr1)
                .HasMaxLength(20)
                .IsRequired();

            Property(t => t.Pcmoe)
                .IsRequired()
                .HasMaxLength(3);

            Property(t => t.Unidade)
                .HasMaxLength(4)
                .IsRequired();
            //ver tamanho
            Property(t => t.Local)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Obs)
                .IsRequired()
                .HasMaxLength(68);

            Property(t => t.Codigo)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Uni2)
                .IsRequired()
                .HasMaxLength(2);

            Property(t => t.Imagem)
                .IsRequired()
                .HasMaxLength(120);

            Property(t => t.Containv)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Contacev)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Contareo)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Contacoe)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Desc4)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Desc5)
               .IsRequired()
               .HasMaxLength(60);

            Property(t => t.Desc6)
               .IsRequired()
               .HasMaxLength(60);

            Property(t => t.Faminome)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Usr3)
                .IsRequired()
                .HasMaxLength(35);

            Property(t => t.Usr4)
               .IsRequired()
               .HasMaxLength(35);

            Property(t => t.Usr5)
               .IsRequired()
               .HasMaxLength(35);

            Property(t => t.Tipodesc)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Usr6)
                .IsRequired()
                .HasMaxLength(3);

            Property(t => t.Nccod)
                .IsRequired()
                .HasMaxLength(18);

            Property(t => t.Url)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.Codfiscal)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Iecaref)
                .IsRequired()
                .HasMaxLength(18);

            Property(t => t.Iecarefnome)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Txieca)
                .IsRequired()
                .HasMaxLength(18);
            Property(t => t.Txiecanome)
                .IsRequired()
                .HasMaxLength(115);

            Property(t => t.Iecautt)
                .IsRequired()
                .HasMaxLength(4);

            Property(t => t.Site)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Txtqlook)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.Imgqlook)
                .IsRequired()
                .HasMaxLength(120);

            Property(t => t.Lang1)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Langdes1)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Lang2)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Langdes2)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Lang3)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Langdes3)
                .HasMaxLength(60)
                .IsRequired();

            Property(t => t.Lang4)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Langdes4)
                .HasMaxLength(60)
                .IsRequired();

            Property(t => t.Lang5)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Langdes5)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Statuspda)
                .IsRequired()
                .HasMaxLength(1);

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

            Property(t => t.Contaieo)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Refmo)
                .IsRequired()
                .HasMaxLength(18);

            Property(t => t.Descrmo)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Ofcstamp)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Unidadef)
                .IsRequired()
                .HasMaxLength(4);
            Property(t => t.Horanovpv)
                .IsRequired()
                .HasMaxLength(5);

            Property(t => t.Tkhclass)
                .IsRequired()
                .HasMaxLength(3);

            Property(t => t.UStrt)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Restctprep)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Idudesign)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Orcrefext)
                .IsRequired()
                
                .HasMaxLength(20);

            //
            ToTable("st");
            Property(t => t.Ststamp).HasColumnName("ststamp");
            Property(t => t.StReferencia).HasColumnName("ref");
            Property(t => t.Design).HasColumnName("design");
            Property(t => t.Familia).HasColumnName("familia");
            Property(t => t.Stock).HasColumnName("stock");
            Property(t => t.Epv1).HasColumnName("epv1");
            Property(t => t.Pv1).HasColumnName("pv1");
            Property(t => t.Forref).HasColumnName("forref");
            Property(t => t.Amostra).HasColumnName("amostra");
            Property(t => t.Baixr).HasColumnName("baixr");
            Property(t => t.Bloqueado).HasColumnName("bloqueado");
            Property(t => t.Cancpos).HasColumnName("cancpos");
            Property(t => t.Cbbno).HasColumnName("cbbno");
            Property(t => t.Clinica).HasColumnName("clinica");
            Property(t => t.Codcmb).HasColumnName("codcmb");
            Property(t => t.Codfiscal).HasColumnName("codfiscal");
            Property(t => t.Codigo).HasColumnName("codigo");
            Property(t => t.Compnovo).HasColumnName("compnovo");
            Property(t => t.Consumo).HasColumnName("consumo");
            Property(t => t.Contacev).HasColumnName("contacev");
            Property(t => t.Contacoe).HasColumnName("contacoe");
            Property(t => t.Contaieo).HasColumnName("contaieo");
            Property(t => t.Containv).HasColumnName("containv");
            Property(t => t.Contareo).HasColumnName("contareo");
            Property(t => t.Conversao).HasColumnName("conversao");
            Property(t => t.Convunsup).HasColumnName("convunsup");
            Property(t => t.Cpoc).HasColumnName("cpoc");
            Property(t => t.Custo).HasColumnName("custo");
            Property(t => t.Custof).HasColumnName("custof");
            Property(t => t.Custog).HasColumnName("custog");
            Property(t => t.Datanovpv).HasColumnName("datanovpv");
            Property(t => t.Datar).HasColumnName("datar");
            Property(t => t.Desc1).HasColumnName("desc1");
            Property(t => t.Desc2).HasColumnName("desc2");
            Property(t => t.Desc3).HasColumnName("desc3");
            Property(t => t.Desc4).HasColumnName("desc4");
            Property(t => t.Desc5).HasColumnName("desc5");
            Property(t => t.Desc6).HasColumnName("desc6");
            Property(t => t.Desci).HasColumnName("desci");
            Property(t => t.Descii).HasColumnName("descii");
            Property(t => t.Descrmo).HasColumnName("descrmo");
            Property(t => t.Despimp).HasColumnName("despimp");
            Property(t => t.Diaseoq).HasColumnName("diaseoq");
            Property(t => t.Diaspto).HasColumnName("diaspto");
            Property(t => t.Ecoacumulador).HasColumnName("ecoacumulador");
            Property(t => t.Ecoel).HasColumnName("ecoel");
            Property(t => t.Ecoeval).HasColumnName("ecoeval");
            Property(t => t.Ecomissao).HasColumnName("ecomissao");
            Property(t => t.Ecool).HasColumnName("ecool");
            Property(t => t.Ecooval).HasColumnName("ecooval");
            Property(t => t.Ecopilha).HasColumnName("ecopilha");
            Property(t => t.Ecopl).HasColumnName("ecopl");
            Property(t => t.Ecopval).HasColumnName("ecopval");
            Property(t => t.Ecorl).HasColumnName("ecorl");
            Property(t => t.Ecorval).HasColumnName("ecorval");
            Property(t => t.Ecoval).HasColumnName("ecoval");
            Property(t => t.Ecovalor).HasColumnName("ecovalor");
            Property(t => t.Ecusto).HasColumnName("ecusto");
            Property(t => t.Ecustof).HasColumnName("ecustof");
            Property(t => t.Ecustog).HasColumnName("ecustog");
            Property(t => t.Eecoeval).HasColumnName("eecoeval");
            Property(t => t.Eecooval).HasColumnName("eecooval");
            Property(t => t.Eecopval).HasColumnName("eecopval");
            Property(t => t.Eecorval).HasColumnName("eecorval");
            Property(t => t.Eecoval).HasColumnName("eecoval");
            Property(t => t.Eiectin).HasColumnName("eiectin");
            Property(t => t.Eoq).HasColumnName("eoq");
            Property(t => t.Epcdisp).HasColumnName("epcdisp");
            Property(t => t.Epclab).HasColumnName("epclab");
            Property(t => t.Epcmo).HasColumnName("epcmo");
            Property(t => t.Epcpond).HasColumnName("epcpond");
            Property(t => t.Epcult).HasColumnName("epcult");
            Property(t => t.Epcusto).HasColumnName("epcusto");
            Property(t => t.Epmvenda).HasColumnName("epmvenda");
            Property(t => t.Epv2).HasColumnName("epv2");
            Property(t => t.Epv3).HasColumnName("epv3");
            Property(t => t.Epv4).HasColumnName("epv4");
            Property(t => t.Epv5).HasColumnName("epv5");
            Property(t => t.Epvcon).HasColumnName("epvcon");
            Property(t => t.Epvultimo).HasColumnName("epvultimo");
            Property(t => t.Faminome).HasColumnName("faminome");
            Property(t => t.Fobloq).HasColumnName("fobloq");
            Property(t => t.Fornec).HasColumnName("fornec");
            Property(t => t.Fornecedor).HasColumnName("fornecedor");
            Property(t => t.Fornestab).HasColumnName("fornestab");
            Property(t => t.Garantia).HasColumnName("garantia");
            Property(t => t.Horanovpv).HasColumnName("horanovpv");
            Property(t => t.Idudesign).HasColumnName("idudesign");
            Property(t => t.Iecagrad).HasColumnName("iecagrad");
            Property(t => t.Iecaisref).HasColumnName("iecaisref");
            Property(t => t.Iecamultgrad).HasColumnName("iecamultgrad");
            Property(t => t.Iecaref).HasColumnName("iecaref");
            Property(t => t.Iecarefnome).HasColumnName("iecarefnome");
            Property(t => t.Iecasug).HasColumnName("iecasug");
            Property(t => t.Iecautt).HasColumnName("iecautt");
            Property(t => t.Iectin).HasColumnName("iectin");
            Property(t => t.Iectinii).HasColumnName("iectinii");
            Property(t => t.Iectsug).HasColumnName("iectsug");
            Property(t => t.Imagem).HasColumnName("imagem");
            Property(t => t.Imgqlook).HasColumnName("imgqlook");
            Property(t => t.Impfuelpos).HasColumnName("impfuelpos");
            Property(t => t.Inactivo).HasColumnName("inactivo");
            Property(t => t.Iva1Incl).HasColumnName("iva1incl");
            Property(t => t.Iva2Incl).HasColumnName("iva2incl");
            Property(t => t.Iva3Incl).HasColumnName("iva3incl");
            Property(t => t.Iva4Incl).HasColumnName("iva4incl");
            Property(t => t.Iva5Incl).HasColumnName("iva5incl");
            Property(t => t.Ivaincl).HasColumnName("ivaincl");
            Property(t => t.Ivapcincl).HasColumnName("ivapcincl");
            Property(t => t.Lang1).HasColumnName("lang1");
            Property(t => t.Lang2).HasColumnName("lang2");
            Property(t => t.Lang3).HasColumnName("lang3");
            Property(t => t.Lang4).HasColumnName("lang4");
            Property(t => t.Lang5).HasColumnName("lang5");
            Property(t => t.Langdes1).HasColumnName("langdes1");
            Property(t => t.Langdes2).HasColumnName("langdes2");
            Property(t => t.Langdes3).HasColumnName("langdes3");
            Property(t => t.Langdes4).HasColumnName("langdes4");
            Property(t => t.Langdes5).HasColumnName("langdes5");
            Property(t => t.Local).HasColumnName("local");
            Property(t => t.Marcada).HasColumnName("marcada");
            Property(t => t.Marg1).HasColumnName("marg1");
            Property(t => t.Marg2).HasColumnName("marg2");
            Property(t => t.Marg3).HasColumnName("marg3");
            Property(t => t.Marg4).HasColumnName("marg4");
            Property(t => t.Marg5).HasColumnName("marg5");
            Property(t => t.Massaliq).HasColumnName("massaliq");
            Property(t => t.Mesescon).HasColumnName("mesescon");
            Property(t => t.Mfornec).HasColumnName("mfornec");
            Property(t => t.Mfornec2).HasColumnName("mfornec2");
            Property(t => t.Mod).HasColumnName("mod");
            Property(t => t.Nccod).HasColumnName("nccod");
            Property(t => t.Nexist).HasColumnName("nexist");
            Property(t => t.Noserie).HasColumnName("noserie");
            Property(t => t.Notimpcp).HasColumnName("notimpcp");
            Property(t => t.Nsujpp).HasColumnName("nsujpp");
            Property(t => t.Obs).HasColumnName("obs");
            Property(t => t.Ofcstamp).HasColumnName("ofcstamp");
            Property(t => t.Opendata).HasColumnName("opendata");
            Property(t => t.Orcamento).HasColumnName("orcamento");
            Property(t => t.Orcrefext).HasColumnName("orcrefext");
            Property(t => t.Ousrdata).HasColumnName("ousrdata");
            Property(t => t.Ousrhora).HasColumnName("ousrhora");
            Property(t => t.Ousrinis).HasColumnName("ousrinis");
            Property(t => t.Pbruto).HasColumnName("pbruto");
            Property(t => t.Pcdisp).HasColumnName("pcdisp");
            Property(t => t.Pcimp).HasColumnName("pcimp");
            Property(t => t.Pclab).HasColumnName("pclab");
            Property(t => t.Pcmo).HasColumnName("pcmo");
            Property(t => t.Pcmoe).HasColumnName("pcmoe");
            Property(t => t.Pcpond).HasColumnName("pcpond");
            Property(t => t.Pcult).HasColumnName("pcult");
            Property(t => t.Pcusto).HasColumnName("pcusto");
            Property(t => t.Pentrega).HasColumnName("pentrega");
            Property(t => t.Peso).HasColumnName("peso");
            Property(t => t.Pmvenda).HasColumnName("pmvenda");
            Property(t => t.Ptoenc).HasColumnName("ptoenc");
            Property(t => t.Pv2).HasColumnName("pv2");
            Property(t => t.Pv3).HasColumnName("pv3");
            Property(t => t.Pv4).HasColumnName("pv4");
            Property(t => t.Pvcon).HasColumnName("pvcon");
            Property(t => t.Pvultimo).HasColumnName("pvultimo");
            Property(t => t.Qlook).HasColumnName("qlook");
            Property(t => t.Qttacin).HasColumnName("qttacin");
            Property(t => t.Qttacout).HasColumnName("qttacout");
            Property(t => t.Qttcat).HasColumnName("qttcat");
            Property(t => t.Qttcli).HasColumnName("qttcli");
            Property(t => t.Qttesp).HasColumnName("qttesp");
            Property(t => t.Qttfor).HasColumnName("qttfor");
            Property(t => t.Qttrec).HasColumnName("qttrec");
            Property(t => t.Qtttouch).HasColumnName("qtttouch");
            Property(t => t.Qttvend).HasColumnName("qttvend");
            Property(t => t.Refmo).HasColumnName("refmo");
            Property(t => t.Restctprep).HasColumnName("restctprep");
            Property(t => t.Semserprv).HasColumnName("semserprv");
            Property(t => t.Site).HasColumnName("site");
            Property(t => t.Statuspda).HasColumnName("statuspda");
            Property(t => t.Stid).HasColumnName("stid");
            Property(t => t.Stmax).HasColumnName("stmax");
            Property(t => t.Stmin).HasColumnName("stmin");
            Property(t => t.Stns).HasColumnName("stns");
            Property(t => t.Stock).HasColumnName("stock");
            Property(t => t.Stocktch).HasColumnName("stocktch");
            Property(t => t.Sujinv).HasColumnName("sujinv");
            Property(t => t.Tabiva).HasColumnName("tabiva");
            Property(t => t.Texteis).HasColumnName("texteis");
            Property(t => t.Tipodesc).HasColumnName("tipodesc");
            Property(t => t.Tkhclass).HasColumnName("tkhclass");
            Property(t => t.Txieca).HasColumnName("txieca");
            Property(t => t.Txiecanome).HasColumnName("txiecanome");
            Property(t => t.Txtqlook).HasColumnName("txtqlook");
            Property(t => t.UStrt).HasColumnName("u_strt");
            Property(t => t.Udata).HasColumnName("udata");
            Property(t => t.Uintr).HasColumnName("uintr");
            Property(t => t.Uni2).HasColumnName("uni2");
            Property(t => t.Unidade).HasColumnName("unidade");
            Property(t => t.Unidadef).HasColumnName("unidadef");
            Property(t => t.Url).HasColumnName("url");
            Property(t => t.Usaid).HasColumnName("usaid");
            Property(t => t.Usalote).HasColumnName("usalote");
            Property(t => t.Usr1).HasColumnName("usr1");
            Property(t => t.Usr2).HasColumnName("usr2");
            Property(t => t.Usr3).HasColumnName("usr3");
            Property(t => t.Usr4).HasColumnName("usr4");
            Property(t => t.Usr5).HasColumnName("usr5");
            Property(t => t.Usr6).HasColumnName("usr6");
            Property(t => t.Usrdata).HasColumnName("usrdata");
            Property(t => t.Usrhora).HasColumnName("usrhora");
            Property(t => t.Usrinis).HasColumnName("usrinis");
            Property(t => t.Usrqtt).HasColumnName("usrqtt");
            Property(t => t.Vaiwww).HasColumnName("vaiwww");
            Property(t => t.Validade).HasColumnName("validade");
            Property(t => t.Valin).HasColumnName("valin");
            Property(t => t.Valout).HasColumnName("valout");
            Property(t => t.Vasilhame).HasColumnName("vasilhame");
            Property(t => t.Volume).HasColumnName("volume");
            
            //continuar a partir do u alterar a query na classe servico para omitir inactivos/bloqueado/ stock>0
        }
    }
}