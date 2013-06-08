using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace ConnectorService.Model.PHCModel.Mapping
{
    public class BoMap:EntityTypeConfiguration<Bo>
    {
        public BoMap()
        {
            // Primary Key
            HasKey(t => new {t.Obrano,  t.Boano, t.Ndos });

            // Properties
            Property(t => t.Bostamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Nmdos)
                .IsRequired()
                .HasMaxLength(24);

            Property(t => t.Obrano)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Nome)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(55);

            Property(t => t.Tipo)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Vendnm)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Obranome)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Boano)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Tecnnm)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Maquina)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Marca)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Serie)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Zona)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Obs)
                .IsRequired()
                .HasMaxLength(67);

            Property(t => t.Trab1)
                .IsRequired()
                .HasMaxLength(67);

            Property(t => t.Trab2)
                .IsRequired()
                .HasMaxLength(67);

            Property(t => t.Trab3)
                .IsRequired()
                .HasMaxLength(67);

            Property(t => t.Trab4)
                .IsRequired()
                .HasMaxLength(67);

            Property(t => t.Trab5)
                .IsRequired()
                .HasMaxLength(67);

            Property(t => t.Ndos)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Moeda)
                .IsRequired()
                .HasMaxLength(11);

            Property(t => t.Morada)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Local)
                .IsRequired()
                .HasMaxLength(43);

            Property(t => t.Codpost)
                .IsRequired()
                .HasMaxLength(45);

            Property(t => t.Tabela1)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Ncont)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Segmento)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Userimpresso)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Fref)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Ccusto)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Ncusto)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Cobranca)
                .IsRequired()
                .HasMaxLength(22);

            Property(t => t.Memissao)
                .IsRequired()
                .HasMaxLength(4);

            Property(t => t.Nome2)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Pastamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Snstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Mastamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Origem)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Site)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Pnome)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Cxstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Cxusername)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.Ssstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Ssusername)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.Series)
                .IsRequired();

            Property(t => t.Series2)
                .IsRequired();

            Property(t => t.Quarto)
                .IsRequired()
                .HasMaxLength(10);

            Property(t => t.Tabela2)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Obstab2)
                .IsRequired();

            Property(t => t.Iemail)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Inome)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Lang)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            Property(t => t.Ean)
                .IsRequired()
                .HasMaxLength(35);

            Property(t => t.Iecacodisen)
                .IsRequired()
                .HasMaxLength(4);

            Property(t => t.Tpstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Tpdesc)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Statuspda)
                .IsRequired()
                .HasMaxLength(1);

            Property(t => t.Boid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

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
            ToTable("bo");
            Property(t => t.Bostamp).HasColumnName("bostamp");
            Property(t => t.Nmdos).HasColumnName("nmdos");
            Property(t => t.Obrano).HasColumnName("obrano");
            Property(t => t.Dataobra).HasColumnName("dataobra");
            Property(t => t.Nome).HasColumnName("nome");
            Property(t => t.Totaldeb).HasColumnName("totaldeb");
            Property(t => t.Etotaldeb).HasColumnName("etotaldeb");
            Property(t => t.Tipo).HasColumnName("tipo");
            Property(t => t.Datafinal).HasColumnName("datafinal");
            Property(t => t.Smoe4).HasColumnName("smoe4");
            Property(t => t.Smoe3).HasColumnName("smoe3");
            Property(t => t.Smoe2).HasColumnName("smoe2");
            Property(t => t.Smoe1).HasColumnName("smoe1");
            Property(t => t.Moetotal).HasColumnName("moetotal");
            Property(t => t.Sdeb2).HasColumnName("sdeb2");
            Property(t => t.Sdeb1).HasColumnName("sdeb1");
            Property(t => t.Sdeb4).HasColumnName("sdeb4");
            Property(t => t.Sdeb3).HasColumnName("sdeb3");
            Property(t => t.Sqtt14).HasColumnName("sqtt14");
            Property(t => t.Sqtt13).HasColumnName("sqtt13");
            Property(t => t.Sqtt12).HasColumnName("sqtt12");
            Property(t => t.Sqtt11).HasColumnName("sqtt11");
            Property(t => t.Sqtt24).HasColumnName("sqtt24");
            Property(t => t.Sqtt23).HasColumnName("sqtt23");
            Property(t => t.Sqtt22).HasColumnName("sqtt22");
            Property(t => t.Sqtt21).HasColumnName("sqtt21");
            Property(t => t.Vqtt24).HasColumnName("vqtt24");
            Property(t => t.Vqtt23).HasColumnName("vqtt23");
            Property(t => t.Vqtt22).HasColumnName("vqtt22");
            Property(t => t.Vqtt21).HasColumnName("vqtt21");
            Property(t => t.Vendedor).HasColumnName("vendedor");
            Property(t => t.Vendnm).HasColumnName("vendnm");
            Property(t => t.Stot1).HasColumnName("stot1");
            Property(t => t.Stot2).HasColumnName("stot2");
            Property(t => t.Stot3).HasColumnName("stot3");
            Property(t => t.Stot4).HasColumnName("stot4");
            Property(t => t.No).HasColumnName("no");
            Property(t => t.Obranome).HasColumnName("obranome");
            Property(t => t.Boano).HasColumnName("boano");
            Property(t => t.Dataopen).HasColumnName("dataopen");
            Property(t => t.Datafecho).HasColumnName("datafecho");
            Property(t => t.Fechada).HasColumnName("fechada");
            Property(t => t.Nopat).HasColumnName("nopat");
            Property(t => t.Total).HasColumnName("total");
            Property(t => t.Tecnico).HasColumnName("tecnico");
            Property(t => t.Tecnnm).HasColumnName("tecnnm");
            Property(t => t.Nomquina).HasColumnName("nomquina");
            Property(t => t.Maquina).HasColumnName("maquina");
            Property(t => t.Marca).HasColumnName("marca");
            Property(t => t.Serie).HasColumnName("serie");
            Property(t => t.Zona).HasColumnName("zona");
            Property(t => t.Obs).HasColumnName("obs");
            Property(t => t.Trab1).HasColumnName("trab1");
            Property(t => t.Trab2).HasColumnName("trab2");
            Property(t => t.Trab3).HasColumnName("trab3");
            Property(t => t.Trab4).HasColumnName("trab4");
            Property(t => t.Trab5).HasColumnName("trab5");
            Property(t => t.Ndos).HasColumnName("ndos");
            Property(t => t.Custo).HasColumnName("custo");
            Property(t => t.Moeda).HasColumnName("moeda");
            Property(t => t.Estab).HasColumnName("estab");
            Property(t => t.Morada).HasColumnName("morada");
            Property(t => t.Local).HasColumnName("local");
            Property(t => t.Codpost).HasColumnName("codpost");
            Property(t => t.Ultfact).HasColumnName("ultfact");
            Property(t => t.Period).HasColumnName("period");
            Property(t => t.Tabela1).HasColumnName("tabela1");
            Property(t => t.Ncont).HasColumnName("ncont");
            Property(t => t.Logi1).HasColumnName("logi1");
            Property(t => t.Logi2).HasColumnName("logi2");
            Property(t => t.Logi3).HasColumnName("logi3");
            Property(t => t.Logi4).HasColumnName("logi4");
            Property(t => t.Logi5).HasColumnName("logi5");
            Property(t => t.Logi6).HasColumnName("logi6");
            Property(t => t.Logi7).HasColumnName("logi7");
            Property(t => t.Logi8).HasColumnName("logi8");
            Property(t => t.Segmento).HasColumnName("segmento");
            Property(t => t.Impresso).HasColumnName("impresso");
            Property(t => t.Userimpresso).HasColumnName("userimpresso");
            Property(t => t.Fref).HasColumnName("fref");
            Property(t => t.Ccusto).HasColumnName("ccusto");
            Property(t => t.Ncusto).HasColumnName("ncusto");
            Property(t => t.Cobranca).HasColumnName("cobranca");
            Property(t => t.Infref).HasColumnName("infref");
            Property(t => t.Lifref).HasColumnName("lifref");
            Property(t => t.Esdeb1).HasColumnName("esdeb1");
            Property(t => t.Esdeb2).HasColumnName("esdeb2");
            Property(t => t.Esdeb3).HasColumnName("esdeb3");
            Property(t => t.Esdeb4).HasColumnName("esdeb4");
            Property(t => t.Evqtt21).HasColumnName("evqtt21");
            Property(t => t.Evqtt22).HasColumnName("evqtt22");
            Property(t => t.Evqtt23).HasColumnName("evqtt23");
            Property(t => t.Evqtt24).HasColumnName("evqtt24");
            Property(t => t.Estot1).HasColumnName("estot1");
            Property(t => t.Estot2).HasColumnName("estot2");
            Property(t => t.Estot3).HasColumnName("estot3");
            Property(t => t.Estot4).HasColumnName("estot4");
            Property(t => t.Etotal).HasColumnName("etotal");
            Property(t => t.Ecusto).HasColumnName("ecusto");
            Property(t => t.Bo2Tdesc1).HasColumnName("bo_2tdesc1");
            Property(t => t.Bo2Tdesc2).HasColumnName("bo_2tdesc2");
            Property(t => t.Ebo2Tdes1).HasColumnName("ebo_2tdes1");
            Property(t => t.Ebo2Tdes2).HasColumnName("ebo_2tdes2");
            Property(t => t.Descc).HasColumnName("descc");
            Property(t => t.Edescc).HasColumnName("edescc");
            Property(t => t.Bo1Tvall).HasColumnName("bo_1tvall");
            Property(t => t.Bo2Tvall).HasColumnName("bo_2tvall");
            Property(t => t.Ebo1Tvall).HasColumnName("ebo_1tvall");
            Property(t => t.Ebo2Tvall).HasColumnName("ebo_2tvall");
            Property(t => t.Bo11Bins).HasColumnName("bo11_bins");
            Property(t => t.Bo11Iva).HasColumnName("bo11_iva");
            Property(t => t.Ebo11Bins).HasColumnName("ebo11_bins");
            Property(t => t.Ebo11Iva).HasColumnName("ebo11_iva");
            Property(t => t.Bo21Bins).HasColumnName("bo21_bins");
            Property(t => t.Bo21Iva).HasColumnName("bo21_iva");
            Property(t => t.Ebo21Bins).HasColumnName("ebo21_bins");
            Property(t => t.Ebo21Iva).HasColumnName("ebo21_iva");
            Property(t => t.Bo31Bins).HasColumnName("bo31_bins");
            Property(t => t.Bo31Iva).HasColumnName("bo31_iva");
            Property(t => t.Ebo31Bins).HasColumnName("ebo31_bins");
            Property(t => t.Ebo31Iva).HasColumnName("ebo31_iva");
            Property(t => t.Bo41Bins).HasColumnName("bo41_bins");
            Property(t => t.Bo41Iva).HasColumnName("bo41_iva");
            Property(t => t.Ebo41Bins).HasColumnName("ebo41_bins");
            Property(t => t.Ebo41Iva).HasColumnName("ebo41_iva");
            Property(t => t.Bo51Bins).HasColumnName("bo51_bins");
            Property(t => t.Bo51Iva).HasColumnName("bo51_iva");
            Property(t => t.Ebo51Bins).HasColumnName("ebo51_bins");
            Property(t => t.Ebo51Iva).HasColumnName("ebo51_iva");
            Property(t => t.Bo61Bins).HasColumnName("bo61_bins");
            Property(t => t.Bo61Iva).HasColumnName("bo61_iva");
            Property(t => t.Ebo61Bins).HasColumnName("ebo61_bins");
            Property(t => t.Ebo61Iva).HasColumnName("ebo61_iva");
            Property(t => t.Bo12Bins).HasColumnName("bo12_bins");
            Property(t => t.Bo12Iva).HasColumnName("bo12_iva");
            Property(t => t.Ebo12Bins).HasColumnName("ebo12_bins");
            Property(t => t.Ebo12Iva).HasColumnName("ebo12_iva");
            Property(t => t.Bo22Bins).HasColumnName("bo22_bins");
            Property(t => t.Bo22Iva).HasColumnName("bo22_iva");
            Property(t => t.Ebo22Bins).HasColumnName("ebo22_bins");
            Property(t => t.Ebo22Iva).HasColumnName("ebo22_iva");
            Property(t => t.Bo32Bins).HasColumnName("bo32_bins");
            Property(t => t.Bo32Iva).HasColumnName("bo32_iva");
            Property(t => t.Ebo32Bins).HasColumnName("ebo32_bins");
            Property(t => t.Ebo32Iva).HasColumnName("ebo32_iva");
            Property(t => t.Bo42Bins).HasColumnName("bo42_bins");
            Property(t => t.Bo42Iva).HasColumnName("bo42_iva");
            Property(t => t.Ebo42Bins).HasColumnName("ebo42_bins");
            Property(t => t.Ebo42Iva).HasColumnName("ebo42_iva");
            Property(t => t.Bo52Bins).HasColumnName("bo52_bins");
            Property(t => t.Bo52Iva).HasColumnName("bo52_iva");
            Property(t => t.Ebo52Bins).HasColumnName("ebo52_bins");
            Property(t => t.Ebo52Iva).HasColumnName("ebo52_iva");
            Property(t => t.Bo62Bins).HasColumnName("bo62_bins");
            Property(t => t.Bo62Iva).HasColumnName("bo62_iva");
            Property(t => t.Ebo62Bins).HasColumnName("ebo62_bins");
            Property(t => t.Ebo62Iva).HasColumnName("ebo62_iva");
            Property(t => t.BoTotp1).HasColumnName("bo_totp1");
            Property(t => t.BoTotp2).HasColumnName("bo_totp2");
            Property(t => t.EboTotp1).HasColumnName("ebo_totp1");
            Property(t => t.EboTotp2).HasColumnName("ebo_totp2");
            Property(t => t.Edi).HasColumnName("edi");
            Property(t => t.Memissao).HasColumnName("memissao");
            Property(t => t.Nome2).HasColumnName("nome2");
            Property(t => t.Pastamp).HasColumnName("pastamp");
            Property(t => t.Snstamp).HasColumnName("snstamp");
            Property(t => t.Mastamp).HasColumnName("mastamp");
            Property(t => t.Origem).HasColumnName("origem");
            Property(t => t.Orinopat).HasColumnName("orinopat");
            Property(t => t.Iiva).HasColumnName("iiva");
            Property(t => t.Iunit).HasColumnName("iunit");
            Property(t => t.Itotais).HasColumnName("itotais");
            Property(t => t.Iunitiva).HasColumnName("iunitiva");
            Property(t => t.Itotaisiva).HasColumnName("itotaisiva");
            Property(t => t.Site).HasColumnName("site");
            Property(t => t.Pnome).HasColumnName("pnome");
            Property(t => t.Pno).HasColumnName("pno");
            Property(t => t.Cxstamp).HasColumnName("cxstamp");
            Property(t => t.Cxusername).HasColumnName("cxusername");
            Property(t => t.Ssstamp).HasColumnName("ssstamp");
            Property(t => t.Ssusername).HasColumnName("ssusername");
            Property(t => t.Alldescli).HasColumnName("alldescli");
            Property(t => t.Alldesfor).HasColumnName("alldesfor");
            Property(t => t.Series).HasColumnName("series");
            Property(t => t.Series2).HasColumnName("series2");
            Property(t => t.Quarto).HasColumnName("quarto");
            Property(t => t.Ocupacao).HasColumnName("ocupacao");
            Property(t => t.Tabela2).HasColumnName("tabela2");
            Property(t => t.Obstab2).HasColumnName("obstab2");
            Property(t => t.Iemail).HasColumnName("iemail");
            Property(t => t.Inome).HasColumnName("inome");
            Property(t => t.Situacao).HasColumnName("situacao");
            Property(t => t.Lang).HasColumnName("lang");
            Property(t => t.Ean).HasColumnName("ean");
            Property(t => t.Iecacodisen).HasColumnName("iecacodisen");
            Property(t => t.Boclose).HasColumnName("boclose");
            Property(t => t.Dtclose).HasColumnName("dtclose");
            Property(t => t.Tpstamp).HasColumnName("tpstamp");
            Property(t => t.Tpdesc).HasColumnName("tpdesc");
            Property(t => t.Emconf).HasColumnName("emconf");
            Property(t => t.Statuspda).HasColumnName("statuspda");
            Property(t => t.Aprovado).HasColumnName("aprovado");
            Property(t => t.Boid).HasColumnName("boid");
            Property(t => t.Ousrinis).HasColumnName("ousrinis");
            Property(t => t.Ousrdata).HasColumnName("ousrdata");
            Property(t => t.Ousrhora).HasColumnName("ousrhora");
            Property(t => t.Usrinis).HasColumnName("usrinis");
            Property(t => t.Usrdata).HasColumnName("usrdata");
            Property(t => t.Usrhora).HasColumnName("usrhora");
            Property(t => t.Marcada).HasColumnName("marcada");
        }
    }
}