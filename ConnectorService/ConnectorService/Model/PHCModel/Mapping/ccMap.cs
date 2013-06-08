using System.Data.Entity.ModelConfiguration;

namespace ConnectorService.Model.PHCModel.Mapping
{
    public class CcMap : EntityTypeConfiguration<Cc>
    {
        public CcMap()
        {
            // Primary Key
            HasKey(t => t.Ccstamp);

            // Properties
            Property(t => t.Ccstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Cmdesc)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Nome)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(55);

            Property(t => t.Moeda)
                .IsRequired()
                .HasMaxLength(11);

            Property(t => t.Ultdoc)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Fref)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Ccusto)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Ncusto)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Origem)
                .IsRequired()
                .HasMaxLength(2);

            Property(t => t.Zona)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Vendnm)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Crdesc)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Obs)
                .IsRequired()
                .HasMaxLength(250);

            Property(t => t.Obscob)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Segmento)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Odstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Cobranca)
                .IsRequired()
                .HasMaxLength(22);

            Property(t => t.Ftstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Restamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Tipo)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Ftccstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Rdstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Cobrador)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Rota)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Clbanco)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Clcheque)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Intid)
                .IsRequired()
                .HasMaxLength(10);

            Property(t => t.Lestamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Lrstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Lmstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Tpstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Tpdesc)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Chstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Faccstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Faclstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Occstamp)
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

            Property(t => t.Formapag)
                .IsRequired()
                .HasMaxLength(1);

            Property(t => t.Situacao)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            ToTable("cc");
            Property(t => t.Ccstamp).HasColumnName("ccstamp");
            Property(t => t.Datalc).HasColumnName("datalc");
            Property(t => t.Dataven).HasColumnName("dataven");
            Property(t => t.Cmdesc).HasColumnName("cmdesc");
            Property(t => t.Nrdoc).HasColumnName("nrdoc");
            Property(t => t.Deb).HasColumnName("deb");
            Property(t => t.Cred).HasColumnName("cred");
            Property(t => t.Edeb).HasColumnName("edeb");
            Property(t => t.Ecred).HasColumnName("ecred");
            Property(t => t.Nome).HasColumnName("nome");
            Property(t => t.Moeda).HasColumnName("moeda");
            Property(t => t.Ultdoc).HasColumnName("ultdoc");
            Property(t => t.No).HasColumnName("no");
            Property(t => t.Cm).HasColumnName("cm");
            Property(t => t.Cr).HasColumnName("cr");
            Property(t => t.Docref).HasColumnName("docref");
            Property(t => t.Debf).HasColumnName("debf");
            Property(t => t.Edebf).HasColumnName("edebf");
            Property(t => t.Credf).HasColumnName("credf");
            Property(t => t.Ecredf).HasColumnName("ecredf");
            Property(t => t.Fref).HasColumnName("fref");
            Property(t => t.Ccusto).HasColumnName("ccusto");
            Property(t => t.Ncusto).HasColumnName("ncusto");
            Property(t => t.Origem).HasColumnName("origem");
            Property(t => t.Debm).HasColumnName("debm");
            Property(t => t.Credm).HasColumnName("credm");
            Property(t => t.Debfm).HasColumnName("debfm");
            Property(t => t.Credfm).HasColumnName("credfm");
            Property(t => t.Zona).HasColumnName("zona");
            Property(t => t.Recibado).HasColumnName("recibado");
            Property(t => t.Vendedor).HasColumnName("vendedor");
            Property(t => t.Vendnm).HasColumnName("vendnm");
            Property(t => t.Crdesc).HasColumnName("crdesc");
            Property(t => t.Incobra).HasColumnName("incobra");
            Property(t => t.Ftndoc).HasColumnName("ftndoc");
            Property(t => t.Ftfno).HasColumnName("ftfno");
            Property(t => t.Obs).HasColumnName("obs");
            Property(t => t.Obscob).HasColumnName("obscob");
            Property(t => t.Fmarcada).HasColumnName("fmarcada");
            Property(t => t.Segmento).HasColumnName("segmento");
            Property(t => t.Recino).HasColumnName("recino");
            Property(t => t.Recian).HasColumnName("recian");
            Property(t => t.Odstamp).HasColumnName("odstamp");
            Property(t => t.Escvtmp).HasColumnName("escvtmp");
            Property(t => t.Vtmp).HasColumnName("vtmp");
            Property(t => t.Evtmp).HasColumnName("evtmp");
            Property(t => t.Cobranca).HasColumnName("cobranca");
            Property(t => t.Ftstamp).HasColumnName("ftstamp");
            Property(t => t.Restamp).HasColumnName("restamp");
            Property(t => t.Cambiofixo).HasColumnName("cambiofixo");
            Property(t => t.Edifcambio).HasColumnName("edifcambio");
            Property(t => t.Difcambio).HasColumnName("difcambio");
            Property(t => t.Tipo).HasColumnName("tipo");
            Property(t => t.Pais).HasColumnName("pais");
            Property(t => t.Estab).HasColumnName("estab");
            Property(t => t.Ivav1).HasColumnName("ivav1");
            Property(t => t.Ivav2).HasColumnName("ivav2");
            Property(t => t.Ivav3).HasColumnName("ivav3");
            Property(t => t.Ivav4).HasColumnName("ivav4");
            Property(t => t.Ivav5).HasColumnName("ivav5");
            Property(t => t.Ivav6).HasColumnName("ivav6");
            Property(t => t.Ivav7).HasColumnName("ivav7");
            Property(t => t.Ivav8).HasColumnName("ivav8");
            Property(t => t.Ivav9).HasColumnName("ivav9");
            Property(t => t.Eivav1).HasColumnName("eivav1");
            Property(t => t.Eivav2).HasColumnName("eivav2");
            Property(t => t.Eivav3).HasColumnName("eivav3");
            Property(t => t.Eivav4).HasColumnName("eivav4");
            Property(t => t.Eivav5).HasColumnName("eivav5");
            Property(t => t.Eivav6).HasColumnName("eivav6");
            Property(t => t.Eivav7).HasColumnName("eivav7");
            Property(t => t.Eivav8).HasColumnName("eivav8");
            Property(t => t.Eivav9).HasColumnName("eivav9");
            Property(t => t.Ftccstamp).HasColumnName("ftccstamp");
            Property(t => t.Rdstamp).HasColumnName("rdstamp");
            Property(t => t.Cobrador).HasColumnName("cobrador");
            Property(t => t.Rota).HasColumnName("rota");
            Property(t => t.Clbanco).HasColumnName("clbanco");
            Property(t => t.Clcheque).HasColumnName("clcheque");
            Property(t => t.Valch).HasColumnName("valch");
            Property(t => t.Evalch).HasColumnName("evalch");
            Property(t => t.Valre).HasColumnName("valre");
            Property(t => t.Evalre).HasColumnName("evalre");
            Property(t => t.Mvalre).HasColumnName("mvalre");
            Property(t => t.Intid).HasColumnName("intid");
            Property(t => t.Lestamp).HasColumnName("lestamp");
            Property(t => t.Lrstamp).HasColumnName("lrstamp");
            Property(t => t.Lmstamp).HasColumnName("lmstamp");
            Property(t => t.Tpstamp).HasColumnName("tpstamp");
            Property(t => t.Tpdesc).HasColumnName("tpdesc");
            Property(t => t.Chstamp).HasColumnName("chstamp");
            Property(t => t.Covezes).HasColumnName("covezes");
            Property(t => t.Virs).HasColumnName("virs");
            Property(t => t.Evirs).HasColumnName("evirs");
            Property(t => t.Virsreg).HasColumnName("virsreg");
            Property(t => t.Evirsreg).HasColumnName("evirsreg");
            Property(t => t.Irsdif).HasColumnName("irsdif");
            Property(t => t.Eirsdif).HasColumnName("eirsdif");
            Property(t => t.Difccont).HasColumnName("difccont");
            Property(t => t.Edifccont).HasColumnName("edifccont");
            Property(t => t.Faccstamp).HasColumnName("faccstamp");
            Property(t => t.Faclstamp).HasColumnName("faclstamp");
            Property(t => t.Occstamp).HasColumnName("occstamp");
            Property(t => t.Ousrinis).HasColumnName("ousrinis");
            Property(t => t.Ousrdata).HasColumnName("ousrdata");
            Property(t => t.Ousrhora).HasColumnName("ousrhora");
            Property(t => t.Usrinis).HasColumnName("usrinis");
            Property(t => t.Usrdata).HasColumnName("usrdata");
            Property(t => t.Usrhora).HasColumnName("usrhora");
            Property(t => t.Marcada).HasColumnName("marcada");
            Property(t => t.Dispcbb).HasColumnName("dispcbb");
            Property(t => t.Cbbno).HasColumnName("cbbno");
            Property(t => t.Ivatx1).HasColumnName("ivatx1");
            Property(t => t.Ivatx2).HasColumnName("ivatx2");
            Property(t => t.Ivatx3).HasColumnName("ivatx3");
            Property(t => t.Ivatx4).HasColumnName("ivatx4");
            Property(t => t.Ivatx5).HasColumnName("ivatx5");
            Property(t => t.Ivatx6).HasColumnName("ivatx6");
            Property(t => t.Ivatx7).HasColumnName("ivatx7");
            Property(t => t.Ivatx8).HasColumnName("ivatx8");
            Property(t => t.Ivatx9).HasColumnName("ivatx9");
            Property(t => t.Reexgiva).HasColumnName("reexgiva");
            Property(t => t.Formapag).HasColumnName("formapag");
            Property(t => t.Situacao).HasColumnName("situacao");
            Property(t => t.Cobradovunicre).HasColumnName("cobradovunicre");
        }
    }
}