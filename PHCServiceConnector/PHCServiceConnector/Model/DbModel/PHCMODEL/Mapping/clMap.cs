using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace ConnectorService.Model.PHCModel.Mapping
{
    public class ClMap : EntityTypeConfiguration<Cl>
    {
        public ClMap()
        {
            // Primary Key
            HasKey(t => new { t.No,  t.Estab});

            // Properties
            Property(t => t.Clstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.No)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Estab)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Vendnm)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Ncont)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Nome2)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Moeda)
                .IsRequired()
                .HasMaxLength(11);

            Property(t => t.Fax)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Telefone)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Contacto)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.Morada)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Local)
                .IsRequired()
                .HasMaxLength(43);

            Property(t => t.Codpost)
                .IsRequired()
                .HasMaxLength(45);

            Property(t => t.Zona)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Tipo)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Obs)
                .IsRequired()
                .HasMaxLength(240);

            Property(t => t.Bino)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Bilocal)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Naturalid)
                .IsRequired()
                .HasMaxLength(17);

            Property(t => t.Passaporte)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Conta)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Pagamento)
                .IsRequired()
                .HasMaxLength(28);

            Property(t => t.Cobranca)
                .IsRequired()
                .HasMaxLength(22);

            Property(t => t.Nib)
                .IsRequired()
                .HasMaxLength(28);

            Property(t => t.Imagem)
                .IsRequired()
                .HasMaxLength(120);

            Property(t => t.C1Tele)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.C1Fax)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.C1Func)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.C2Tele)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.C2Fax)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.C2Func)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.C2Tacto)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.C3Tele)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.C3Fax)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.C3Func)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.C3Tacto)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.Descarga)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Segmento)
                .IsRequired()
                .HasMaxLength(25);

            Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(45);

            Property(t => t.Fref)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Ccusto)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Ncusto)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Contalet)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Contaletdes)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Contaletsac)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Tipodesc)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Tlmvl)
                .IsRequired()
                .HasMaxLength(45);

            Property(t => t.Cobrador)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Rota)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Contaainc)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Contaacer)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Eancl)
                .IsRequired()
                .HasMaxLength(35);

            Property(t => t.Url)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.Tpstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Tpdesc)
                .IsRequired()
                .HasMaxLength(55);

            Property(t => t.Pncont)
                .IsRequired()
                .HasMaxLength(2);

            Property(t => t.Cobtele)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Cobfax)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Cobfunc)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Cobtacto)
                .IsRequired()
                .HasMaxLength(45);

            Property(t => t.Ollocal)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Pscm)
                .IsRequired()
                .HasMaxLength(2);

            Property(t => t.Ptcm)
                .IsRequired()
                .HasMaxLength(4);

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

            Property(t => t.Site)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Bizzaddress)
                .IsRequired()
                .HasMaxLength(45);

            Property(t => t.Cass)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Classe)
                .IsRequired()
                .HasMaxLength(30);

            Property(t => t.Lang)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            Property(t => t.Niec)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Gaenome)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(60);

            Property(t => t.Gaecstamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(25);

            Property(t => t.Txftndias)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Txftdias)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Txftdata)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Txftnid)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Txftidnome)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Txftidcontacto)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Txftidnac)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Txftidcont)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Txftidutente)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Txftidbi)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Txftidcob)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Txftmrtot)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Contatit)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Statuspda)
                .IsRequired()
                .HasMaxLength(1);

            Property(t => t.Contafac)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Glncl)
                .IsRequired()
                .HasMaxLength(35);

            Property(t => t.Codfornecedor)
                .IsRequired()
                .HasMaxLength(10);

            Property(t => t.Localentrega)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Obsdoc)
                .IsRequired();

            Property(t => t.Tbprcod)
                .IsRequired()
                .HasMaxLength(15);

            Property(t => t.Area)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            Property(t => t.Id)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Track)
                .IsRequired()
                .HasMaxLength(40);

            Property(t => t.Pin)
                .IsRequired()
                .HasMaxLength(4);

            Property(t => t.Encrpin)
                .IsRequired()
                .HasMaxLength(4);

            Property(t => t.Fuels)
                .IsRequired()
                .HasMaxLength(3);

            Property(t => t.Shop)
                .IsRequired()
                .HasMaxLength(2);

            Property(t => t.Refcli)
                .IsRequired()
                .HasMaxLength(12);

            Property(t => t.Matric)
                .IsRequired()
                .HasMaxLength(15);

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

            Property(t => t.Numcontrepres)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Codprovincia)
                .IsRequired()
                .HasMaxLength(2);

            Property(t => t.Numautorizacaosdd)
                .IsRequired()
                .HasMaxLength(11);

            Property(t => t.Mesesnaopag)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Diaspag)
                .IsRequired()
                .HasMaxLength(20);

            Property(t => t.Descregiva)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.C1Email)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.C2Email)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.C3Email)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Cobemail)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Pcktsynctime)
                .IsRequired()
                .HasMaxLength(8);

            Property(t => t.Motiseimp)
                .IsRequired()
                .HasMaxLength(60);

            Property(t => t.Codmotiseimp)
                .IsRequired()
                .HasMaxLength(2);

            Property(t => t.Distrito)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            ToTable("cl");
            Property(t => t.Clstamp).HasColumnName("clstamp");
            Property(t => t.Nome).HasColumnName("nome");
            Property(t => t.No).HasColumnName("no");
            Property(t => t.Estab).HasColumnName("estab");
            Property(t => t.Vendnm).HasColumnName("vendnm");
            Property(t => t.Ncont).HasColumnName("ncont");
            Property(t => t.Nome2).HasColumnName("nome2");
            Property(t => t.Saldo).HasColumnName("saldo");
            Property(t => t.Esaldo).HasColumnName("esaldo");
            Property(t => t.Moeda).HasColumnName("moeda");
            Property(t => t.Fax).HasColumnName("fax");
            Property(t => t.Telefone).HasColumnName("telefone");
            Property(t => t.Contacto).HasColumnName("contacto");
            Property(t => t.Acmfact).HasColumnName("acmfact");
            Property(t => t.Eacmfact).HasColumnName("eacmfact");
            Property(t => t.Rentval).HasColumnName("rentval");
            Property(t => t.Erentval).HasColumnName("erentval");
            Property(t => t.Eem).HasColumnName("eem");
            Property(t => t.Emno).HasColumnName("emno");
            Property(t => t.Eag).HasColumnName("eag");
            Property(t => t.Agno).HasColumnName("agno");
            Property(t => t.Eid).HasColumnName("eid");
            Property(t => t.Idno).HasColumnName("idno");
            Property(t => t.Efl).HasColumnName("efl");
            Property(t => t.Flno).HasColumnName("flno");
            Property(t => t.Flestab).HasColumnName("flestab");
            Property(t => t.Morada).HasColumnName("morada");
            Property(t => t.Local).HasColumnName("local");
            Property(t => t.Codpost).HasColumnName("codpost");
            Property(t => t.Zona).HasColumnName("zona");
            Property(t => t.Tipo).HasColumnName("tipo");
            Property(t => t.Desconto).HasColumnName("desconto");
            Property(t => t.Vendedor).HasColumnName("vendedor");
            Property(t => t.Vencimento).HasColumnName("vencimento");
            Property(t => t.Plafond).HasColumnName("plafond");
            Property(t => t.Eplafond).HasColumnName("eplafond");
            Property(t => t.Obs).HasColumnName("obs");
            Property(t => t.Preco).HasColumnName("preco");
            Property(t => t.Pais).HasColumnName("pais");
            Property(t => t.Particular).HasColumnName("particular");
            Property(t => t.Bino).HasColumnName("bino");
            Property(t => t.Bidata).HasColumnName("bidata");
            Property(t => t.Bilocal).HasColumnName("bilocal");
            Property(t => t.Naturalid).HasColumnName("naturalid");
            Property(t => t.Passaporte).HasColumnName("passaporte");
            Property(t => t.Conta).HasColumnName("conta");
            Property(t => t.Nascimento).HasColumnName("nascimento");
            Property(t => t.Pagamento).HasColumnName("pagamento");
            Property(t => t.Cobranca).HasColumnName("cobranca");
            Property(t => t.Nib).HasColumnName("nib");
            Property(t => t.Descpp).HasColumnName("descpp");
            Property(t => t.Imagem).HasColumnName("imagem");
            Property(t => t.Odatraso).HasColumnName("odatraso");
            Property(t => t.Tabiva).HasColumnName("tabiva");
            Property(t => t.C1Tele).HasColumnName("c1tele");
            Property(t => t.C1Fax).HasColumnName("c1fax");
            Property(t => t.C1Func).HasColumnName("c1func");
            Property(t => t.C2Tele).HasColumnName("c2tele");
            Property(t => t.C2Fax).HasColumnName("c2fax");
            Property(t => t.C2Func).HasColumnName("c2func");
            Property(t => t.C2Tacto).HasColumnName("c2tacto");
            Property(t => t.C3Tele).HasColumnName("c3tele");
            Property(t => t.C3Fax).HasColumnName("c3fax");
            Property(t => t.C3Func).HasColumnName("c3func");
            Property(t => t.C3Tacto).HasColumnName("c3tacto");
            Property(t => t.Dqtt).HasColumnName("dqtt");
            Property(t => t.Clivd).HasColumnName("clivd");
            Property(t => t.Descarga).HasColumnName("descarga");
            Property(t => t.Nocredit).HasColumnName("nocredit");
            Property(t => t.Segmento).HasColumnName("segmento");
            Property(t => t.Email).HasColumnName("email");
            Property(t => t.Fref).HasColumnName("fref");
            Property(t => t.Ccusto).HasColumnName("ccusto");
            Property(t => t.Ncusto).HasColumnName("ncusto");
            Property(t => t.Naood).HasColumnName("naood");
            Property(t => t.Naomail).HasColumnName("naomail");
            Property(t => t.Contalet).HasColumnName("contalet");
            Property(t => t.Contaletdes).HasColumnName("contaletdes");
            Property(t => t.Contaletsac).HasColumnName("contaletsac");
            Property(t => t.Alimite).HasColumnName("alimite");
            Property(t => t.Dqttval).HasColumnName("dqttval");
            Property(t => t.Tipodesc).HasColumnName("tipodesc");
            Property(t => t.Tlmvl).HasColumnName("tlmvl");
            Property(t => t.Cobrador).HasColumnName("cobrador");
            Property(t => t.Rota).HasColumnName("rota");
            Property(t => t.Contaainc).HasColumnName("contaainc");
            Property(t => t.Contaacer).HasColumnName("contaacer");
            Property(t => t.Eancl).HasColumnName("eancl");
            Property(t => t.Ediexp).HasColumnName("ediexp");
            Property(t => t.Url).HasColumnName("url");
            Property(t => t.Tpstamp).HasColumnName("tpstamp");
            Property(t => t.Tpdesc).HasColumnName("tpdesc");
            Property(t => t.Pncont).HasColumnName("pncont");
            Property(t => t.Cobtele).HasColumnName("cobtele");
            Property(t => t.Cobfax).HasColumnName("cobfax");
            Property(t => t.Cobfunc).HasColumnName("cobfunc");
            Property(t => t.Cobtacto).HasColumnName("cobtacto");
            Property(t => t.Ollocal).HasColumnName("ollocal");
            Property(t => t.Contado).HasColumnName("contado");
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
            Property(t => t.Usaintra).HasColumnName("usaintra");
            Property(t => t.Cobnao).HasColumnName("cobnao");
            Property(t => t.Saldlet).HasColumnName("saldlet");
            Property(t => t.Esaldlet).HasColumnName("esaldlet");
            Property(t => t.Site).HasColumnName("site");
            Property(t => t.Bizzaddress).HasColumnName("bizzaddress");
            Property(t => t.Bizzproto).HasColumnName("bizzproto");
            Property(t => t.Cass).HasColumnName("cass");
            Property(t => t.Classe).HasColumnName("classe");
            Property(t => t.Lang).HasColumnName("lang");
            Property(t => t.Iectisento).HasColumnName("iectisento");
            Property(t => t.Niec).HasColumnName("niec");
            Property(t => t.Gaenome).HasColumnName("gaenome");
            Property(t => t.Gaecstamp).HasColumnName("gaecstamp");
            Property(t => t.Clinica).HasColumnName("clinica");
            Property(t => t.Ftndias).HasColumnName("ftndias");
            Property(t => t.Txftndias).HasColumnName("txftndias");
            Property(t => t.Ftdiasmr).HasColumnName("ftdiasmr");
            Property(t => t.Txftdias).HasColumnName("txftdias");
            Property(t => t.Ftdatasmr).HasColumnName("ftdatasmr");
            Property(t => t.Txftdata).HasColumnName("txftdata");
            Property(t => t.Ftnid).HasColumnName("ftnid");
            Property(t => t.Txftnid).HasColumnName("txftnid");
            Property(t => t.Ftidnome).HasColumnName("ftidnome");
            Property(t => t.Txftidnome).HasColumnName("txftidnome");
            Property(t => t.Ftidcontacto).HasColumnName("ftidcontacto");
            Property(t => t.Txftidcontacto).HasColumnName("txftidcontacto");
            Property(t => t.Ftidnac).HasColumnName("ftidnac");
            Property(t => t.Txftidnac).HasColumnName("txftidnac");
            Property(t => t.Ftidcont).HasColumnName("ftidcont");
            Property(t => t.Txftidcont).HasColumnName("txftidcont");
            Property(t => t.Ftidutente).HasColumnName("ftidutente");
            Property(t => t.Txftidutente).HasColumnName("txftidutente");
            Property(t => t.Ftidbi).HasColumnName("ftidbi");
            Property(t => t.Txftidbi).HasColumnName("txftidbi");
            Property(t => t.Ftidcob).HasColumnName("ftidcob");
            Property(t => t.Txftidcob).HasColumnName("txftidcob");
            Property(t => t.Ftmrtot).HasColumnName("ftmrtot");
            Property(t => t.Txftmrtot).HasColumnName("txftmrtot");
            Property(t => t.Ftumamr).HasColumnName("ftumamr");
            Property(t => t.Paramr).HasColumnName("paramr");
            Property(t => t.Filtrast).HasColumnName("filtrast");
            Property(t => t.Contatit).HasColumnName("contatit");
            Property(t => t.Statuspda).HasColumnName("statuspda");
            Property(t => t.Inactivo).HasColumnName("inactivo");
            Property(t => t.Naoencomenda).HasColumnName("naoencomenda");
            Property(t => t.Clifactor).HasColumnName("clifactor");
            Property(t => t.Contafac).HasColumnName("contafac");
            Property(t => t.Dfront).HasColumnName("dfront");
            Property(t => t.Dsuporte).HasColumnName("dsuporte");
            Property(t => t.Dformacao).HasColumnName("dformacao");
            Property(t => t.Dteam).HasColumnName("dteam");
            Property(t => t.Recdocdig).HasColumnName("recdocdig");
            Property(t => t.Glncl).HasColumnName("glncl");
            Property(t => t.Codfornecedor).HasColumnName("codfornecedor");
            Property(t => t.Localentrega).HasColumnName("localentrega");
            Property(t => t.Obsdoc).HasColumnName("obsdoc");
            Property(t => t.Ecoisento).HasColumnName("ecoisento");
            Property(t => t.Tbprcod).HasColumnName("tbprcod");
            Property(t => t.Area).HasColumnName("area");
            Property(t => t.Exporpos).HasColumnName("exporpos");
            Property(t => t.Temcred).HasColumnName("temcred");
            Property(t => t.Temftglob).HasColumnName("temftglob");
            Property(t => t.Ltyp).HasColumnName("ltyp");
            Property(t => t.Lmlt).HasColumnName("lmlt");
            Property(t => t.Rbal).HasColumnName("rbal");
            Property(t => t.Addd).HasColumnName("addd");
            Property(t => t.Id).HasColumnName("id");
            Property(t => t.Track).HasColumnName("track");
            Property(t => t.Tracknr).HasColumnName("tracknr");
            Property(t => t.Pin).HasColumnName("pin");
            Property(t => t.Encrpin).HasColumnName("encrpin");
            Property(t => t.Blck).HasColumnName("blck");
            Property(t => t.Acc).HasColumnName("acc");
            Property(t => t.Repl).HasColumnName("repl");
            Property(t => t.Odo).HasColumnName("odo");
            Property(t => t.Did).HasColumnName("did");
            Property(t => t.Carr).HasColumnName("carr");
            Property(t => t.Fuels).HasColumnName("fuels");
            Property(t => t.Cw).HasColumnName("cw");
            Property(t => t.Shop).HasColumnName("shop");
            Property(t => t.Refcli).HasColumnName("refcli");
            Property(t => t.Matric).HasColumnName("matric");
            Property(t => t.Desccmb).HasColumnName("desccmb");
            Property(t => t.Descloj).HasColumnName("descloj");
            Property(t => t.Ousrinis).HasColumnName("ousrinis");
            Property(t => t.Ousrdata).HasColumnName("ousrdata");
            Property(t => t.Ousrhora).HasColumnName("ousrhora");
            Property(t => t.Usrinis).HasColumnName("usrinis");
            Property(t => t.Usrdata).HasColumnName("usrdata");
            Property(t => t.Usrhora).HasColumnName("usrhora");
            Property(t => t.Marcada).HasColumnName("marcada");
            Property(t => t.Isperson).HasColumnName("isperson");
            Property(t => t.Radicaltipoemp).HasColumnName("radicaltipoemp");
            Property(t => t.Autofact).HasColumnName("autofact");
            Property(t => t.Numcontrepres).HasColumnName("numcontrepres");
            Property(t => t.Codprovincia).HasColumnName("codprovincia");
            Property(t => t.Autorizacaoactiva).HasColumnName("autorizacaoactiva");
            Property(t => t.Numautorizacaosdd).HasColumnName("numautorizacaosdd");
            Property(t => t.Numseqaut).HasColumnName("numseqaut");
            Property(t => t.Mesesnaopag).HasColumnName("mesesnaopag");
            Property(t => t.Diaspag).HasColumnName("diaspag");
            Property(t => t.Cancpos).HasColumnName("cancpos");
            Property(t => t.Descregiva).HasColumnName("descregiva");
            Property(t => t.C1Email).HasColumnName("c1email");
            Property(t => t.C2Email).HasColumnName("c2email");
            Property(t => t.C3Email).HasColumnName("c3email");
            Property(t => t.Cobemail).HasColumnName("cobemail");
            Property(t => t.Pcktsyncdate).HasColumnName("pcktsyncdate");
            Property(t => t.Pcktsynctime).HasColumnName("pcktsynctime");
            Property(t => t.Motiseimp).HasColumnName("motiseimp");
            Property(t => t.Codmotiseimp).HasColumnName("codmotiseimp");
            Property(t => t.Distrito).HasColumnName("distrito");
            Property(t => t.Ccadmin).HasColumnName("ccadmin");
            Property(t => t.Geramb).HasColumnName("geramb");
        }
    }
}