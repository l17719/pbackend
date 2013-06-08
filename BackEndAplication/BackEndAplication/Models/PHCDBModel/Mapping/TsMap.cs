using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace BackEndAplication.Models.PHCDBModel.Mapping
{
    public class TsMap : EntityTypeConfiguration<Ts>
    {
        public TsMap()
        {
            HasKey(t => t.Ndos);

            Property(t => t.Tsstamp).IsRequired()
                .HasMaxLength(25);

            Property(t => t.Ndos)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Nmdos)
                .IsRequired()
                .HasMaxLength(24);

            Property(t => t.Cmdesc)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Nmdosp)
                .IsRequired()
                .HasMaxLength(26);

            Property(t => t.Nmdosa)
                .IsRequired()
                .HasMaxLength(6);

            Property(t => t.Preco1)
                .IsRequired()
                .HasMaxLength(12);

            Property(t => t.Preco2)
                .IsRequired()
                .HasMaxLength(12);

            Property(t => t.Qtt1)
                .IsRequired()
                .HasMaxLength(12);

            Property(t => t.Qtt2)
                .IsRequired()
                .HasMaxLength(12);

            Property(t => t.Impressao)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.Texto1)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Texto2)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Texto3)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Tvendno)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Tnopat)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Tnomquina)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Ttecnico)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Tmodelo)
                .IsRequired()
                .HasMaxLength(15);


            Property(t => t.Tmarca)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Tserie)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Tipo1)
                .IsRequired()
                .HasMaxLength(11);

            Property(t => t.Tipo2)
                .IsRequired()
                .HasMaxLength(11);

            Property(t => t.Tipo3)
                .IsRequired()
                .HasMaxLength(11);

            Property(t => t.Tipo4)
                .IsRequired()
                .HasMaxLength(11);


            Property(t => t.Ldata)
                .IsRequired()
                .HasMaxLength(8);

            Property(t => t.Dedata)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Atedata)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Lobs)
                .IsRequired()
                .HasMaxLength(12);

            Property(t => t.Litem)
                .IsRequired()
                .HasMaxLength(8);

            Property(t => t.Nmdatafim)
                .IsRequired()
                .HasMaxLength(16);

            Property(t => t.Nmdesc)
                .IsRequired()
                .HasMaxLength(12);

            Property(t => t.Nmdtopen)
                .IsRequired()
                .HasMaxLength(16);

            Property(t => t.Lobs2)
                .IsRequired()
                .HasMaxLength(12);

            Property(t => t.Litem2)
                .IsRequired()
                .HasMaxLength(7);

            Property(t => t.Lobs3)
                .IsRequired()
                .HasMaxLength(12);

            Property(t => t.Cm2Desc)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Tabela1)
                .IsRequired()
                .HasMaxLength(20);


            Property(t => t.Logi3)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Logi4)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Logi5)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Logi6)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Logi7)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Logi8)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Logi1)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Logi2)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Linum1)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Linum2)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Lotedef)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Valpass)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.Ndosimp)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Posic)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Xddesc)
                .IsRequired()
                .HasMaxLength(120);

            Property(t => t.Xdstamp)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Infosdos)
                .IsRequired()
                .HasMaxLength(3);
            Property(t => t.Infoster)
                .IsRequired()
                .HasMaxLength(3);

            Property(t => t.Tabela2)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Avisatdos)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Tipodos)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Adjnm)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Fami)
                .IsRequired()
                .HasMaxLength(12);

            Property(t => t.Pctfami)
                .IsRequired()
                .HasMaxLength(12);

            Property(t => t.Nmdos2)
                .IsRequired()
                .HasMaxLength(24);

            Property(t => t.Nmdoc1)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Nmdoc2)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Nmdoc3)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Nmdosmais)
                .IsRequired()
                .HasMaxLength(24);

            Property(t => t.Nmdosmenos)
                .IsRequired()
                .HasMaxLength(24);

            Property(t => t.Nmconf)
                .IsRequired()
                .HasMaxLength(40);


            Property(t => t.Usernm)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Acesso)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Tabela)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Pfnm)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Aprovado)
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


            ToTable("dbo.ts");
            Property(t => t.Tsstamp).HasColumnName("tsstamp");
            Property(t => t.Ndos).HasColumnName("ndos");
            Property(t => t.Nmdos).HasColumnName("nmdos");
            Property(t => t.Cmstocks).HasColumnName("cmstocks");
            Property(t => t.Cmstocks).HasColumnName("cmstocks");
            Property(t => t.Cmdesc).HasColumnName("cmdesc");
            Property(t => t.Nmdosp).HasColumnName("nmdosp");
            Property(t => t.Nmdosa).HasColumnName("nmdosa");
            Property(t => t.Bdempresas).HasColumnName("bdempresas");
            Property(t => t.Preco1).HasColumnName("preco1");
            Property(t => t.Preco2).HasColumnName("preco2");
            Property(t => t.Qtt1).HasColumnName("qtt1");
            Property(t => t.Qtt2).HasColumnName("qtt2");
            Property(t => t.Stocks).HasColumnName("stocks");
            Property(t => t.Impressao).HasColumnName("impressao");
            Property(t => t.Texto1).HasColumnName("texto1");
            Property(t => t.Texto2).HasColumnName("texto2");
            Property(t => t.Texto3).HasColumnName("texto3");
            Property(t => t.Tvendno).HasColumnName("tvendno");
            Property(t => t.Tnopat).HasColumnName("tnopat");
            Property(t => t.Tnomquina).HasColumnName("tnomquina");
            Property(t => t.Ttecnico).HasColumnName("ttecnico");
            Property(t => t.Tmodelo).HasColumnName("tmodelo");
            Property(t => t.Tmarca).HasColumnName("tmarca");
            Property(t => t.Tserie).HasColumnName("tserie");
            Property(t => t.Rescli).HasColumnName("rescli");
            Property(t => t.Resfor).HasColumnName("resfor");
            Property(t => t.Tipo1).HasColumnName("tipo1");
            Property(t => t.Tipo2).HasColumnName("tipo2");
            Property(t => t.Tipo3).HasColumnName("tipo3");
            Property(t => t.Tipo4).HasColumnName("tipo4");
            Property(t => t.Desconto).HasColumnName("desconto");
            Property(t => t.Qttdec).HasColumnName("qttdec");
            Property(t => t.Q2Qst).HasColumnName("q2qst");
            Property(t => t.Ldata).HasColumnName("ldata");
            Property(t => t.Dedata).HasColumnName("dedata");
            Property(t => t.Atedata).HasColumnName("atedata");
            Property(t => t.Lobs).HasColumnName("lobs");
            Property(t => t.Litem).HasColumnName("litem");
            Property(t => t.Predec).HasColumnName("predec");
            Property(t => t.Nmdatafim).HasColumnName("nmdatafim");
            Property(t => t.Nmdesc).HasColumnName("nmdesc");
            Property(t => t.Mexenumero).HasColumnName("mexenumero");
            Property(t => t.Copiad).HasColumnName("copiad");
            Property(t => t.Noref).HasColumnName("noref");
            Property(t => t.Passref).HasColumnName("passref");
            Property(t => t.Qpreco).HasColumnName("qpreco");
            Property(t => t.Qprecocusto).HasColumnName("qprecocusto");
            Property(t => t.Nmdtopen).HasColumnName("nmdtopen");
            Property(t => t.Valor2).HasColumnName("valor2");
            Property(t => t.Lobs2).HasColumnName("lobs2");
            Property(t => t.Litem2).HasColumnName("litem2");
            Property(t => t.Clitem2).HasColumnName("clitem2");
            Property(t => t.Lobs3).HasColumnName("lobs3");
            Property(t => t.Resusr).HasColumnName("resusr");
            Property(t => t.Trfa).HasColumnName("trfa");
            Property(t => t.Cm2Stocks).HasColumnName("cm2stocks");
            Property(t => t.Cm2Desc).HasColumnName("cm2desc");
            Property(t => t.Usaiva).HasColumnName("usaiva");
            Property(t => t.Producao).HasColumnName("producao");
            Property(t => t.Actprod).HasColumnName("actprod");
            Property(t => t.Avenca).HasColumnName("avenca");
            Property(t => t.Tabfor).HasColumnName("tabfor");
            Property(t => t.Tabela1).HasColumnName("tabela1");
            Property(t => t.Lsto).HasColumnName("lsto");
            Property(t => t.Lprev).HasColumnName("lprev");
            Property(t => t.Lcli).HasColumnName("lcli");
            Property(t => t.Lfor).HasColumnName("lfor");
            Property(t => t.Lsta).HasColumnName("lsta");
            Property(t => t.Ldescli).HasColumnName("ldescli");
            Property(t => t.Logi3).HasColumnName("logi3");
            Property(t => t.Logi4).HasColumnName("logi4");
            Property(t => t.Logi5).HasColumnName("logi5");
            Property(t => t.Logi6).HasColumnName("logi6");
            Property(t => t.Logi7).HasColumnName("logi7");
            Property(t => t.Logi8).HasColumnName("logi8");
            Property(t => t.Logi1).HasColumnName("logi1");
            Property(t => t.Logi2).HasColumnName("logi2");
            Property(t => t.Evend).HasColumnName("evend");
            Property(t => t.Grelha).HasColumnName("grelha");
            Property(t => t.Usam2).HasColumnName("usam2");
            Property(t => t.Usam3).HasColumnName("usam3");
            Property(t => t.Etecn).HasColumnName("etecn");
            Property(t => t.Comstk).HasColumnName("comstk");
            Property(t => t.Usam1).HasColumnName("usam1");
            Property(t => t.Lifref).HasColumnName("lifref");
            Property(t => t.Infref).HasColumnName("infref");
            Property(t => t.Outref).HasColumnName("outref");
            Property(t => t.Uni2).HasColumnName("uni2");
            Property(t => t.Uni3).HasColumnName("uni3");
            Property(t => t.Noconv).HasColumnName("noconv");
            Property(t => t.Convarr).HasColumnName("convarr");
            Property(t => t.Armazem).HasColumnName("armazem");
            Property(t => t.Refarm).HasColumnName("refarm");
            Property(t => t.Saldebito).HasColumnName("saldebito");
            Property(t => t.Saldesc).HasColumnName("saldesc");
            Property(t => t.Reflinha).HasColumnName("reflinha");
            Property(t => t.Salref).HasColumnName("salref");
            Property(t => t.Qttum).HasColumnName("qttum");
            Property(t => t.Boavst).HasColumnName("boavst");
            Property(t => t.Stneg).HasColumnName("stneg");
            Property(t => t.Cambio).HasColumnName("cambio");
            Property(t => t.Linum1).HasColumnName("linum1");
            Property(t => t.Linum2).HasColumnName("linum2");
            Property(t => t.Composto).HasColumnName("composto");
            Property(t => t.Compnovo).HasColumnName("compnovo");
            Property(t => t.Compcusto).HasColumnName("compcusto");
            Property(t => t.Lplafond).HasColumnName("lplafond");
            Property(t => t.Dividas).HasColumnName("dividas");
            Property(t => t.Ttconf).HasColumnName("ttconf");
            Property(t => t.Lotedef).HasColumnName("lotedef");
            Property(t => t.Stdesc).HasColumnName("stdesc");
            Property(t => t.Valqtt).HasColumnName("valqtt");
            Property(t => t.Valpct1).HasColumnName("valpct1");
            Property(t => t.Valpct2).HasColumnName("valpct2");
            Property(t => t.Valpass).HasColumnName("valpass");
            Property(t => t.Actpromo).HasColumnName("actpromo");
            Property(t => t.Igdata).HasColumnName("igdata");
            Property(t => t.Datafech).HasColumnName("datafech");
            Property(t => t.Ndosimp).HasColumnName("ndosimp");
            Property(t => t.Confdesc).HasColumnName("confdesc");
            Property(t => t.Confprec).HasColumnName("confprec");
            Property(t => t.Usausr6).HasColumnName("usausr6");
            Property(t => t.Usasemaf).HasColumnName("usasemaf");
            Property(t => t.Actpv).HasColumnName("actpv");
            Property(t => t.Actpcusto).HasColumnName("actpcusto");
            Property(t => t.Ncin).HasColumnName("ncin");
            Property(t => t.Ncout).HasColumnName("ncout");
            Property(t => t.Sattotal).HasColumnName("sattotal");
            Property(t => t.Usatclass).HasColumnName("usatclass");
            Property(t => t.Posic).HasColumnName("posic");
            Property(t => t.Iproposta).HasColumnName("iproposta");
            Property(t => t.Plaflet).HasColumnName("plaflet");
            Property(t => t.Ndescs).HasColumnName("ndescs");
            Property(t => t.Livendedor).HasColumnName("livendedor");
            Property(t => t.Xddesc).HasColumnName("xddesc");
            Property(t => t.Xdstamp).HasColumnName("xdstamp");
            Property(t => t.Infosdos).HasColumnName("infosdos");
            Property(t => t.Infoster).HasColumnName("infoster");
            Property(t => t.Refma).HasColumnName("refma");
            Property(t => t.Foserie).HasColumnName("foserie");
            Property(t => t.Ftserie).HasColumnName("ftserie");
            Property(t => t.Veserie).HasColumnName("veserie");
            Property(t => t.Ctrequi).HasColumnName("ctrequi");
            Property(t => t.Trfarm).HasColumnName("trfarm");
            Property(t => t.Retequi).HasColumnName("retequi");
            Property(t => t.Ocupacao).HasColumnName("ocupacao");
            Property(t => t.Qulinhas).HasColumnName("qulinhas");
            Property(t => t.Overbooking).HasColumnName("overbooking");
            Property(t => t.Tccusto).HasColumnName("tccusto");
            Property(t => t.Tncusto).HasColumnName("tncusto");
            Property(t => t.Tabela2).HasColumnName("tabela2");
            Property(t => t.Temefront).HasColumnName("temefront");
            Property(t => t.Temsupext).HasColumnName("temsupext");
            Property(t => t.Avisaqtt).HasColumnName("avisaqtt");
            Property(t => t.Avisatdos).HasColumnName("avisatdos");
            Property(t => t.Tipodos).HasColumnName("tipodos");
            Property(t => t.Lib).HasColumnName("lib");
            Property(t => t.Adjnm).HasColumnName("adjnm");
            Property(t => t.Usasit).HasColumnName("usasit");
            Property(t => t.Fami).HasColumnName("fami");
            Property(t => t.Pctfami).HasColumnName("pctfami");
            Property(t => t.Ltabs).HasColumnName("ltabs");
            Property(t => t.Ndecomp).HasColumnName("ndecomp");
            Property(t => t.Passis).HasColumnName("passis");
            Property(t => t.Nmdos2).HasColumnName("nmdos2");
            Property(t => t.Ndos2).HasColumnName("ndos2");
            Property(t => t.Usaieca).HasColumnName("usaieca");
            Property(t => t.Orcamento).HasColumnName("orcamento");
            Property(t => t.Oci).HasColumnName("oci");
            Property(t => t.Pedidopv).HasColumnName("pedidopv");
            Property(t => t.Seproj).HasColumnName("seproj");
            Property(t => t.Custoreal).HasColumnName("custoreal");
            Property(t => t.Tbrmais).HasColumnName("tbrmais");
            Property(t => t.Tbrmenos).HasColumnName("tbrmenos");
            Property(t => t.Medicao).HasColumnName("medicao");
            Property(t => t.Nmdoc1).HasColumnName("nmdoc1");
            Property(t => t.Nmdoc2).HasColumnName("nmdoc2");
            Property(t => t.Nmdoc3).HasColumnName("nmdoc3");
            Property(t => t.Nmdosmais).HasColumnName("nmdosmais");
            Property(t => t.Nmdosmenos).HasColumnName("nmdosmenos");
            Property(t => t.Tabsede).HasColumnName("tabsede");
            Property(t => t.Frota).HasColumnName("frota");
            Property(t => t.Uticonf).HasColumnName("uticonf");
            Property(t => t.Nmconf).HasColumnName("nmconf");
            Property(t => t.Altefront).HasColumnName("altefront");
            Property(t => t.Usafornec).HasColumnName("usafornec");
            Property(t => t.Cativo).HasColumnName("cativo");
            Property(t => t.Corst).HasColumnName("corst");
            Property(t => t.Corstpla).HasColumnName("corstpla");
            Property(t => t.Mstcomp).HasColumnName("mstcomp");
            Property(t => t.Pstcomp).HasColumnName("pstcomp");
            Property(t => t.Vaihist).HasColumnName("vaihist");
            Property(t => t.Actforn).HasColumnName("actforn");
            Property(t => t.Showflnmincl).HasColumnName("showflnmincl");
            Property(t => t.Tacesso).HasColumnName("tacesso");
            Property(t => t.Userno).HasColumnName("userno");
            Property(t => t.Usernm).HasColumnName("usernm");
            Property(t => t.Acesso).HasColumnName("acesso");
            Property(t => t.Tabela).HasColumnName("tabela");
            Property(t => t.Pfcod).HasColumnName("pfcod");
            Property(t => t.Pfnm).HasColumnName("pfnm");
            Property(t => t.Aprovado).HasColumnName("aprovado");
            Property(t => t.Controlacopia).HasColumnName("controlacopia");
            Property(t => t.Altaprov).HasColumnName("altaprov");
            Property(t => t.Impedeimp).HasColumnName("impedeimp");
            Property(t => t.Ecovalor).HasColumnName("ecovalor");
            Property(t => t.Ecovalormapa).HasColumnName("ecovalormapa");
            Property(t => t.Naoencomenda).HasColumnName("naoencomenda");
            Property(t => t.Retiracusto).HasColumnName("retiracusto");
            Property(t => t.Pvmoedec).HasColumnName("pvmoedec");
            Property(t => t.Negocios).HasColumnName("negocios");
            Property(t => t.Biseries).HasColumnName("biseries");
            Property(t => t.Usatabfor).HasColumnName("usatabfor");
            Property(t => t.Usaldescli).HasColumnName("usaldescli");
            Property(t => t.Actprodclc).HasColumnName("actprodclc");
            Property(t => t.Actprodclp).HasColumnName("actprodclp");
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