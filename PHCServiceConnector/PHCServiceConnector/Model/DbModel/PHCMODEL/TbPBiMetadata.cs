using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConnectorService.Model.PHCModel
{
    [MetadataType(typeof(TbPBiMetadata))]
    public partial class TbPBi
    {
        
    }
    [Table("bi")]
    public class TbPBiMetadata
    {
        //char 25
        [Key]
        [Required(AllowEmptyStrings = false,ErrorMessage = "o campo stamp bi nao pode ser nulo")]
        [MaxLength(25,ErrorMessage = "o campo stamp bi nao pode ter mais que 25 caracteres")]
        [Column("bistamp", TypeName = "char", Order = 0)]
        public string TbBibistamp { get; set; }

        //varchar 24
        [Required(AllowEmptyStrings = false, ErrorMessage = "o campo nmdos nao pode ser nulo")]
        [MaxLength(24, ErrorMessage = "o campo nmdos nao pode ter mais que 24 caracteres")]
        [Column("nmdos", TypeName = "varchar", Order = 1)]
        public string TbBinmdos { get; set; }

        [Required]
        [Column("obrano", TypeName = "numeric", Order = 2)]
        [DisplayFormat(NullDisplayText = "Sem dossier",ApplyFormatInEditMode = true)]
        public decimal TbBiobrano { get; set; }

        // char 18
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de referencia nao pode ser nulo")]
        [MaxLength(18, ErrorMessage = "O campo de referencia nao pode ter mais que 18 caracteres")]
        [Column("ref", TypeName = "char", Order = 3)]
        public string TbBiref { get; set; }

        //varchar 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de design nao pode ser nulo")]
        [MaxLength(60, ErrorMessage = "O campo de design nao pode ter mais que 60 caracteres")]
        [Column("design", TypeName = "varchar", Order = 4)]
        public string TbBidesign { get; set; }

        //numeric
        [Required]
        [Column("qtt", TypeName = "numeric", Order = 5)]
        [DisplayFormat(NullDisplayText = "Sem quantidade registado", ApplyFormatInEditMode = true)]
        public decimal TbBiqtt { get; set; }
        
        //numeric
        [Required]
        [Column("qtt2", TypeName = "numeric", Order = 6)]
        [DisplayFormat(NullDisplayText = "Sem quantidade registado", ApplyFormatInEditMode = true)]
        public decimal TbBiqttdois { get; set; }

        //numeric
        [Required]
        [Column("iva", TypeName = "numeric", Order = 7)]
        [DisplayFormat(NullDisplayText = "Sem iva registado", ApplyFormatInEditMode = true)]
        public decimal TbBiiva { get; set; }

        // numeric
        [Required]
        [Column("tabiva", TypeName = "numeric", Order = 8)]
        [DisplayFormat(NullDisplayText = "Sem tabela iva registado", ApplyFormatInEditMode = true)]
        public decimal TbBitabiva { get; set; }

        // numeric
        [Required]
        [Column("armazem", TypeName = "numeric", Order = 9)]
        [DisplayFormat(NullDisplayText = "Sem armazem registado", ApplyFormatInEditMode = true)]
        public decimal TbBiarmazem { get; set; }

        //numeric
        [Required]
        [Column("pu", TypeName = "numeric", Order = 10)]
        [DisplayFormat(NullDisplayText = "Sem pu registado", ApplyFormatInEditMode = true)]
        public decimal TbBipu { get; set; }

        //numeric
        [Required]
        [Column("debito", TypeName = "numeric", Order = 11)]
        [DisplayFormat(NullDisplayText = "Sem debito registado", ApplyFormatInEditMode = true)]
        public decimal TbBidebito { get; set; }

        //numeric
        [Required]
        [Column("prorc", TypeName = "numeric", Order = 12)]
        [DisplayFormat(NullDisplayText = "Sem prorc registado", ApplyFormatInEditMode = true)]
        public decimal TbBiprorc { get; set; }

        //numeric
        [Required]
        [Column("stipo", TypeName = "numeric", Order = 13)]
        [DisplayFormat(NullDisplayText = "Sem tipo registado", ApplyFormatInEditMode = true)]
        public decimal TbBistipo { get; set; }

        //numeric
        [Required]
        [Column("no", TypeName = "numeric", Order = 14)]
        [DisplayFormat(NullDisplayText = "Sem no registado", ApplyFormatInEditMode = true)]
        public decimal TbBino { get; set; }

        //numeric
        [Required]
        [Column("pcusto", TypeName = "numeric", Order = 15)]
        [DisplayFormat(NullDisplayText = "Sem custo registado", ApplyFormatInEditMode = true)]
        public decimal TbBipcusto { get; set; }

        //varchar 50
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de serie nao pode ser nulo")]
        [MaxLength(50, ErrorMessage = "O campo de serie nao pode ter mais que 25 caracteres")]
        [Column("serie", TypeName = "varchar", Order = 16)]
        public string TbBiserie { get; set; }

        //numeric
        [Required]
        [Column("nomquina", TypeName = "numeric", Order = 17)]
        [DisplayFormat(NullDisplayText = "Sem nomaquina registado", ApplyFormatInEditMode = true)]
        public decimal TbBinomquina { get; set; }

        //numeric
        [Required]
        [Column("nopat", TypeName = "numeric", Order = 18)]
        [DisplayFormat(NullDisplayText = "Sem nopat registado", ApplyFormatInEditMode = true)]
        public decimal TbBinopat { get; set; }

        //numeric
        [Required]
        [Column("fno", TypeName = "numeric", Order = 19)]
        [DisplayFormat(NullDisplayText = "Sem fno registado", ApplyFormatInEditMode = true)]
        public decimal TbBifno { get; set; }

        //datetime
        [Required]
        [Column("fdata", TypeName = "datetime", Order = 20)]
        public DateTime TbBifdata { get; set; }

        //varchar 24
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de nmdoc nao pode ser nulo")]
        [MaxLength(24, ErrorMessage = "O campo de nmdoc nao pode ter mais que 24 caracteres")]
        [Column("nmdoc", TypeName = "varchar", Order = 21)]
        public string TbBinmdoc { get; set; }

        //numeric
        [Required]
        [Column("ndoc", TypeName = "numeric", Order = 22)]
        [DisplayFormat(NullDisplayText = "Sem numero documento registado", ApplyFormatInEditMode = true)]
        public decimal TbBindoc { get; set; }

        //numeric
        [Required]
        [Column("ndos", TypeName = "numeric", Order = 23)]
        [DisplayFormat(NullDisplayText = "Sem numero dossier registado", ApplyFormatInEditMode = true)]
        public decimal TbBindos { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de referencia fo nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de referencia fo nao pode ter mais que 20 caracteres")]
        [Column("forref", TypeName = "varchar", Order = 24)]
        public string TbBiforref { get; set; }

        //decimal
        [Required]
        [Column("txiva", TypeName = "numeric", Order = 25)]
        [DisplayFormat(NullDisplayText = "Sem taxa iva registado", ApplyFormatInEditMode = true)]
        public decimal TbBitxiva { get; set; }

        //datetime
        [Required]
        [Column("rdata", TypeName = "datetime", Order = 26)]
        public DateTime TbBirdata { get; set; }

        //datetime
        [Required]
        [Column("dedata", TypeName = "datetime", Order = 27)]
        public DateTime TbBidedata { get; set; }

        //datetime 
        [Required]
        [Column("atedata", TypeName = "datetime", Order = 28)]
        public DateTime TbBiatedata { get; set; }

        //varchar 40
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de observacoes nao pode ser nulo")]
        [MaxLength(40, ErrorMessage = "O campo de observacoes nao pode ter mais que 40 caracteres")]
        [Column("lobs", TypeName = "varchar", Order = 29)]
        public string TbBilobs { get; set; }

        //numeric
        [Required]
        [Column("ldossier", TypeName = "numeric", Order = 30)]
        [DisplayFormat(NullDisplayText = "Sem dossier registado", ApplyFormatInEditMode = true)]
        public decimal TbBildossier { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de dossier nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de dossier nao pode ter mais que 20 caracteres")]
        [Column("obranome", TypeName = "varchar", Order = 31)]
        public string TbBiobranome { get; set; }

        //bit
        [Required]
        [Column("fechada",TypeName = "bit",Order = 32)]
        public bool TbBifechada { get; set; }

        //datetime
        [Required]
        [Column("datafinal", TypeName = "datetime", Order = 33)]
        public DateTime TbBidatafinal { get; set; }

        //datetime
        [Required]
        [Column("dataobra", TypeName = "datetime", Order = 34)]
        public DateTime TbBidataobra { get; set; }

        //datetime
        [Required]
        [Column("dataopen", TypeName = "datetime", Order = 35)]
        public DateTime TbBidataopen { get; set; }

        //datetime
        [Required]
        [Column("datafecho", TypeName = "datetime", Order = 36)]
        public DateTime TbBidatafecho { get; set; }

        //numeic
        [Column("tecnico", TypeName = "numeric", Order = 37)]
        [DisplayFormat(NullDisplayText = "Sem tecnico registado", ApplyFormatInEditMode = true)]
        public decimal TbBitecnico { get; set; }

        //varchar 12
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de maquina nao pode ser nulo")]
        [MaxLength(12, ErrorMessage = "O campo de maquina nao pode ter mais que 12 caracteres")]
        [Column("maquina", TypeName = "varchar", Order = 38)]
        public string TbBimaquina { get; set; }

        //varchar 12
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de maquina nao pode ser nulo")]
        [MaxLength(12, ErrorMessage = "O campo de marca nao pode ter mais que 12 caracteres")]
        [Column("marca", TypeName = "varchar", Order = 39)]
        public string TbBimarca { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de zona nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de zona nao pode ter mais que 20 caracteres")]
        [Column("zona", TypeName = "varchar", Order = 40)]
        public string TbBizona { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de litem nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de litem nao pode ter mais que 20 caracteres")]
        [Column("litem", TypeName = "varchar", Order = 41)]
        public string TbBilitem { get; set; }

        //numeric
        [Required]
        [Column("vumoeda", TypeName = "numeric", Order = 42)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBivumoeda { get; set; }

        //bit
        [Required]
        [Column("resfor",TypeName = "bit",Order = 43)]
        public bool TbBiresfor { get; set; }

        //bit
        [Required]
        [Column("rescli",TypeName = "bit",Order = 44)]
        public bool TbBirescli { get; set; }

        //bit
        [Required]
        [Column("resrec",TypeName = "bit",Order = 45)]
        public bool TbBiresrec { get; set; }


        //bit
        [Required]
        [Column("iprint",TypeName = "bit",Order = 46)]
        public bool TbBiiprint { get; set; }

        //varchar 40
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de observacoes nao pode ser nulo")]
        [MaxLength(40, ErrorMessage = "O campo de observacoes nao pode ter mais que 40 caracteres")]
        [Column("lobs2", TypeName = "varchar", Order = 47)]
        public string TbBilobsd { get; set; }

        //varchar 40
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de observacoes nao pode ser nulo")]
        [MaxLength(40, ErrorMessage = "O campo de observacoes nao pode ter mais que 40 caracteres")]
        [Column("litem2", TypeName = "varchar", Order = 48)]
        public string TbBilitemd { get; set; }

        //varchar 40
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de observacoes nao pode ser nulo")]
        [MaxLength(40, ErrorMessage = "O campo de observacoes nao pode ter mais que 40 caracteres")]
        [Column("lobs3", TypeName = "varchar", Order = 49)]
        public string TbBilobst { get; set; }

        //decimal
        [Required]
        [Column("estab", TypeName = "numeric", Order = 50)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBiestabl { get; set; }

        //bit
        [Required]
        [Column("resusr", TypeName = "bit", Order = 51)]
        public bool TbBiresusr { get; set; }

        //numeric
        [Required]
        [Column("ar2mazem", TypeName = "numeric", Order = 52)]
        [DisplayFormat(NullDisplayText = "Sem segundo armazem registado", ApplyFormatInEditMode = true)]
        public decimal TbBiardmazem { get; set; }

        //bit
        [Required]
        [Column("composto",TypeName = "bit",Order = 53)]
        public bool TbBicomposto { get; set; }

        //bit
        [Required]
        [Column("compostoori", TypeName = "bit", Order = 54)]
        public bool TbBicompostoori { get; set; }

        //varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de rec nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de rec nao pode ter mais que 25 caracteres")]
        [Column("lrecno", TypeName = "varchar", Order = 55)]
        public string TbBilrecno { get; set; }

        //decimal
        [Required]
        [Column("lordem", TypeName = "numeric", Order = 56)]
        [DisplayFormat(NullDisplayText = "Sem ordem registado", ApplyFormatInEditMode = true)]
        public decimal TbBilordem { get; set; }

        //bit
        [Required]
        [Column("fmarcada",TypeName = "bit",Order = 57)]
        public bool TbBifmarcada { get; set; }

        //bit
        [Required]
        [Column("producao", TypeName = "bit", Order = 58)]
        public bool TbBiproducao { get; set; }

        //varchar 43
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo local nao pode ser nulo")]
        [MaxLength(43, ErrorMessage = "O campo local nao pode ter mais que 43 caracteres")]
        [Column("local", TypeName = "varchar", Order = 59)]
        public string TbBilocal { get; set; }

        //varchar 55
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo morada nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo morada nao pode ter mais que 55 caracteres")]
        [Column("morada", TypeName = "varchar", Order = 60)]
        public string TbBimorada { get; set; }

        //varchar 45
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo codigo postal nao pode ser nulo")]
        [MaxLength(45, ErrorMessage = "O campo codigo postal nao pode ter mais que 45 caracteres")]
        [Column("codpost", TypeName = "varchar", Order = 61)]
        public string TbBicodpost { get; set; }

        //char 55
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo nome nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo nome nao pode ter mais que 55 caracteres")]
        [Column("nome", TypeName = "char", Order = 62)]
        public string TbBinome { get; set; }


        //numeric
        [Required]
        [Column("vendedor", TypeName = "numeric", Order = 63)]
        [DisplayFormat(NullDisplayText = "Sem numero vendedor registado", ApplyFormatInEditMode = true)]
        public decimal TbBivendedor { get; set; }


        //alterar a ordem a partir daqui
        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo vendnm nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo vendnm nao pode ter mais que 20 caracteres")]
        [Column("vendnm", TypeName = "varchar", Order = 64)]
        public string TbBivendnm { get; set; }

        //bool
        [Required]
        [Column("tabfor", TypeName = "bit", Order = 65)]
        public bool TbBitabfor { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo tabela1 nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo tabela1 nao pode ter mais que 20 caracteres")]
        [Column("tabela1", TypeName = "varchar", Order = 66)]
        public string TbBitabelau { get; set; }

        //bit
        [Required]
        [Column("descli", TypeName = "bit", Order = 67)]
        public bool Tbbidescli { get; set; }

        //varchar 18
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo reff nao pode ser nulo")]
        [MaxLength(18, ErrorMessage = "O campo reff nao pode ter mais que 18 caracteres")]
        [Column("reff", TypeName = "varchar", Order = 68)]
        public string TbBireff { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo lote nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo lote nao pode ter mais que 30 caracteres")]
        [Column("lote", TypeName = "varchar", Order = 69)]
        public string TbBilote { get; set; }

        //bit
        [Required]
        [Column("ivainc", TypeName = "bit", Order = 70)]
        public bool TbBiivainc { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo cor nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo cor nao pode ter mais que 25 caracteres")]
        [Column("cor", TypeName = "char", Order = 71)]
        public string Tbbicor { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo tam nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo tam nao pode ter mais que 25 caracteres")]
        [Column("tam", TypeName = "char", Order = 72)]
        public string TbBitam { get; set; }

        //varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo segmento nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo segmento nao pode ter mais que 25 caracteres")]
        [Column("segmento", TypeName = "varchar", Order = 73)]
        public string TbBisegmento { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo bofref nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo bofref nao pode ter mais que 20 caracteres")]
        [Column("bofref", TypeName = "varchar", Order = 74)]
        public string TbBibofref { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo bifref nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo bifref nao pode ter mais que 20 caracteres")]
        [Column("bifref", TypeName = "varchar", Order = 75)]
        public string Tbbibifref { get; set; }

        //numeric
        [Required]
        [Column("grau", TypeName = "numeric", Order = 76)]
        [DisplayFormat(NullDisplayText = "Sem grau registado", ApplyFormatInEditMode = true)]
        public decimal TbBigrau { get; set; }

        //numeric
        [Required]
        [Column("partes", TypeName = "numeric", Order = 77)]
        [DisplayFormat(NullDisplayText = "Sem partes registado", ApplyFormatInEditMode = true)]
        public decimal TbBipartes { get; set; }

        //numeric
        [Required]
        [Column("partes2", TypeName = "numeric", Order = 78)]
        [DisplayFormat(NullDisplayText = "Sem partes registado", ApplyFormatInEditMode = true)]
        public decimal TbBipartesd { get; set; }

        //numeric
        [Required]
        [Column("altura", TypeName = "numeric", Order = 79)]
        [DisplayFormat(NullDisplayText = "Sem altura registado", ApplyFormatInEditMode = true)]
        public decimal TbBialtura { get; set; }

        //numeric
        [Required]
        [Column("largura", TypeName = "numeric", Order = 80)]
        [DisplayFormat(NullDisplayText = "Sem largura registado", ApplyFormatInEditMode = true)]
        public decimal TbBilargura { get; set; }

        //numeric
        [Required]
        [Column("espessura", TypeName = "numeric", Order = 81)]
        [DisplayFormat(NullDisplayText = "Sem espessura registado", ApplyFormatInEditMode = true)]
        public decimal TbBiespessura { get; set; }

        //varchar 50
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de biserie nao pode ser nulo")]
        [MaxLength(50, ErrorMessage = "O campo de biserie nao pode ter mais que 50 caracteres")]
        [Column("biserie", TypeName = "varchar", Order = 82)]
        public string TbBibiserie { get; set; }

        //bit
        [Required]
        [Column("infref", TypeName = "bit", Order = 83)]
        public bool TbBiinfref { get; set; }

        //bit
        [Required]
        [Column("linfref", TypeName = "bit", Order = 84)]
        public bool TbBilifref { get; set; }

        //decimal
        [Required]
        [Column("uni2qtt", TypeName = "numeric", Order = 85)]
        [DisplayFormat(NullDisplayText = "Sem unidade dois registado", ApplyFormatInEditMode = true)]
        public decimal TbBiunidqtt { get; set; }

        //decimal
        [Required]
        [Column("epu", TypeName = "numeric", Order = 86)]
        [DisplayFormat(NullDisplayText = "Sem  registado", ApplyFormatInEditMode = true)]
        public decimal Tbbiepu { get; set; }

        //numeric
        [Required]
        [Column("edebito", TypeName = "numeric", Order = 87)]
        [DisplayFormat(NullDisplayText = "Sem  registado", ApplyFormatInEditMode = true)]
        public decimal TbBiedebito { get; set; }

        //numeric
        [Required]
        [Column("eprorc", TypeName = "numeric", Order = 88)]
        [DisplayFormat(NullDisplayText = "Sem  registado", ApplyFormatInEditMode = true)]
        public decimal TbBieprorc { get; set; }

        //numeric
        [Required]
        [Column("epcusto", TypeName = "numeric", Order = 89)]
        [DisplayFormat(NullDisplayText = "Sem  registado", ApplyFormatInEditMode = true)]
        public decimal TbBiepcusto { get; set; }

        //numeric
        [Required]
        [Column("ttdeb", TypeName = "numeric", Order = 90)]
        [DisplayFormat(NullDisplayText = "Sem  registado", ApplyFormatInEditMode = true)]
        public decimal TbBittdeb { get; set; }

        //numeric
        [Required]
        [Column("ettdeb", TypeName = "numeric", Order = 91)]
        [DisplayFormat(NullDisplayText = "Sem  registado", ApplyFormatInEditMode = true)]
        public decimal TbBiettdeb { get; set; }

        //numeric
        [Required]
        [Column("ttmoeda", TypeName = "numeric", Order = 92)]
        [DisplayFormat(NullDisplayText = "Sem  registado", ApplyFormatInEditMode = true)]
        public decimal TbBittmoeda { get; set; }

        //mudar a ordem a partir daqui mais 1
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo segmento nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo segmento nao pode ter mais que 20 caracteres")]
        [Column("adoc", TypeName = "varchar", Order = 93)]
        public string TbBiadoc { get; set; }

        //numeric
        [Required]
        [Column("binum1", TypeName = "numeric", Order = 94)]
        [DisplayFormat(NullDisplayText = "Sem  registado", ApplyFormatInEditMode = true)]
        public decimal TbBibinumu { get; set; }

        //numeric
        [Required]
        [Column("binum2", TypeName = "numeric", Order = 95)]
        [DisplayFormat(NullDisplayText = "Sem  registado", ApplyFormatInEditMode = true)]
        public decimal TbBibinumd { get; set; }

        //varchar 18
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de stamp nao pode ser nulo")]
        [MaxLength(18, ErrorMessage = "O campo de stamp nao pode ter mais que 18 caracteres")]
        [Column("codigo", TypeName = "varchar", Order = 96)]
        public string TbBicodigo { get; set; }

        //numeric
        [Required]
        [Column("cpoc", TypeName = "numeric", Order = 97)]
        [DisplayFormat(NullDisplayText = "Sem  cpoc registado", ApplyFormatInEditMode = true)]
        public decimal TbBicpoc { get; set; }

        //bit
        [Required]
        [Column("stns", TypeName = "bit", Order = 98)]
        public bool TbBistns { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo obistamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo obistamp  nao pode ter mais que 25 caracteres")]
        [Column("obistamp", TypeName = "char", Order = 99)]
        public string TbBiobistamp { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo oobistamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo oobistamp nao pode ter mais que 25 caracteres")]
        [Column("oobistamp", TypeName = "char", Order = 100)]
        public string TbBioobistamp { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo usr 1 nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo  usr 1nao pode ter mais que 20 caracteres")]
        [Column("usr1", TypeName = "varchar", Order = 101)]
        public string TbBiusru { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo usr 2 nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo  nao pode ter mais que 20 caracteres")]
        [Column("usr2", TypeName = "varchar", Order = 102)]
        public string TbBiusrd { get; set; }

        //varchar 35
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo usr 3 nao pode ser nulo")]
        [MaxLength(35, ErrorMessage = "O campo usr 3 nao pode ter mais que 35 caracteres")]
        [Column("usr3", TypeName = "varchar", Order = 103)]
        public string TbBiusrt { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo usr4  nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo  usr4nao pode ter mais que 20 caracteres")]
        [Column("usr4", TypeName = "varchar", Order = 104)]
        public string TbBiusrq { get; set; }

        //varchar 120
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo usr4 nao pode ser nulo")]
        [MaxLength(120, ErrorMessage = "O campo usr4 nao pode ter mais que 120 caracteres")]
        [Column("usr5", TypeName = "varchar", Order = 105)]
        public string TbBiusrc { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo usr6 nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo usr6 nao pode ter mais que 30 caracteres")]
        [Column("usr6", TypeName = "varchar", Order = 106)]
        public string TbBiusrs { get; set; }

        //bit
        [Required]
        [Column("usalote", TypeName = "bit", Order = 107)]
        public bool TbBiusalote { get; set; }

        //bit
        [Required]
        [Column("texteis", TypeName = "bit", Order = 108)]
        public bool TbBitexteis { get; set; }


        //varchar 4
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo unidade nao pode ser nulo")]
        [MaxLength(4, ErrorMessage = "O campo unidade nao pode ter mais que 4 caracteres")]
        [Column("unidade", TypeName = "varchar", Order = 109)]
        public string TbBiunidade { get; set; }

        //varchar 4
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo unidade2 nao pode ser nulo")]
        [MaxLength(4, ErrorMessage = "O campo  nao pode ter mais que 4 caracteres")]
        [Column("unidade2", TypeName = "varchar", Order = 110)]
        public string TbBiunidaded { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo oftstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo oftstamp nao pode ter mais que 25 caracteres")]
        [Column("oftstamp", TypeName = "char", Order = 111)]
        public string TbBioftstamp { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo ofostamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo ofostamp nao pode ter mais que 25 caracteres")]
        [Column("ofostamp", TypeName = "char", Order = 112)]
        public string TbBiofostamp { get; set; }

        //bit
        [Required]
        [Column("promo", TypeName = "bit", Order = 113)]
        public bool TbBipromo { get; set; }

        //bit
        [Required]
        [Column("epromo", TypeName = "bit", Order = 114)]
        public bool TbBiepromo { get; set; }

        //varchar 18
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo familia nao pode ser nulo")]
        [MaxLength(18, ErrorMessage = "O campo familia nao pode ter mais que 18 caracteres")]
        [Column("familia", TypeName = "char", Order = 115)]
        public string TbBifamilia { get; set; }

        //bit
        [Required]
        [Column("sattotal", TypeName = "bit", Order = 116)]
        public bool TbBisattotal { get; set; }

        //bit
        [Required]
        [Column("noserie", TypeName = "bit", Order = 117)]
        public bool TbBinoserie { get; set; }


        //numeric
        [Required]
        [Column("slvu", TypeName = "numeric", Order = 118)]
        [DisplayFormat(NullDisplayText = "Sem slvu registado", ApplyFormatInEditMode = true)]
        public decimal TbBislvu { get; set; }

        //numeric
        [Required]
        [Column("eslvu", TypeName = "numeric", Order = 119)]
        [DisplayFormat(NullDisplayText = "Sem  registado", ApplyFormatInEditMode = true)]
        public decimal TbBieslvu { get; set; }

        //numeric
        [Required]
        [Column("sltt", TypeName = "numeric", Order = 120)]
        [DisplayFormat(NullDisplayText = "Sem sltt registado", ApplyFormatInEditMode = true)]
        public decimal TbBisltt { get; set; }

        //numeric
        [Required]
        [Column("esltt", TypeName = "numeric", Order = 121)]
        [DisplayFormat(NullDisplayText = "Sem esltt registado", ApplyFormatInEditMode = true)]
        public decimal TbBiesltt { get; set; }

        //numeric

        [Required]
        [Column("slvumoeda", TypeName = "numeric", Order = 122)]
        [DisplayFormat(NullDisplayText = "Sem  registado", ApplyFormatInEditMode = true)]
        public decimal TbBislvumoeda { get; set; }

        //numeric
        [Required]
        [Column("slttmoeda", TypeName = "numeric", Order = 123)]
        [DisplayFormat(NullDisplayText = "Sem slttmoeda registado", ApplyFormatInEditMode = true)]
        public decimal TbBislttmoeda { get; set; }

        //numeric
        [Required]
        [Column("ncmassa", TypeName = "numeric", Order = 124)]
        [DisplayFormat(NullDisplayText = "Sem ncmassa registado", ApplyFormatInEditMode = true)]
        public decimal TbBincmassa { get; set; }

        //numeric
        [Required]
        [Column("ncunsup", TypeName = "numeric", Order = 125)]
        [DisplayFormat(NullDisplayText = "Sem ncunsup registado", ApplyFormatInEditMode = true)]
        public decimal TbBincunsup { get; set; }

        //numeric
        [Required]
        [Column("ncvest", TypeName = "numeric", Order = 126)]
        [DisplayFormat(NullDisplayText = "Sem ncvest registado", ApplyFormatInEditMode = true)]
        public decimal TbBincvest { get; set; }

        //numeric
        [Required]
        [Column("encvest", TypeName = "numeric", Order = 127)]
        [DisplayFormat(NullDisplayText = "Sem encvest registado", ApplyFormatInEditMode = true)]
        public decimal TbBiencvest { get; set; }

        //varchar 13
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de nccod nao pode ser nulo")]
        [MaxLength(13, ErrorMessage = "O campo nccod nao pode ter mais que 13 caracteres")]
        [Column("nccod", TypeName = "varchar", Order = 128)]
        public string TbBinccod { get; set; }

        //vachar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ncinteg nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo ncinteg nao pode ter mais que 25 caracteres")]
        [Column("ncinteg", TypeName = "varchar", Order = 129)]
        public string TbBincinteg { get; set; }

        //numeric
        [Required]
        [Column("classif", TypeName = "numeric", Order = 130)]
        [DisplayFormat(NullDisplayText = "Sem classif registado", ApplyFormatInEditMode = true)]
        public decimal TbBiclassif { get; set; }

        //varchar 15
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de classifc nao pode ser nulo")]
        [MaxLength(15, ErrorMessage = "O campo classifc nao pode ter mais que 15 caracteres")]
        [Column("classifc", TypeName = "varchar", Order = 131)]
        public string TbBiclassifc { get; set; }

        //varchar 10
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de posic nao pode ser nulo")]
        [MaxLength(10, ErrorMessage = "O campo posic nao pode ter mais que 10 caracteres")]
        [Column("posic", TypeName = "varchar", Order = 132)]
        public string TbBiposic { get; set; }

        //numeric
        [Required]
        [Column("desconto", TypeName = "numeric", Order = 133)]
        [DisplayFormat(NullDisplayText = "Sem  registado", ApplyFormatInEditMode = true)]
        public decimal TbBidesconto { get; set; }

        //numeric
        [Required]
        [Column("desc2", TypeName = "numeric", Order = 134)]
        [DisplayFormat(NullDisplayText = "Sem desconto registado", ApplyFormatInEditMode = true)]
        public decimal TbBidescd { get; set; }

        //numeric
        [Required]
        [Column("desc3", TypeName = "numeric", Order = 135)]
        [DisplayFormat(NullDisplayText = "Sem desconto registado", ApplyFormatInEditMode = true)]
        public decimal TbBidesct { get; set; }

        //numeric
        [Required]
        [Column("desc4", TypeName = "numeric", Order = 136)]
        [DisplayFormat(NullDisplayText = "Sem  registado", ApplyFormatInEditMode = true)]
        public decimal TbBidescq { get; set; }

        //numeric
        [Required]
        [Column("desc5", TypeName = "numeric", Order = 137)]
        [DisplayFormat(NullDisplayText = "Sem  registado", ApplyFormatInEditMode = true)]
        public decimal TbBidescc { get; set; }

        //numeric
        [Required]
        [Column("desc6", TypeName = "numeric", Order = 138)]
        [DisplayFormat(NullDisplayText = "Sem  registado", ApplyFormatInEditMode = true)]
        public decimal TbBidescs { get; set; }

        //text
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de series nao pode ser nulo")]
        [Column("series", TypeName = "text", Order = 139)]
        public string TbBiseries { get; set; }

        //text
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de series nao pode ser nulo")]
        [Column("series2", TypeName = "text", Order = 140)]
        public string TbBiseriesd { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de centro c nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de centro c nao pode ter mais que 20 caracteres")]
        [Column("ccusto", TypeName = "varchar", Order = 141)]
        public string TbBiccusto { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de custos nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de custos nao pode ter mais que 20 caracteres")]
        [Column("ncusto", TypeName = "varchar", Order = 142)]
        public string TbBincusto { get; set; }

        //numeric
        [Required]
        [Column("num1", TypeName = "numeric", Order = 143)]
        [DisplayFormat(NullDisplayText = "Sem numero registado", ApplyFormatInEditMode = true)]
        public decimal TbBinumu { get; set; }

        //bit
        [Required]
        [Column("fechabo", TypeName = "bit", Order = 144)]
        public bool TbBifechabo { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de  nao pode ter mais que 25 caracteres")]
        [Column("oobostamp", TypeName = "char", Order = 145)]
        public string TbBioobostamp { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ltab1 nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de ltab nao pode ter mais que 20 caracteres")]
        [Column("ltab1", TypeName = "varchar", Order = 146)]
        public string TbBiltabu { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ltab nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo ltab nao pode ter mais que 20 caracteres")]
        [Column("ltab2", TypeName = "varchar", Order = 147)]
        public string TbBiltabd { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ltab nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo ltab nao pode ter mais que 20 caracteres")]
        [Column("ltab3", TypeName = "varchar", Order = 148)]
        public string TbBiltabt { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ltab nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo ltab nao pode ter mais que 20 caracteres")]
        [Column("ltab4", TypeName = "varchar", Order = 149)]
        public string TbBiltabq { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ltab nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo ltab nao pode ter mais que 20 caracteres")]
        [Column("ltab5", TypeName = "varchar", Order = 150)]
        public string TbBiltabc { get; set; }

        //varchar 18
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de fami nao pode ser nulo")]
        [MaxLength(18, ErrorMessage = "O campo fami nao pode ter mais que 20 caracteres")]
        [Column("fami", TypeName = "varchar", Order = 151)]
        public string TbBifami { get; set; }

        //decimal
        [Required]
        [Column("pctfami", TypeName = "numeric", Order = 152)]
        [DisplayFormat(NullDisplayText = "Sem pctfami registado", ApplyFormatInEditMode = true)]
        public decimal TbBipctfami { get; set; }

        //bit
        [Required]
        [Column("adjudicada", TypeName = "bit", Order = 153)]
        public bool Tbbiadjudicada { get; set; }

        //numeric
        [Required]
        [Column("tieca", TypeName = "numeric", Order = 154)]
        [DisplayFormat(NullDisplayText = "Sem tieca registado", ApplyFormatInEditMode = true)]
        public decimal TbBitieca { get; set; }

        //numeric
        [Required]
        [Column("etieca", TypeName = "numeric", Order = 155)]
        [DisplayFormat(NullDisplayText = "Sem etieca registado", ApplyFormatInEditMode = true)]
        public decimal TbBietieca { get; set; }

        //numeric
        [Required]
        [Column("mtieca", TypeName = "numeric", Order = 156)]
        [DisplayFormat(NullDisplayText = "Sem mtieca registado", ApplyFormatInEditMode = true)]
        public decimal TbBimtieca { get; set; }

        //numeric
        [Required]
        [Column("volume", TypeName = "numeric", Order = 157)]
        [DisplayFormat(NullDisplayText = "Sem volume registado", ApplyFormatInEditMode = true)]
        public decimal TbBivolume { get; set; }

        //bit
        [Required]
        [Column("iecasug", TypeName = "bit", Order = 158)]
        public bool TbBiiecasug { get; set; }

        //decimal
        [Required]
        [Column("iecagrad", TypeName = "numeric", Order = 159)]
        [DisplayFormat(NullDisplayText = "Sem iecagrad registado", ApplyFormatInEditMode = true)]
        public decimal TbBiiecagrad { get; set; }

        //varchar 4
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de iecacodisen nao pode ser nulo")]
        [MaxLength(4, ErrorMessage = "O campo de iecacodisen nao pode ter mais que 4 caracteres")]
        [Column("iecacodisen", TypeName = "varchar", Order = 160)]
        public string TbBiiecacodisen { get; set; }

        //numeric
        [Required]
        [Column("peso", TypeName = "numeric", Order = 161)]
        [DisplayFormat(NullDisplayText = "Sem peso registado", ApplyFormatInEditMode = true)]
        public decimal TbBipeso { get; set; }

        //numeric
        [Required]
        [Column("pesobruto", TypeName = "numeric", Order = 162)]
        [DisplayFormat(NullDisplayText = "Sem pesobruto registado", ApplyFormatInEditMode = true)]
        public decimal TbBipesobruto { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de codfiscal nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de codfiscal nao pode ter mais que 20 caracteres")]
        [Column("codfiscal", TypeName = "varchar", Order = 163)]
        public string TbBicodfiscal { get; set; }

        //text
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de dgeral nao pode ser nulo")]
        [Column("dgeral", TypeName = "varchar", Order = 164)]
        public string TbBidgeral { get; set; }

        //bit
        [Required]
        [Column("temoci", TypeName = "bit", Order = 165)]
        public bool TbBitemoci { get; set; }

        //bit
        [Required]
        [Column("temomi", TypeName = "bit", Order = 166)]
        public bool TbBitemomi { get; set; }

        //bit
        [Required]
        [Column("temsubemp", TypeName = "bit", Order = 167)]
        public bool TbBitemsubemp { get; set; }

        //numeric
        [Required]
        [Column("encargo", TypeName = "numeric", Order = 168)]
        [DisplayFormat(NullDisplayText = "Sem encargo registado", ApplyFormatInEditMode = true)]
        public decimal TbBiencargo { get; set; }

        //numeric
        [Required]
        [Column("eencargo", TypeName = "numeric", Order = 169)]
        [DisplayFormat(NullDisplayText = "Sem encargo registado", ApplyFormatInEditMode = true)]
        public decimal TbBieencargo { get; set; }

        //numeric
        [Required]
        [Column("ustoind", TypeName = "numeric", Order = 170)]
        [DisplayFormat(NullDisplayText = "Sem ustoind registado", ApplyFormatInEditMode = true)]
        public decimal TbBicustoind { get; set; }

        //char 30

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de tiposemp nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo de tiposemp nao pode ter mais que 30 caracteres")]
        [Column("tiposemp", TypeName = "char", Order = 171)]
        public string TbBitiposemp { get; set; }

        //bit
        [Required]
        [Column("pvok", TypeName = "bit", Order = 172)]
        public bool TbBipvok { get; set; }

        //bit
        [Required]
        [Column("boclose", TypeName = "bit", Order = 173)]
        public bool TbBiboclose { get; set; }

        //datetime
        [Required]
        [Column("dtclose", TypeName = "datetime", Order = 174)]
        public DateTime TbBidtclose { get; set; }

        //varchar 10
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de quarto nao pode ser nulo")]
        [MaxLength(10, ErrorMessage = "O campo de quarto nao pode ter mais que 10 caracteres")]
        [Column("quarto", TypeName = "varchar", Order = 175)]
        public string TbBiquarto { get; set; }

        //bit
        [Required]
        [Column("emconf", TypeName = "bit", Order = 176)]
        public bool TbBiemconf { get; set; }

        //varchar 55
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de efornecedor nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de efornecedor nao pode ter mais que 55 caracteres")]
        [Column("efornecedor", TypeName = "varchar", Order = 177)]
        public string TbBiefornecedor { get; set; }

        //numeric
        [Column("efornec", TypeName = "numeric", Order = 178)]
        [DisplayFormat(NullDisplayText = "Sem efornec registado", ApplyFormatInEditMode = true)]
        public decimal TbBiefornec { get; set; }

        // numeric
        [Column("efornestab", TypeName = "numeric", Order = 179)]
        [DisplayFormat(NullDisplayText = "Sem efornestab registado", ApplyFormatInEditMode = true)]
        public decimal TbBiefornestab { get; set; }

        //bit
        [Required]
        [Column("cativo", TypeName = "bit", Order = 180)]
        public bool TbBicativo { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de optstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de optstamp nao pode ter mais que 25 caracteres")]
        [Column("optstamp", TypeName = "char", Order = 181)]
        public string TbBioptstamp { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de oristamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de oristamp nao pode ter mais que 25 caracteres")]
        [Column("oristamp", TypeName = "char", Order = 182)]
        public string TbBioristamp { get; set; }

        //bit
        [Required]
        [Column("temeco", TypeName = "bit", Order = 183)]
        public bool TbBitemeco { get; set; }

        //numeric
        [Column("ecoval", TypeName = "numeric", Order = 184)]
        [DisplayFormat(NullDisplayText = "Sem  registado", ApplyFormatInEditMode = true)]
        public decimal TbBiecoval { get; set; }

        //numeric
        [Column("eecoval", TypeName = "numeric", Order = 185)]
        [DisplayFormat(NullDisplayText = "Sem eecoval registado", ApplyFormatInEditMode = true)]
        public decimal TbBieecoval { get; set; }

        //numeric
        [Column("tecoval", TypeName = "numeric", Order = 186)]
        [DisplayFormat(NullDisplayText = "Sem tecoval registado", ApplyFormatInEditMode = true)]
        public decimal TbBitecoval { get; set; }

        //numeric
        [Column("etecoval", TypeName = "numeric", Order = 187)]
        [DisplayFormat(NullDisplayText = "Sem etecoval registado", ApplyFormatInEditMode = true)]
        public decimal TbBietecoval { get; set; }

        //numeric
        [Column("ecoval2", TypeName = "numeric", Order = 188)]
        [DisplayFormat(NullDisplayText = "Sem ecoval2 registado", ApplyFormatInEditMode = true)]
        public decimal TbBiecovald { get; set; }

        //numeric
        [Column("eecoval2", TypeName = "numeric", Order = 189)]
        [DisplayFormat(NullDisplayText = "Sem eecoval2 registado", ApplyFormatInEditMode = true)]
        public decimal TbBieecovald { get; set; }

        //numeric
        [Column("tecoval2", TypeName = "numeric", Order = 190)]
        [DisplayFormat(NullDisplayText = "Sem  registado", ApplyFormatInEditMode = true)]
        public decimal TbBitecovald { get; set; }

        //numeric
        [Column("etecoval2", TypeName = "numeric", Order = 191)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBietecovald { get; set; }

        //bit
        [Required]
        [Column("econotcalc", TypeName = "bit", Order = 192)]
        public bool TbBieconotcalc { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo bostamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo  bostamp nao pode ter mais que 25 caracteres")]
        [Column("bostamp", TypeName = "char", Order = 193)]
        public string TbBibostamp { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo ousrinis nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo ousrinis nao pode ter mais que 30 caracteres")]
        [Column("ousrinis", TypeName = "varchar", Order = 194)]
        public string TbBiousrinis { get; set; }

        //datetime
        [Required]
        [Column("ousrdata", TypeName = "datetime", Order = 195)]
        public DateTime TbBiousrdata { get; set; }

        //varchar 8
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo ousrhora nao pode ser nulo")]
        [MaxLength(8, ErrorMessage = "O campo ousrhoranao pode ter mais que 8 caracteres")]
        [Column("ousrhora", TypeName = "varchar", Order = 196)]
        public string TbBiousrhora { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo usrinisnao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo nao usrinis pode ter mais que 30 caracteres")]
        [Column("usrinis", TypeName = "varchar", Order = 197)]
        public string TbBiusrinis { get; set; }

        //datetime 
        [Required]
        [Column("usrdata", TypeName = "datetime", Order = 198)]
        public DateTime TbBiusrdata { get; set; }

        //varchar 8
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo usrhoranao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo nao usrhora pode ter mais que 30 caracteres")]
        [Column("usrhora", TypeName = "varchar", Order = 199)]
        public string TbBiusrhora { get; set; }

        //bit
        [Required]
        [Column("marcada", TypeName = "bit", Order = 200)]
        public bool TbBimarcada { get; set; }

        //bit
        [Required]
        [Column("mntencargos", TypeName = "bit", Order = 201)]
        public bool TbBimntencargos { get; set; }

        //numeric
        [Column("debitoori", TypeName = "numeric", Order = 202)]
        [DisplayFormat(NullDisplayText = "Sem  debito registado", ApplyFormatInEditMode = true)]
        public decimal TbBidebitoori { get; set; }

        //numeric
        [Column("edebitoori", TypeName = "numeric", Order = 203)]
        [DisplayFormat(NullDisplayText = "Sem debito registado", ApplyFormatInEditMode = true)]
        public decimal TbBiedebitoori { get; set; }

        //bit
        [Required]
        [Column("trocaequi", TypeName = "bit", Order = 204)]
        public bool TbBitrocaequi { get; set; }

        //numeric
        [Column("tpromo", TypeName = "numeric", Order = 205)]
        [DisplayFormat(NullDisplayText = "Sem  tpromo registado", ApplyFormatInEditMode = true)]
        public decimal TbBitpromo { get; set; }

        //numeric
        [Column("valdesc", TypeName = "numeric", Order = 206)]
        [DisplayFormat(NullDisplayText = "Sem valor desconto registado", ApplyFormatInEditMode = true)]
        public decimal TbBivaldesc { get; set; }

        //numeric
        [Column("evaldesc", TypeName = "numeric", Order = 207)]
        [DisplayFormat(NullDisplayText = "Sem valor desconto registado", ApplyFormatInEditMode = true)]
        public decimal TbBievaldesc { get; set; }

        public virtual ICollection<TbPBiMetadata> TbBis { get; set; } 
    }
}
