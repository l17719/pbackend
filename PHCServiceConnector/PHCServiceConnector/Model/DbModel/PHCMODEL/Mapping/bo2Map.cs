using System.Data.Entity.ModelConfiguration;

namespace ConnectorService.Model.PHCModel.Mapping
{
    public class Bo2Map : EntityTypeConfiguration<Bo2>
    {
        public Bo2Map()
        {
            // Primary Key
            HasKey(t => t.Bo2Stamp);

            // Properties
            Property(t => t.Bo2Stamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Pscm)
                .IsRequired()
                .HasMaxLength(2);

            Property(t => t.Ptcm)
                .IsRequired()
                .HasMaxLength(3);

            Property(t => t.Encm)
                .IsRequired()
                .HasMaxLength(3);

            Property(t => t.Pscmdesc)
                .IsRequired()
                .HasMaxLength(70);

            Property(t => t.Znregiao)
                .IsRequired()
                .HasMaxLength(70);

            Property(t => t.Excmdesc)
                .IsRequired()
                .HasMaxLength(70);

            Property(t => t.Ptcmdesc)
                .IsRequired()
                .HasMaxLength(70);

            Property(t => t.Encmdesc)
                .IsRequired()
                .HasMaxLength(70);

            Property(t => t.Adjbostamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Processo)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Subproc)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Dpedidopv)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Calistamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Tipoobra)
                .IsRequired()
                .HasMaxLength(5);

            Property(t => t.Descobra)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Ngstamp)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Negocio)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.Descnegocio)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Ngstatus)
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

            Property(t => t.Autobostamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

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

            Property(t => t.Dprocesso)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.Xpdviatura)
                .IsRequired()
                .HasMaxLength(120);

            Property(t => t.Xpdhora)
                .IsRequired()
                .HasMaxLength(5);

            Property(t => t.Versaocrono)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Crpstamp)
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

            Property(t => t.Area)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            Property(t => t.Nomects)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Tkhcarr)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Tkhref)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Tkhhora)
                .IsRequired()
                .HasMaxLength(5);

            Property(t => t.Tkhlref)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Tkhopid)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Tkhid)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Tkhpan)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Tkhsttnr)
                .IsRequired()
                .HasMaxLength(6);

            Property(t => t.Tkhposcstamp)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Pscmori)
                .IsRequired()
                .HasMaxLength(2);

            Property(t => t.Pscmoridesc)
                .IsRequired()
                .HasMaxLength(70);

            Property(t => t.Assinatura)
                .IsRequired()
                .HasMaxLength(200);

            Property(t => t.Versaochave)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Stamporcamento)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Versaorcamento)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Horasl)
                .IsRequired()
                .HasMaxLength(8);

            Property(t => t.Ndosmanual)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            ToTable("bo2");
            Property(t => t.Bo2Stamp).HasColumnName("bo2stamp");
            Property(t => t.Pscm).HasColumnName("pscm");
            Property(t => t.Zncm).HasColumnName("zncm");
            Property(t => t.Excm).HasColumnName("excm");
            Property(t => t.Ptcm).HasColumnName("ptcm");
            Property(t => t.Encm).HasColumnName("encm");
            Property(t => t.Ntcm).HasColumnName("ntcm");
            Property(t => t.Pscmdesc).HasColumnName("pscmdesc");
            Property(t => t.Znregiao).HasColumnName("znregiao");
            Property(t => t.Excmdesc).HasColumnName("excmdesc");
            Property(t => t.Ptcmdesc).HasColumnName("ptcmdesc");
            Property(t => t.Encmdesc).HasColumnName("encmdesc");
            Property(t => t.Ncin).HasColumnName("ncin");
            Property(t => t.Ncout).HasColumnName("ncout");
            Property(t => t.Usaintra).HasColumnName("usaintra");
            Property(t => t.Ettieca).HasColumnName("ettieca");
            Property(t => t.Ttieca).HasColumnName("ttieca");
            Property(t => t.Mttieca).HasColumnName("mttieca");
            Property(t => t.Iectisento).HasColumnName("iectisento");
            Property(t => t.Adjbostamp).HasColumnName("adjbostamp");
            Property(t => t.Processo).HasColumnName("processo");
            Property(t => t.Subproc).HasColumnName("subproc");
            Property(t => t.Adjudicado).HasColumnName("adjudicado");
            Property(t => t.Orcamento).HasColumnName("orcamento");
            Property(t => t.Mcomercial).HasColumnName("mcomercial");
            Property(t => t.Dpedidopv).HasColumnName("dpedidopv");
            Property(t => t.Autos).HasColumnName("autos");
            Property(t => t.Autotipo).HasColumnName("autotipo");
            Property(t => t.Autoper).HasColumnName("autoper");
            Property(t => t.Mensaldia).HasColumnName("mensaldia");
            Property(t => t.Vencimento).HasColumnName("vencimento");
            Property(t => t.Autono).HasColumnName("autono");
            Property(t => t.Tbrsemmed).HasColumnName("tbrsemmed");
            Property(t => t.Pdtipo).HasColumnName("pdtipo");
            Property(t => t.Planeamento).HasColumnName("planeamento");
            Property(t => t.Calistamp).HasColumnName("calistamp");
            Property(t => t.Tipoobra).HasColumnName("tipoobra");
            Property(t => t.Descobra).HasColumnName("descobra");
            Property(t => t.Sujrvp).HasColumnName("sujrvp");
            Property(t => t.Ttecoval).HasColumnName("ttecoval");
            Property(t => t.Ettecoval).HasColumnName("ettecoval");
            Property(t => t.Ngstamp).HasColumnName("ngstamp");
            Property(t => t.Negocio).HasColumnName("negocio");
            Property(t => t.Descnegocio).HasColumnName("descnegocio");
            Property(t => t.Ngstatus).HasColumnName("ngstatus");
            Property(t => t.Ousrinis).HasColumnName("ousrinis");
            Property(t => t.Ousrdata).HasColumnName("ousrdata");
            Property(t => t.Ousrhora).HasColumnName("ousrhora");
            Property(t => t.Usrinis).HasColumnName("usrinis");
            Property(t => t.Usrdata).HasColumnName("usrdata");
            Property(t => t.Usrhora).HasColumnName("usrhora");
            Property(t => t.Marcada).HasColumnName("marcada");
            Property(t => t.Autobostamp).HasColumnName("autobostamp");
            Property(t => t.Bo71Bins).HasColumnName("bo71_bins");
            Property(t => t.Bo71Iva).HasColumnName("bo71_iva");
            Property(t => t.Ebo71Bins).HasColumnName("ebo71_bins");
            Property(t => t.Ebo71Iva).HasColumnName("ebo71_iva");
            Property(t => t.Bo81Bins).HasColumnName("bo81_bins");
            Property(t => t.Bo81Iva).HasColumnName("bo81_iva");
            Property(t => t.Ebo81Bins).HasColumnName("ebo81_bins");
            Property(t => t.Ebo81Iva).HasColumnName("ebo81_iva");
            Property(t => t.Bo91Bins).HasColumnName("bo91_bins");
            Property(t => t.Bo91Iva).HasColumnName("bo91_iva");
            Property(t => t.Ebo91Bins).HasColumnName("ebo91_bins");
            Property(t => t.Ebo91Iva).HasColumnName("ebo91_iva");
            Property(t => t.Bo72Bins).HasColumnName("bo72_bins");
            Property(t => t.Bo72Iva).HasColumnName("bo72_iva");
            Property(t => t.Ebo72Bins).HasColumnName("ebo72_bins");
            Property(t => t.Ebo72Iva).HasColumnName("ebo72_iva");
            Property(t => t.Bo82Bins).HasColumnName("bo82_bins");
            Property(t => t.Bo82Iva).HasColumnName("bo82_iva");
            Property(t => t.Ebo82Bins).HasColumnName("ebo82_bins");
            Property(t => t.Ebo82Iva).HasColumnName("ebo82_iva");
            Property(t => t.Bo92Bins).HasColumnName("bo92_bins");
            Property(t => t.Bo92Iva).HasColumnName("bo92_iva");
            Property(t => t.Ebo92Bins).HasColumnName("ebo92_bins");
            Property(t => t.Ebo92Iva).HasColumnName("ebo92_iva");
            Property(t => t.Alvstamp1).HasColumnName("alvstamp1");
            Property(t => t.Identificacao1).HasColumnName("identificacao1");
            Property(t => t.Szzstamp1).HasColumnName("szzstamp1");
            Property(t => t.Zona1).HasColumnName("zona1");
            Property(t => t.Alvstamp2).HasColumnName("alvstamp2");
            Property(t => t.Identificacao2).HasColumnName("identificacao2");
            Property(t => t.Szzstamp2).HasColumnName("szzstamp2");
            Property(t => t.Zona2).HasColumnName("zona2");
            Property(t => t.Armazem).HasColumnName("armazem");
            Property(t => t.Ar2Mazem).HasColumnName("ar2mazem");
            Property(t => t.Dprocesso).HasColumnName("dprocesso");
            Property(t => t.Diasde).HasColumnName("diasde");
            Property(t => t.Diasate).HasColumnName("diasate");
            Property(t => t.Ttecoval2).HasColumnName("ttecoval2");
            Property(t => t.Ettecoval2).HasColumnName("ettecoval2");
            Property(t => t.Nopkng).HasColumnName("nopkng");
            Property(t => t.Xpdviatura).HasColumnName("xpdviatura");
            Property(t => t.Xpddata).HasColumnName("xpddata");
            Property(t => t.Xpdhora).HasColumnName("xpdhora");
            Property(t => t.Versaocrono).HasColumnName("versaocrono");
            Property(t => t.Crpstamp).HasColumnName("crpstamp");
            Property(t => t.Exportado).HasColumnName("exportado");
            Property(t => t.Cladrsdesc).HasColumnName("cladrsdesc");
            Property(t => t.Morada).HasColumnName("morada");
            Property(t => t.Local).HasColumnName("local");
            Property(t => t.Codpost).HasColumnName("codpost");
            Property(t => t.Cladrszona).HasColumnName("cladrszona");
            Property(t => t.Telefone).HasColumnName("telefone");
            Property(t => t.Contacto).HasColumnName("contacto");
            Property(t => t.Email).HasColumnName("email");
            Property(t => t.Cladrsstamp).HasColumnName("cladrsstamp");
            Property(t => t.Area).HasColumnName("area");
            Property(t => t.Nomects).HasColumnName("nomects");
            Property(t => t.Nocts).HasColumnName("nocts");
            Property(t => t.Tkhtyp).HasColumnName("tkhtyp");
            Property(t => t.Tkhcarr).HasColumnName("tkhcarr");
            Property(t => t.Tkhref).HasColumnName("tkhref");
            Property(t => t.EftaxamtA).HasColumnName("eftaxamt_a");
            Property(t => t.EftaxamtB).HasColumnName("eftaxamt_b");
            Property(t => t.FtaxamtA).HasColumnName("ftaxamt_a");
            Property(t => t.FtaxamtB).HasColumnName("ftaxamt_b");
            Property(t => t.Tkhhora).HasColumnName("tkhhora");
            Property(t => t.Tkhdata).HasColumnName("tkhdata");
            Property(t => t.Tkhlref).HasColumnName("tkhlref");
            Property(t => t.Tkhshf).HasColumnName("tkhshf");
            Property(t => t.Tkhopid).HasColumnName("tkhopid");
            Property(t => t.Tkhltyp).HasColumnName("tkhltyp");
            Property(t => t.Tkhlpnt).HasColumnName("tkhlpnt");
            Property(t => t.Tkhid).HasColumnName("tkhid");
            Property(t => t.Tkhpan).HasColumnName("tkhpan");
            Property(t => t.Tkhodo).HasColumnName("tkhodo");
            Property(t => t.Tkhdid).HasColumnName("tkhdid");
            Property(t => t.Tkhsttnr).HasColumnName("tkhsttnr");
            Property(t => t.Tkhposcstamp).HasColumnName("tkhposcstamp");
            Property(t => t.Pscmori).HasColumnName("pscmori");
            Property(t => t.Pscmoridesc).HasColumnName("pscmoridesc");
            Property(t => t.Mtotalciva).HasColumnName("mtotalciva");
            Property(t => t.Etotalciva).HasColumnName("etotalciva");
            Property(t => t.Totalciva).HasColumnName("totalciva");
            Property(t => t.Etotiva).HasColumnName("etotiva");
            Property(t => t.Totiva).HasColumnName("totiva");
            Property(t => t.Mtotiva).HasColumnName("mtotiva");
            Property(t => t.Cambiofixo).HasColumnName("cambiofixo");
            Property(t => t.Cambio).HasColumnName("cambio");
            Property(t => t.Assinatura).HasColumnName("assinatura");
            Property(t => t.Versaochave).HasColumnName("versaochave");
            Property(t => t.Reorcamento).HasColumnName("reorcamento");
            Property(t => t.Stamporcamento).HasColumnName("stamporcamento");
            Property(t => t.Obranoorcamento).HasColumnName("obranoorcamento");
            Property(t => t.Versaorcamento).HasColumnName("versaorcamento");
            Property(t => t.Custototalorc).HasColumnName("custototalorc");
            Property(t => t.Ecustototalorc).HasColumnName("ecustototalorc");
            Property(t => t.Custototalreorc).HasColumnName("custototalreorc");
            Property(t => t.Ecustototalreorc).HasColumnName("ecustototalreorc");
            Property(t => t.Custototaldif).HasColumnName("custototaldif");
            Property(t => t.Ecustototaldif).HasColumnName("ecustototaldif");
            Property(t => t.Margemtotalorc).HasColumnName("margemtotalorc");
            Property(t => t.Emargemtotalorc).HasColumnName("emargemtotalorc");
            Property(t => t.Margemtotalreorc).HasColumnName("margemtotalreorc");
            Property(t => t.Emargemtotalreorc).HasColumnName("emargemtotalreorc");
            Property(t => t.Margemtotaldif).HasColumnName("margemtotaldif");
            Property(t => t.Emargemtotaldif).HasColumnName("emargemtotaldif");
            Property(t => t.Margemorcperc).HasColumnName("margemorcperc");
            Property(t => t.Margemreorcperc).HasColumnName("margemreorcperc");
            Property(t => t.Horasl).HasColumnName("horasl");
            Property(t => t.Ndosmanual).HasColumnName("ndosmanual");
            Property(t => t.Obranomanual).HasColumnName("obranomanual");
        }
    }
}