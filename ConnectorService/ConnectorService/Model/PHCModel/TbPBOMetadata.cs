using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ConnectorService.Model.PHCModel
{
    [MetadataType(typeof(TbPBOMetadata))]
   public partial class TbPBO
    {
        
    } 

    [Table("bo")]
    public  class TbPBOMetadata
    {
        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de bostamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de bostamp nao pode ter mais que 25 caracteres")]
        [Column("bostamp", TypeName = "char", Order = 0)]
        public string TbBobostamp { get; set; }

        //varchar 24
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de nmdos nao pode ser nulo")]
        [MaxLength(24, ErrorMessage = "O campo de nmdos nao pode ter mais que 24 caracteres")]
        [Column("nmdos", TypeName = "varchar", Order = 1)]
        public string TbBonmdos { get; set; }

        //key numeric
        [Key]
        [Column("obrano", TypeName = "numeric", Order = 2)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoobrano { get; set; }

        //datetime
        [Required]
        [Column("dataobra", TypeName = "datetime", Order = 3)]
        public DateTime TbBodataobra { get; set; }

        //char 55
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo bo nome nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo bo nome nao pode ter mais que 55 caracteres")]
        [Column("nome", TypeName = "char", Order = 4)]
        public string TbBonome { get; set; }

        //numeric
        [Required]
        [Column("totaldeb", TypeName = "numeric", Order = 5)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBototaldeb { get; set; }

        //numeric
        [Required]
        [Column("etaotaldeb", TypeName = "numeric", Order = 6)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoetaotaldeb { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de tipo nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de tipo nao pode ter mais que 20 caracteres")]
        [Column("tipo", TypeName = "varchar", Order = 7)]
        public string TbBotipo { get; set; }

        // datetime
        [Required]
        [Column("datafinal", TypeName = "datetime", Order = 8)]
        public DateTime TbBodatafinal { get; set; }

        //numeric
        [Required]
        [Column("smoe4", TypeName = "numeric", Order = 9)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBosmoeq { get; set; }
        
        //numeric
        [Required]
        [Column("smoe3", TypeName = "numeric", Order = 10)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBosmoet { get; set; }

        //numeric
        [Required]
        [Column("smoe2", TypeName = "numeric", Order = 11)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBosmoed { get; set; }

        //numeric
        [Required]
        [Column("smoe1", TypeName = "numeric", Order = 12)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBosmoeu { get; set; }

        //numeric
        [Required]
        [Column("moetotal", TypeName = "numeric", Order = 13)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBomoetotal { get; set; }

        //numeric
        [Required]
        [Column("sdeb2", TypeName = "numeric", Order = 14)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBosdebd { get; set; }

        //numeric
        [Required]
        [Column("sdeb1", TypeName = "numeric", Order = 15)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBosdebu { get; set; }

        //numeric
        [Required]
        [Column("sdeb4", TypeName = "numeric", Order = 16)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBosdebq { get; set; }

        //numeric
        [Required]
        [Column("sdeb3", TypeName = "numeric", Order = 17)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBosdebt { get; set; }


        //numeric
        [Required]
        [Column("sqtt14", TypeName = "numeric", Order = 18)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBosqttcatorze { get; set; }

        //numeric
        [Required]
        [Column("sqtt13", TypeName = "numeric", Order = 19)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBosqtttreze { get; set; }

        //numeric
        [Required]
        [Column("sqtt12", TypeName = "numeric", Order = 20)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBosqttdoze { get; set; }

        //numeric
        [Required]
        [Column("sqtt11", TypeName = "numeric", Order = 21)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBosqttonze { get; set; }

        //numeric
        [Required]
        [Column("sqtt24", TypeName = "numeric", Order = 22)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBosqttvintequatro { get; set; }

        //numeric
        [Required]
        [Column("sqtt23", TypeName = "numeric", Order = 23)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBosqttvintetres { get; set; }

        //numeric
        [Required]
        [Column("sqtt22", TypeName = "numeric", Order = 24)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBosqttvintedois { get; set; }

        //numeric
        [Required]
        [Column("sqtt21", TypeName = "numeric", Order = 25)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBosqttvinteum { get; set; }

        //numeric
        [Required]
        [Column("vqtt24", TypeName = "numeric", Order = 26)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBovqttvintequatro { get; set; }

        //numeric
        [Required]
        [Column("vqtt23", TypeName = "numeric", Order = 27)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBovqttvintetres { get; set; }

        //numeric
        [Required]
        [Column("vqtt22", TypeName = "numeric", Order = 28)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBovqttvintedois { get; set; }

        //numeric
        [Required]
        [Column("vqtt21", TypeName = "numeric", Order = 29)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBovqttvinteum { get; set; }

        //numeric
        [Required]
        [Column("vendedor", TypeName = "numeric", Order = 30)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBovendedor { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de vendnm nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de vendnm nao pode ter mais que 25 caracteres")]
        [Column("vendnm", TypeName = "varchar", Order = 31)]
        public string TbBovendnm { get; set; }


        //numeric
        [Required]
        [Column("stot1", TypeName = "numeric", Order = 32)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBostotu { get; set; }

        //numeric
        [Required]
        [Column("stot2", TypeName = "numeric", Order = 33)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBostotd { get; set; }

        //numeric
        [Required]
        [Column("stot3", TypeName = "numeric", Order = 34)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBostott { get; set; }

        //numeric
        [Required]
        [Column("stot4", TypeName = "numeric", Order = 35)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBostotq { get; set; }

        //numeric
        [Required]
        [Column("no", TypeName = "numeric", Order = 36)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBono { get; set; }

        ////numeric
        //[Required]
        //[Column("obranome", TypeName = "numeric", Order = 38)]
        //[DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        //public decimal TbBoobranome { get; set; }

        //char 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de obranome nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de obranome nao pode ter mais que 20 caracteres")]
        [Column("obranome", TypeName = "char", Order = 37)]
        public string TbBoobranome { get; set; }

        //Key numeric
        [Key]
        [Column("boano", TypeName = "numeric", Order = 38)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoboano { get; set; }

        //datetime
        [Required]
        [Column("dataopen", TypeName = "datetime", Order = 39)]
        public decimal TbBodataopen { get; set; }
        
        //datetime
        [Required]
        [Column("datafecho", TypeName = "datetime", Order = 40)]
        public DateTime TbBodatafecho { get; set; }

        //bit
        [Required]
        [Column("fechada", TypeName = "bit", Order = 41)]
        public bool TbBofechada { get; set; }

        //numeric
        [Required]
        [Column("nopat", TypeName = "numeric", Order = 42)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBonopat { get; set; }

        //numeric
        [Required]
        [Column("total", TypeName = "numeric", Order = 43)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBototal { get; set; }

        //numeric
        [Required]
        [Column("tecnico", TypeName = "numeric", Order = 44)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBotecnico { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de tecnnm nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de tecnnm nao pode ter mais que 20 caracteres")]
        [Column("tecnnm", TypeName = "varchar", Order = 45)]
        public string TbBotecnnm { get; set; }

        //numeric
        [Required]
        [Column("nomaquina", TypeName = "numeric", Order = 46)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBonomaquina { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de maquina nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de maquina nao pode ter mais que 20 caracteres")]
        [Column("maquina", TypeName = "varchar", Order = 47)]
        public string TbBomaquina { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de marca nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de marca nao pode ter mais que 20 caracteres")]
        [Column("marca", TypeName = "varchar", Order = 48)]
        public string TbBomarca { get; set; }

        //varchar 50
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de serie nao pode ser nulo")]
        [MaxLength(50, ErrorMessage = "O campo de serie nao pode ter mais que 50 caracteres")]
        [Column("serie", TypeName = "varchar", Order = 49)]
        public string TbBoserie { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de zona nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de zona nao pode ter mais que 20 caracteres")]
        [Column("zona", TypeName = "varchar", Order = 50)]
        public string TbBozona { get; set; }

        //varchar 67
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de obs nao pode ser nulo")]
        [MaxLength(67, ErrorMessage = "O campo de obs nao pode ter mais que 67 caracteres")]
        [Column("obs", TypeName = "varchar", Order = 51)]
        public string TbBoobs { get; set; }

        // varchar 67
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de trab1 nao pode ser nulo")]
        [MaxLength(67, ErrorMessage = "O campo de trab1 nao pode ter mais que 67 caracteres")]
        [Column("trab1", TypeName = "varchar", Order = 52)]
        public string TbBotrabu { get; set; }

        //varchar 67
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de trab2 nao pode ser nulo")]
        [MaxLength(67, ErrorMessage = "O campo de trab2 nao pode ter mais que 67 caracteres")]
        [Column("trab2", TypeName = "varchar", Order = 53)]
        public string TbBotrabd { get; set; }


        //varchar 67
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de trab3 nao pode ser nulo")]
        [MaxLength(67, ErrorMessage = "O campo de trab3 nao pode ter mais que 67 caracteres")]
        [Column("trab3", TypeName = "varchar", Order = 54)]
        public string TbBotrabt { get; set; }

        //varchar 67
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de trab4 nao pode ser nulo")]
        [MaxLength(67, ErrorMessage = "O campo de trab4 nao pode ter mais que 67 caracteres")]
        [Column("trab4", TypeName = "varchar", Order = 55)]
        public string TbBotrabq { get; set; }

        //varchar 67
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de trab5 nao pode ser nulo")]
        [MaxLength(67, ErrorMessage = "O campo de trab5 nao pode ter mais que 67 caracteres")]
        [Column("trab5", TypeName = "varchar", Order = 56)]
        public string TbBotrabc { get; set; }

        //numeric
        [Key]
        [Required]
        [Column("ndos", TypeName = "numeric", Order = 57)]
        [DisplayFormat(NullDisplayText = "Sem ndos registado", ApplyFormatInEditMode = true)]
        public decimal TbBondos { get; set; }

        //numeric
        [Required]
        [Column("custo", TypeName = "numeric", Order = 58)]
        [DisplayFormat(NullDisplayText = "Sem custo registado", ApplyFormatInEditMode = true)]
        public decimal TbBocusto { get; set; }

        //varchar 11
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de moeda nao pode ser nulo")]
        [MaxLength(11, ErrorMessage = "O campo de moeda nao pode ter mais que 11 caracteres")]
        [Column("moeda", TypeName = "varchar", Order = 59)]
        public string TbBomoeda { get; set; }

        //numeric
        [Required]
        [Column("estab", TypeName = "numeric", Order = 60)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoestab { get; set; }

        //varchar 55
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de morada nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de morada nao pode ter mais que 55 caracteres")]
        [Column("morada", TypeName = "varchar", Order = 61)]
        public string TbBomorada { get; set; }

        //varchar 43
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de local nao pode ser nulo")]
        [MaxLength(43, ErrorMessage = "O campo de local nao pode ter mais que 43 caracteres")]
        [Column("local", TypeName = "varchar", Order = 62)]
        public string TbBolocal { get; set; }

        //varchar 45
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de codpost nao pode ser nulo")]
        [MaxLength(45, ErrorMessage = "O campo de codpost nao pode ter mais que 45 caracteres")]
        [Column("codpost", TypeName = "varchar", Order = 63)]
        public string TbBocodpost { get; set; }

        //datetime
        [Required]
        [Column("ultfact", TypeName = "datetime", Order = 64)]
        public DateTime TbBoultfact { get; set; }

        //numeric
        [Required]
        [Column("period", TypeName = "numeric", Order = 65)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoperiod { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de tabela1 nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de tabela1 nao pode ter mais que 20 caracteres")]
        [Column("tabela1", TypeName = "varchar", Order = 66)]
        public string TbBotabelau { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ncont nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de ncont nao pode ter mais que 20 caracteres")]
        [Column("ncont", TypeName = "varchar", Order = 67)]
        public string TbBoncont { get; set; }

        //bit
        [Required]
        [Column("logi1", TypeName = "bit", Order = 68)]
        public bool TbBologiu { get; set; }
        
        //bit
        [Required]
        [Column("logi2", TypeName = "bit", Order = 69)]
        public bool TbBologid { get; set; }

        //bit
        [Required]
        [Column("logi3", TypeName = "bit", Order = 70)]
        public bool TbBologit { get; set; }
        
        //bit
        [Required]
        [Column("logi4", TypeName = "bit", Order = 71)]
        public bool TbBologiq { get; set; }

        //bit
        [Required]
        [Column("logi5", TypeName = "bit", Order = 72)]
        public bool TbBologic { get; set; }

        //bit
        [Required]
        [Column("logi6", TypeName = "bit", Order = 73)]
        public bool TbBologis { get; set; }

        //bit
        [Required]
        [Column("logi7", TypeName = "bit", Order = 74)]
        public bool TbBologisete { get; set; }

        //bit
        [Required]
        [Column("logi8", TypeName = "bit", Order = 75)]
        public bool TbBologio { get; set; }

        //varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de segmento nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de segmento nao pode ter mais que 25 caracteres")]
        [Column("segmento", TypeName = "varchar", Order = 76)]
        public string TbBosegmento { get; set; }

        //bit
        [Required]
        [Column("impresso", TypeName = "bit", Order = 77)]
        public bool TbBoimpresso { get; set; }

        //varchar 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de userimpresso nao pode ser nulo")]
        [MaxLength(60, ErrorMessage = "O campo de userimpresso nao pode ter mais que 60 caracteres")]
        [Column("userimpresso", TypeName = "varchar", Order = 78)]
        public string TbBouserimpresso { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de fref nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de fref nao pode ter mais que 20 caracteres")]
        [Column("fref", TypeName = "varchar", Order = 79)]
        public string TbBofref { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ccusto nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de ccusto nao pode ter mais que 20 caracteres")]
        [Column("ccusto", TypeName = "varchar", Order = 80)]
        public string TbBoccusto { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ncusto nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de ncusto nao pode ter mais que 20 caracteres")]
        [Column("ncusto", TypeName = "varchar", Order = 81)]
        public string TbBoncusto { get; set; }

        //varchar 22
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de cobranca nao pode ser nulo")]
        [MaxLength(22, ErrorMessage = "O campo de cobranca nao pode ter mais que 22 caracteres")]
        [Column("cobranca", TypeName = "varchar", Order = 82)]
        public string TbBocobranca { get; set; }

        //bit
        [Required]
        [Column("infref", TypeName = "bit", Order = 83)]
        public bool TbBoinfref { get; set; }

        //bit
        [Required]
        [Column("lifref", TypeName = "bit", Order = 84)]
        public bool TbBolifref { get; set; }

        //numeric
        [Required]
        [Column("esdeb1", TypeName = "numeric", Order = 85)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoesdebu { get; set; }

        //numeric
        [Required]
        [Column("esdeb2", TypeName = "numeric", Order = 86)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoesdebd { get; set; }

        //numeric
        [Required]
        [Column("esdeb3", TypeName = "numeric", Order = 87)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoesdebt { get; set; }

        //numeric
        [Required]
        [Column("esdeb4", TypeName = "numeric", Order = 88)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoesdebq { get; set; }

        //numeric
        [Required]
        [Column("evqtt21", TypeName = "numeric", Order = 89)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoevqttvinteum { get; set; }

        //numeric
        [Required]
        [Column("evqtt22", TypeName = "numeric", Order = 90)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoevqttvintedois { get; set; }

        //numeric
        [Required]
        [Column("evqtt23", TypeName = "numeric", Order = 91)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoevqttvintetres { get; set; }

        //numeric
        [Required]
        [Column("evqtt24", TypeName = "numeric", Order = 92)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoevqttvintequatro { get; set; }

        //numeric
        [Required]
        [Column("estot1", TypeName = "numeric", Order = 93)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoestotu { get; set; }

        //numeric
        [Required]
        [Column("estot2", TypeName = "numeric", Order = 94)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoestotd { get; set; }

        //numeric
        [Required]
        [Column("estot3", TypeName = "numeric", Order = 95)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoestott { get; set; }

        //numeric
        [Required]
        [Column("estot4", TypeName = "numeric", Order = 96)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoestotq { get; set; }

        //numeric
        [Required]
        [Column("etotal", TypeName = "numeric", Order = 97)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoetotal { get; set; }

        //numeric
        [Required]
        [Column("ecusto", TypeName = "numeric", Order = 98)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoecusto { get; set; }


        //numeric
        [Required]
        [Column("bo_2tdesc1", TypeName = "numeric", Order = 99)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobodoistdescum { get; set; }

        //numeric
        [Required]
        [Column("bo_2tdesc2", TypeName = "numeric", Order = 100)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobodoistdescdois { get; set; }

        //numeric
        [Required]
        [Column("ebo_2tdes1", TypeName = "numeric", Order = 101)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebodoistdesum { get; set; }

        //numeric
        [Required]
        [Column("ebo_2tdes2", TypeName = "numeric", Order = 102)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebodoistdesdois { get; set; }

        //numeric
        [Required]
        [Column("descc", TypeName = "numeric", Order = 103)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodescc { get; set; }

        //numeric
        [Required]
        [Column("edescc", TypeName = "numeric", Order = 104)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoedescc { get; set; }

        //numeric
        [Required]
        [Column("bo_1tvall", TypeName = "numeric", Order = 105)]
        [DisplayFormat(NullDisplayText = "Sem v registado", ApplyFormatInEditMode = true)]
        public decimal TbBoboumtvall { get; set; }

        //numeric
        [Required]
        [Column("bo_2tvall", TypeName = "numeric", Order = 106)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobodoistvall { get; set; }

        //numeric
        [Required]
        [Column("ebo_1tvall", TypeName = "numeric", Order = 107)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoeboumtvall { get; set; }


        //numeric
        [Required]
        [Column("ebo_2tvall", TypeName = "numeric", Order = 108)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebodoistvall { get; set; }

        //numeric
        [Required]
        [Column("bo11_bins", TypeName = "numeric", Order = 109)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoboonzebins { get; set; }

        //numeric
        [Required]
        [Column("bo11_iva", TypeName = "numeric", Order = 110)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoboonzeiva { get; set; }


        //numeric
        [Required]
        [Column("ebo11_bins", TypeName = "numeric", Order = 111)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoeboonzebins { get; set; }

        //numeric
        [Required]
        [Column("ebo11_iva", TypeName = "numeric", Order = 112)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoeboonzeiva { get; set; }

        //numeric
        [Required]
        [Column("bo21_bins", TypeName = "numeric", Order = 113)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobovinteumbins { get; set; }

        //numeric
        [Required]
        [Column("bo21_iva", TypeName = "numeric", Order = 114)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobovinteumiva { get; set; }

        //numeric
        [Required]
        [Column("ebo21_bins", TypeName = "numeric", Order = 115)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebovinteumbins { get; set; }

        //numeric
        [Required]
        [Column("ebo21_iva", TypeName = "numeric", Order = 116)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebovinteumiva { get; set; }

        //numeric
        [Required]
        [Column("bo31_bins", TypeName = "numeric", Order = 117)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobotrintaumbins { get; set; }

        //numeric
        [Required]
        [Column("bo31_iva", TypeName = "numeric", Order = 118)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobotrintaumiva { get; set; }

        //numeric
        [Required]
        [Column("ebo31_bins", TypeName = "numeric", Order = 119)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebotrintaumbins { get; set; }

        //numeric
        [Required]
        [Column("ebo31_iva", TypeName = "numeric", Order = 120)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebotrintaumiva { get; set; }

        //numeric
        [Required]
        [Column("bo41_bins", TypeName = "numeric", Order = 121)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoboquarentaumbins { get; set; }

        //numeric
        [Required]
        [Column("bo41_iva", TypeName = "numeric", Order = 122)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoboquarentaumiva { get; set; }

        //numeric
        [Required]
        [Column("ebo41_bins", TypeName = "numeric", Order = 123)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoeboquarentaumbins { get; set; }

        //numeric
        [Required]
        [Column("ebo41_iva", TypeName = "numeric", Order = 124)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoeboquarentaumiva { get; set; }

        //numeric
        [Required]
        [Column("bo51_bins", TypeName = "numeric", Order = 125)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobocinquentaumbins { get; set; }

        //numeric
        [Required]
        [Column("bo51_iva", TypeName = "numeric", Order = 126)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobocinquentaumiva { get; set; }

        //numeric
        [Required]
        [Column("ebo51_bins", TypeName = "numeric", Order = 127)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebocinquentaumbins { get; set; }

        //numeric
        [Required]
        [Column("ebo51_iva", TypeName = "numeric", Order = 128)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebocinquentaumiva { get; set; }

        //numeric
        [Required]
        [Column("bo61_bins", TypeName = "numeric", Order = 129)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobosessentaumbins { get; set; }

        //numeric
        [Required]
        [Column("bo61_iva", TypeName = "numeric", Order = 130)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobosessentaumiva { get; set; }

        //numeric
        [Required]
        [Column("ebo61_bins", TypeName = "numeric", Order = 131)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebosessentaumbins { get; set; }

        //numeric
        [Required]
        [Column("ebo61_iva", TypeName = "numeric", Order = 132)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebosessentaumiva { get; set; }


        //numeric
        [Required]
        [Column("bo12_bins", TypeName = "numeric", Order = 133)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobodozebins { get; set; }

        //numeric
        [Required]
        [Column("bo12_iva", TypeName = "numeric", Order = 134)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobodozeiva { get; set; }

        //numeric
        [Required]
        [Column("ebo12_bins", TypeName = "numeric", Order = 135)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebodozebins { get; set; }

        //numeric
        [Required]
        [Column("ebo12_iva", TypeName = "numeric", Order = 136)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebodozeiva { get; set; }

        //numeric
        [Required]
        [Column("bo22_bins", TypeName = "numeric", Order = 137)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobovintedoisbins { get; set; }

        //numeric
        [Required]
        [Column("bo22_iva", TypeName = "numeric", Order = 138)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobovintedoisiva { get; set; }


        //numeric
        [Required]
        [Column("ebo22_bins", TypeName = "numeric", Order = 139)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebovintedoisbins { get; set; }

        //numeric
        [Required]
        [Column("ebo22_iva", TypeName = "numeric", Order = 140)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebovintedoisiva { get; set; }

        //numeric
        [Required]
        [Column("bo32_bins", TypeName = "numeric", Order = 141)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobotrintadoisbins { get; set; }

        //numeric
        [Required]
        [Column("bo32_iva", TypeName = "numeric", Order = 142)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobotrintadoisiva { get; set; }

        //numeric
        [Required]
        [Column("ebo32_bins", TypeName = "numeric", Order = 143)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebotrintadoisbins { get; set; }

        //numeric
        [Required]
        [Column("ebo32_iva", TypeName = "numeric", Order = 144)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebotrintadoisiva { get; set; }

        //numeric
        [Required]
        [Column("bo42_bins", TypeName = "numeric", Order = 145)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoboquarentadoisbins { get; set; }

        //numeric
        [Required]
        [Column("bo42_iva", TypeName = "numeric", Order = 146)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoboquarentadoisiva { get; set; }

        //numeric
        [Required]
        [Column("ebo42_bins", TypeName = "numeric", Order = 147)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoeboquarentadoisbins { get; set; }

        //numeric
        [Required]
        [Column("ebo42_iva", TypeName = "numeric", Order = 148)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoeboquarentadoisiva { get; set; }

        //numeric
        [Required]
        [Column("bo52_bins", TypeName = "numeric", Order = 149)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobocinquentadoisbins { get; set; }

        //numeric
        [Required]
        [Column("bo52_iva", TypeName = "numeric", Order = 150)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobocinquentadoisiva { get; set; }

        //numeric
        [Required]
        [Column("ebo52_bins", TypeName = "numeric", Order = 151)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebocinquentadoisbins { get; set; }

        //numeric
        [Required]
        [Column("ebo52_iva", TypeName = "numeric", Order = 152)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebocinquentadoisiva { get; set; }

        //numeric
        [Required]
        [Column("bo62_bins", TypeName = "numeric", Order = 153)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobosessentadoisbins { get; set; }

        //numeric
        [Required]
        [Column("bo62_iva", TypeName = "numeric", Order = 154)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobosessentadoisiva { get; set; }

        //numeric
        [Required]
        [Column("ebo62_bins", TypeName = "numeric", Order = 155)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebosessentadoisbins { get; set; }

        //numeric
        [Required]
        [Column("ebo62_iva", TypeName = "numeric", Order = 156)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebosessentadoisiva { get; set; }

        //numeric
        [Required]
        [Column("bo_totp1", TypeName = "numeric", Order = 157)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobototpu { get; set; }

        //numeric
        [Required]
        [Column("bo_totp2", TypeName = "numeric", Order = 158)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBobototpd { get; set; }

        //numeric
        [Required]
        [Column("ebo_totp1", TypeName = "numeric", Order = 159)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebototpu { get; set; }

        //numeric
        [Required]
        [Column("ebo_totp2", TypeName = "numeric", Order = 160)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoebototpd { get; set; }

        //bit
        [Required]
        [Column("edi", TypeName = "bit", Order = 161)]
        public bool TbBoedi { get; set; }

        //varchar 4
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de memissao nao pode ser nulo")]
        [MaxLength(4, ErrorMessage = "O campo de memissao nao pode ter mais que 4 caracteres")]
        [Column("memissao", TypeName = "varchar", Order = 162)]
        public string TbBomemissao { get; set; }

        //varchar 55
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de nome2 nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de nome2 nao pode ter mais que 55 caracteres")]
        [Column("nome2", TypeName = "varchar", Order = 163)]
        public string TbBonomedois { get; set; }

        //char25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de pastamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de pastamp nao pode ter mais que 25 caracteres")]
        [Column("pastamp", TypeName = "char", Order = 164)]
        public string TbBopastamp { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de snstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de snstamp nao pode ter mais que 25 caracteres")]
        [Column("snstamp", TypeName = "char", Order = 165)]
        public string TbBosnstamp { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de mastamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de mastamp nao pode ter mais que 25 caracteres")]
        [Column("mastamp", TypeName = "char", Order = 166)]
        public string TbBomastamp { get; set; }

        //varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de origem nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de origem nao pode ter mais que 25 caracteres")]
        [Column("origem", TypeName = "varchar", Order = 167)]
        public string TbBoorigem { get; set; }

        //numeric
        [Required]
        [Column("orinopat", TypeName = "numeric", Order = 168)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoorinopat { get; set; }

        //bit
        [Required]
        [Column("iiva", TypeName = "bit", Order = 169)]
        public bool TbBoiiva { get; set; }

        //bit
        [Required]
        [Column("iunit", TypeName = "bit", Order = 170)]
        public bool TbBoiunit { get; set; }

        //bit
        [Required]
        [Column("itotais", TypeName = "bit", Order = 171)]
        public bool TbBoitotais { get; set; }

        //bit
        [Required]
        [Column("iunitva", TypeName = "bit", Order = 172)]
        public bool TbBoiunitva { get; set; }

        //bit
        [Required]
        [Column("itotaisiva", TypeName = "bit", Order = 173)]
        public bool TbBoitotaisiva { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de site nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de site nao pode ter mais que 20 caracteres")]
        [Column("site", TypeName = "varchar", Order = 174)]
        public string TbBosite { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de pnome nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de pnome nao pode ter mais que 20 caracteres")]
        [Column("pnome", TypeName = "varchar", Order = 175)]
        public string TbBopnome { get; set; }

        //numeric
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de pno nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de pno nao pode ter mais que 25 caracteres")]
        [Column("pno", TypeName = "varchar", Order = 176)]
        public decimal TbBopno { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de cxstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de cxstamp nao pode ter mais que 25 caracteres")]
        [Column("cxstamp", TypeName = "char", Order = 177)]
        public string TbBocxstamp { get; set; }


        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de cxusername nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo de cxusername nao pode ter mais que 30 caracteres")]
        [Column("cxusername", TypeName = "varchar", Order = 178)]
        public string TbBocxusername { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo ssstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de ssstamp nao pode ter mais que 25 caracteres")]
        [Column("ssstamp", TypeName = "char", Order = 179)]
        public string TbBossstamp { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ssusername nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo de ssusername nao pode ter mais que 30 caracteres")]
        [Column("ssusername", TypeName = "varchar", Order = 180)]
        public string TbBossusername { get; set; }

        //bit
        [Required]
        [Column("alldescli", TypeName = "bit", Order = 181)]
        public bool TbBoalldescli { get; set; }

        //bit
        [Required]
        [Column("alldesfor", TypeName = "bit", Order = 182)]
        public bool TbBoalldesfor { get; set; }

        //text
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de series nao pode ser nulo")]
        [Column("series", TypeName = "varchar", Order = 183)]
        public bool TbBoseries { get; set; }

        //text
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de series2 nao pode ser nulo")]
        [Column("series2", TypeName = "varchar", Order = 184)]
        public bool TbBoseriesdois { get; set; }

        //varchar 10
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de quarto nao pode ser nulo")]
        [MaxLength(10, ErrorMessage = "O campo de quarto nao pode ter mais que 10 caracteres")]
        [Column("quarto", TypeName = "varchar", Order = 185)]
        public string TbBoquarto { get; set; }

        //decimal
        [Required]
        [Column("ocupacao", TypeName = "numeric", Order = 186)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoocupacao { get; set; }

        //varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de tabela2 nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de tabela2 nao pode ter mais que 25 caracteres")]
        [Column("tabela2", TypeName = "varchar", Order = 187)]
        public string TbBotabeladois { get; set; }

        //text ver sql text
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de obstab2 nao pode ser nulo")]
        [Column("obstab2", TypeName = "varchar", Order = 188)]
        public string TbBoobstabdois { get; set; }

        //varchar 50
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de iemail nao pode ser nulo")]
        [MaxLength(50, ErrorMessage = "O campo de iemail nao pode ter mais que 50 caracteres")]
        [Column("iemail", TypeName = "varchar", Order = 189)]
        public string TbBoiemail { get; set; }

        //varchar 50
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de inome nao pode ser nulo")]
        [MaxLength(50, ErrorMessage = "O campo de inome nao pode ter mais que 50 caracteres")]
        [Column("inome", TypeName = "varchar", Order = 190)]
        public string TbBoinome { get; set; }

        //numeric
        [Required]
        [Column("situacao", TypeName = "numeric", Order = 191)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBosituacao { get; set; }

        //char 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de lang nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de lang nao pode ter mais que 20 caracteres")]
        [Column("lang", TypeName = "char", Order = 192)]
        public string TbBolang { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ean nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo de ean nao pode ter mais que 30 caracteres")]
        [Column("ean", TypeName = "varchar", Order = 193)]
        public string TbBoean { get; set; }

        //varchar 4
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de iecacodisen nao pode ser nulo")]
        [MaxLength(4, ErrorMessage = "O campo de iecacodisen nao pode ter mais que 4 caracteres")]
        [Column("iecacodisen", TypeName = "varchar", Order = 194)]
        public string TbBoiecacodisen { get; set; }

        //bit
        [Required]
        [Column("boclose", TypeName = "bit", Order = 195)]
        public bool TbBoboclose { get; set; }

        //datetime
        [Required]
        [Column("dtclose", TypeName = "datetime", Order = 196)]
        public DateTime TbBodtclose { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de tpstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de tpstamp nao pode ter mais que 25 caracteres")]
        [Column("tpstamp", TypeName = "char", Order = 197)]
        public string TbBotpstamp { get; set; }

        //varchar 55
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de tpdesc nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de tpdesc nao pode ter mais que 55 caracteres")]
        [Column("tpdesc", TypeName = "varchar", Order = 198)]
        public string TbBotpdesc { get; set; }

        //bit
        [Required]
        [Column("emconf", TypeName = "bit", Order = 199)]
        public bool TbBoemconf { get; set; }

        //varchar 1
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de statuspda nao pode ser nulo")]
        [MaxLength(1, ErrorMessage = "O campo de statuspda nao pode ter mais que 1 caracteres")]
        [Column("statuspda", TypeName = "varchar", Order = 200)]
        public string TbBostatuspda { get; set; }

        //bit
        [Required]
        [Column("aprovado", TypeName = "bit", Order = 201)]
        public bool TbBoaprovado { get; set; }

        //numeric
        [Required]
        [Column("boid", TypeName = "numeric", Order = 202)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoboid { get; set; }

        ////numeric
        //[Required]
        //[Column("u_totaldoc", TypeName = "numeric", Order = 203)]
        //[DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        //public decimal TbBoutotaldoc { get; set; }


        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ousrinis nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo de ousrinis nao pode ter mais que 30 caracteres")]
        [Column("ousrinis", TypeName = "varchar", Order = 203)]
        public string TbBoousrinis { get; set; }

        //datetime
        [Required]
        [Column("ousrdata", TypeName = "datetime", Order = 205)]
        public DateTime TbBoousrdata { get; set; }

        //varchar 8
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ousrhora nao pode ser nulo")]
        [MaxLength(8, ErrorMessage = "O campo de ousrhora nao pode ter mais que 8 caracteres")]
        [Column("ousrhora", TypeName = "varchar", Order = 206)]
        public string TbBoousrhora { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de usrinis nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo de usrinis nao pode ter mais que 30 caracteres")]
        [Column("usrinis", TypeName = "varchar", Order = 207)]
        public string TbBousrinis { get; set; }

        //datetime
        [Required]
        [Column("usrdata",TypeName = "datetime",Order = 208)]
        public DateTime TbBousrdata { get; set; }

        //varchar 8
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de usrhora nao pode ser nulo")]
        [MaxLength(8, ErrorMessage = "O campo de usrhora nao pode ter mais que 8 caracteres")]
        [Column("usrhora", TypeName = "varchar", Order = 209)]
        public string TbBousrhora { get; set; }

        //bit
        [Required]
        [Column("marcada", TypeName = "bit", Order = 210)]
        public bool TbBomarcada { get; set; }


        public virtual ICollection<TbPBOMetadata> TbBos { get; set; } 
    }
}
