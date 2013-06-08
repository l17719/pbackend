using System.Data.Entity.ModelConfiguration;

namespace ConnectorService.Model.PHCModel.Mapping
{
    public class BiMap:EntityTypeConfiguration<Bi>
    {
        public BiMap()
        {
            // Primary Key
            HasKey(t => t.Bistamp);

            // Properties
            Property(t => t.Bistamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Nmdos)
                .IsRequired()
                .HasMaxLength(24);

            Property(t => t.Referencia)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(18);

            Property(t => t.Design)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Serie)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Nmdoc)
                .IsRequired()
                .HasMaxLength(24);

            Property(t => t.Forref)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Lobs)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Obranome)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Maquina)
                .IsRequired()
                .HasMaxLength(12);

            Property(t => t.Marca)
                .IsRequired()
                .HasMaxLength(12);

            Property(t => t.Zona)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Litem)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Lobs2)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Litem2)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Lobs3)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Lrecno)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Local)
                .IsRequired()
                .HasMaxLength(43);

            Property(t => t.Morada)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Codpost)
                .IsRequired()
                .HasMaxLength(45);

            Property(t => t.Nome)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(55);

            Property(t => t.Vendnm)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Tabela1)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Reff)
                .IsRequired()
                .HasMaxLength(18);

            Property(t => t.Lote)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.Cor)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Tam)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Segmento)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Bofref)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Bifref)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Biserie)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Adoc)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Codigo)
                .IsRequired()
                .HasMaxLength(18);

            Property(t => t.Obistamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Oobistamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

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

            Property(t => t.Usr6)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.Unidade)
                .IsRequired()
                .HasMaxLength(4);

            Property(t => t.Unidad2)
                .IsRequired()
                .HasMaxLength(4);

            Property(t => t.Oftstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Ofostamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Familia)
                .IsRequired()
                .HasMaxLength(18);

            Property(t => t.Nccod)
                .IsRequired()
                .HasMaxLength(13);

            Property(t => t.Ncinteg)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Classifc)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Posic)
                .IsRequired()
                .HasMaxLength(10);

            Property(t => t.Series)
                .IsRequired();

            Property(t => t.Series2)
                .IsRequired();

            Property(t => t.Ccusto)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Ncusto)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Oobostamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Ltab1)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Ltab2)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Ltab3)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Ltab4)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Ltab5)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Fami)
                .IsRequired()
                .HasMaxLength(18);

            Property(t => t.Iecacodisen)
                .IsRequired()
                .HasMaxLength(4);

            Property(t => t.Codfiscal)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Dgeral)
                .IsRequired();

            Property(t => t.Tiposemp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            Property(t => t.Quarto)
                .IsRequired()
                .HasMaxLength(10);

            Property(t => t.Efornecedor)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Optstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Oristamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

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

            // Table & Column Mappings
            ToTable("bi");
            Property(t => t.Bistamp).HasColumnName("bistamp");
            Property(t => t.Nmdos).HasColumnName("nmdos");
            Property(t => t.Obrano).HasColumnName("obrano");
            Property(t => t.Referencia).HasColumnName("ref");
            Property(t => t.Design).HasColumnName("design");
            Property(t => t.Qtt).HasColumnName("qtt");
            Property(t => t.Qtt2).HasColumnName("qtt2");
            Property(t => t.Iva).HasColumnName("iva");
            Property(t => t.Tabiva).HasColumnName("tabiva");
            Property(t => t.Armazem).HasColumnName("armazem");
            Property(t => t.Pu).HasColumnName("pu");
            Property(t => t.Debito).HasColumnName("debito");
            Property(t => t.Prorc).HasColumnName("prorc");
            Property(t => t.Stipo).HasColumnName("stipo");
            Property(t => t.No).HasColumnName("no");
            Property(t => t.Pcusto).HasColumnName("pcusto");
            Property(t => t.Serie).HasColumnName("serie");
            Property(t => t.Nomquina).HasColumnName("nomquina");
            Property(t => t.Nopat).HasColumnName("nopat");
            Property(t => t.Fno).HasColumnName("fno");
            Property(t => t.Fdata).HasColumnName("fdata");
            Property(t => t.Nmdoc).HasColumnName("nmdoc");
            Property(t => t.Ndoc).HasColumnName("ndoc");
            Property(t => t.Ndos).HasColumnName("ndos");
            Property(t => t.Forref).HasColumnName("forref");
            Property(t => t.Txiva).HasColumnName("txiva");
            Property(t => t.Rdata).HasColumnName("rdata");
            Property(t => t.Dedata).HasColumnName("dedata");
            Property(t => t.Atedata).HasColumnName("atedata");
            Property(t => t.Lobs).HasColumnName("lobs");
            Property(t => t.Ldossier).HasColumnName("ldossier");
            Property(t => t.Obranome).HasColumnName("obranome");
            Property(t => t.Fechada).HasColumnName("fechada");
            Property(t => t.Datafinal).HasColumnName("datafinal");
            Property(t => t.Dataobra).HasColumnName("dataobra");
            Property(t => t.Dataopen).HasColumnName("dataopen");
            Property(t => t.Datafecho).HasColumnName("datafecho");
            Property(t => t.Tecnico).HasColumnName("tecnico");
            Property(t => t.Maquina).HasColumnName("maquina");
            Property(t => t.Marca).HasColumnName("marca");
            Property(t => t.Zona).HasColumnName("zona");
            Property(t => t.Litem).HasColumnName("litem");
            Property(t => t.Vumoeda).HasColumnName("vumoeda");
            Property(t => t.Resfor).HasColumnName("resfor");
            Property(t => t.Rescli).HasColumnName("rescli");
            Property(t => t.Resrec).HasColumnName("resrec");
            Property(t => t.Iprint).HasColumnName("iprint");
            Property(t => t.Lobs2).HasColumnName("lobs2");
            Property(t => t.Litem2).HasColumnName("litem2");
            Property(t => t.Lobs3).HasColumnName("lobs3");
            Property(t => t.Estab).HasColumnName("estab");
            Property(t => t.Resusr).HasColumnName("resusr");
            Property(t => t.Ar2Mazem).HasColumnName("ar2mazem");
            Property(t => t.Composto).HasColumnName("composto");
            Property(t => t.Compostoori).HasColumnName("compostoori");
            Property(t => t.Lrecno).HasColumnName("lrecno");
            Property(t => t.Lordem).HasColumnName("lordem");
            Property(t => t.Fmarcada).HasColumnName("fmarcada");
            Property(t => t.Producao).HasColumnName("producao");
            Property(t => t.Local).HasColumnName("local");
            Property(t => t.Morada).HasColumnName("morada");
            Property(t => t.Codpost).HasColumnName("codpost");
            Property(t => t.Nome).HasColumnName("nome");
            Property(t => t.Vendedor).HasColumnName("vendedor");
            Property(t => t.Vendnm).HasColumnName("vendnm");
            Property(t => t.Tabfor).HasColumnName("tabfor");
            Property(t => t.Tabela1).HasColumnName("tabela1");
            Property(t => t.Descli).HasColumnName("descli");
            Property(t => t.Reff).HasColumnName("reff");
            Property(t => t.Lote).HasColumnName("lote");
            Property(t => t.Ivaincl).HasColumnName("ivaincl");
            Property(t => t.Cor).HasColumnName("cor");
            Property(t => t.Tam).HasColumnName("tam");
            Property(t => t.Segmento).HasColumnName("segmento");
            Property(t => t.Bofref).HasColumnName("bofref");
            Property(t => t.Bifref).HasColumnName("bifref");
            Property(t => t.Grau).HasColumnName("grau");
            Property(t => t.Partes).HasColumnName("partes");
            Property(t => t.Partes2).HasColumnName("partes2");
            Property(t => t.Altura).HasColumnName("altura");
            Property(t => t.Largura).HasColumnName("largura");
            Property(t => t.Espessura).HasColumnName("espessura");
            Property(t => t.Biserie).HasColumnName("biserie");
            Property(t => t.Infref).HasColumnName("infref");
            Property(t => t.Lifref).HasColumnName("lifref");
            Property(t => t.Uni2Qtt).HasColumnName("uni2qtt");
            Property(t => t.Epu).HasColumnName("epu");
            Property(t => t.Edebito).HasColumnName("edebito");
            Property(t => t.Eprorc).HasColumnName("eprorc");
            Property(t => t.Epcusto).HasColumnName("epcusto");
            Property(t => t.Ttdeb).HasColumnName("ttdeb");
            Property(t => t.Ettdeb).HasColumnName("ettdeb");
            Property(t => t.Ttmoeda).HasColumnName("ttmoeda");
            Property(t => t.Adoc).HasColumnName("adoc");
            Property(t => t.Binum1).HasColumnName("binum1");
            Property(t => t.Binum2).HasColumnName("binum2");
            Property(t => t.Codigo).HasColumnName("codigo");
            Property(t => t.Cpoc).HasColumnName("cpoc");
            Property(t => t.Stns).HasColumnName("stns");
            Property(t => t.Obistamp).HasColumnName("obistamp");
            Property(t => t.Oobistamp).HasColumnName("oobistamp");
            Property(t => t.Usr1).HasColumnName("usr1");
            Property(t => t.Usr2).HasColumnName("usr2");
            Property(t => t.Usr3).HasColumnName("usr3");
            Property(t => t.Usr4).HasColumnName("usr4");
            Property(t => t.Usr5).HasColumnName("usr5");
            Property(t => t.Usr6).HasColumnName("usr6");
            Property(t => t.Usalote).HasColumnName("usalote");
            Property(t => t.Texteis).HasColumnName("texteis");
            Property(t => t.Unidade).HasColumnName("unidade");
            Property(t => t.Unidad2).HasColumnName("unidad2");
            Property(t => t.Oftstamp).HasColumnName("oftstamp");
            Property(t => t.Ofostamp).HasColumnName("ofostamp");
            Property(t => t.Promo).HasColumnName("promo");
            Property(t => t.Epromo).HasColumnName("epromo");
            Property(t => t.Familia).HasColumnName("familia");
            Property(t => t.Sattotal).HasColumnName("sattotal");
            Property(t => t.Noserie).HasColumnName("noserie");
            Property(t => t.Slvu).HasColumnName("slvu");
            Property(t => t.Eslvu).HasColumnName("eslvu");
            Property(t => t.Sltt).HasColumnName("sltt");
            Property(t => t.Esltt).HasColumnName("esltt");
            Property(t => t.Slvumoeda).HasColumnName("slvumoeda");
            Property(t => t.Slttmoeda).HasColumnName("slttmoeda");
            Property(t => t.Ncmassa).HasColumnName("ncmassa");
            Property(t => t.Ncunsup).HasColumnName("ncunsup");
            Property(t => t.Ncvest).HasColumnName("ncvest");
            Property(t => t.Encvest).HasColumnName("encvest");
            Property(t => t.Nccod).HasColumnName("nccod");
            Property(t => t.Ncinteg).HasColumnName("ncinteg");
            Property(t => t.Classif).HasColumnName("classif");
            Property(t => t.Classifc).HasColumnName("classifc");
            Property(t => t.Posic).HasColumnName("posic");
            Property(t => t.Desconto).HasColumnName("desconto");
            Property(t => t.Desc2).HasColumnName("desc2");
            Property(t => t.Desc3).HasColumnName("desc3");
            Property(t => t.Desc4).HasColumnName("desc4");
            Property(t => t.Desc5).HasColumnName("desc5");
            Property(t => t.Desc6).HasColumnName("desc6");
            Property(t => t.Series).HasColumnName("series");
            Property(t => t.Series2).HasColumnName("series2");
            Property(t => t.Ccusto).HasColumnName("ccusto");
            Property(t => t.Ncusto).HasColumnName("ncusto");
            Property(t => t.Num1).HasColumnName("num1");
            Property(t => t.Fechabo).HasColumnName("fechabo");
            Property(t => t.Oobostamp).HasColumnName("oobostamp");
            Property(t => t.Ltab1).HasColumnName("ltab1");
            Property(t => t.Ltab2).HasColumnName("ltab2");
            Property(t => t.Ltab3).HasColumnName("ltab3");
            Property(t => t.Ltab4).HasColumnName("ltab4");
            Property(t => t.Ltab5).HasColumnName("ltab5");
            Property(t => t.Fami).HasColumnName("fami");
            Property(t => t.Pctfami).HasColumnName("pctfami");
            Property(t => t.Adjudicada).HasColumnName("adjudicada");
            Property(t => t.Tieca).HasColumnName("tieca");
            Property(t => t.Etieca).HasColumnName("etieca");
            Property(t => t.Mtieca).HasColumnName("mtieca");
            Property(t => t.Volume).HasColumnName("volume");
            Property(t => t.Iecasug).HasColumnName("iecasug");
            Property(t => t.Iecagrad).HasColumnName("iecagrad");
            Property(t => t.Iecacodisen).HasColumnName("iecacodisen");
            Property(t => t.Peso).HasColumnName("peso");
            Property(t => t.Pbruto).HasColumnName("pbruto");
            Property(t => t.Codfiscal).HasColumnName("codfiscal");
            Property(t => t.Dgeral).HasColumnName("dgeral");
            Property(t => t.Temoci).HasColumnName("temoci");
            Property(t => t.Temomi).HasColumnName("temomi");
            Property(t => t.Temsubemp).HasColumnName("temsubemp");
            Property(t => t.Encargo).HasColumnName("encargo");
            Property(t => t.Eencargo).HasColumnName("eencargo");
            Property(t => t.Custoind).HasColumnName("custoind");
            Property(t => t.Ecustoind).HasColumnName("ecustoind");
            Property(t => t.Tiposemp).HasColumnName("tiposemp");
            Property(t => t.Pvok).HasColumnName("pvok");
            Property(t => t.Boclose).HasColumnName("boclose");
            Property(t => t.Dtclose).HasColumnName("dtclose");
            Property(t => t.Quarto).HasColumnName("quarto");
            Property(t => t.Emconf).HasColumnName("emconf");
            Property(t => t.Efornecedor).HasColumnName("efornecedor");
            Property(t => t.Efornec).HasColumnName("efornec");
            Property(t => t.Efornestab).HasColumnName("efornestab");
            Property(t => t.Cativo).HasColumnName("cativo");
            Property(t => t.Optstamp).HasColumnName("optstamp");
            Property(t => t.Oristamp).HasColumnName("oristamp");
            Property(t => t.Temeco).HasColumnName("temeco");
            Property(t => t.Ecoval).HasColumnName("ecoval");
            Property(t => t.Eecoval).HasColumnName("eecoval");
            Property(t => t.Tecoval).HasColumnName("tecoval");
            Property(t => t.Etecoval).HasColumnName("etecoval");
            Property(t => t.Ecoval2).HasColumnName("ecoval2");
            Property(t => t.Eecoval2).HasColumnName("eecoval2");
            Property(t => t.Tecoval2).HasColumnName("tecoval2");
            Property(t => t.Etecoval2).HasColumnName("etecoval2");
            Property(t => t.Econotcalc).HasColumnName("econotcalc");
            Property(t => t.Bostamp).HasColumnName("bostamp");
            Property(t => t.Ousrinis).HasColumnName("ousrinis");
            Property(t => t.Ousrdata).HasColumnName("ousrdata");
            Property(t => t.Ousrhora).HasColumnName("ousrhora");
            Property(t => t.Usrinis).HasColumnName("usrinis");
            Property(t => t.Usrdata).HasColumnName("usrdata");
            Property(t => t.Usrhora).HasColumnName("usrhora");
            Property(t => t.Marcada).HasColumnName("marcada");
            Property(t => t.Mntencargos).HasColumnName("mntencargos");
            Property(t => t.Debitoori).HasColumnName("debitoori");
            Property(t => t.Edebitoori).HasColumnName("edebitoori");
            Property(t => t.Trocaequi).HasColumnName("trocaequi");
            Property(t => t.Tpromo).HasColumnName("tpromo");
            Property(t => t.Valdesc).HasColumnName("valdesc");
            Property(t => t.Evaldesc).HasColumnName("evaldesc");
        }
    }
}