using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ConnectorService.Model.PHCModel
{
    // se existirem campos designados como decimal sao numeric em sql
    [Table("cc")]
    public class TbPContaCorrente
    {
        //char 25
        [Key]
        [MaxLength(25, ErrorMessage = "O campo de nome nao pode ter mais que 25 caracteres")]
        [Column("ccstamp", TypeName = "varchar", Order = 0)]
        public string TbCcCcStamp { get; set; }

        //datetime
        [Required]
        [Column("datalc", TypeName = "datetime", Order = 1)]
        public DateTime TbCCdatalc { get; set; }

        //datetime
        [Required]
        [Column("dataven", TypeName = "datetime", Order = 2)]
        public DateTime TbCCdataven { get; set; }

        //varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de cmdesc nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de cmdesc nao pode ter mais que 25 caracteres")]
        [Column("cmdesc", TypeName = "varchar", Order = 3)]
        public string TbCCcmdesc { get; set; }

        //numeric
        [Required]
        [Column("nrdoc", TypeName = "numeric", Order = 4)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]

        public decimal TbCCnrdoc { get; set; }

        //numeric
        [Required]
        [Column("deb", TypeName = "numeric", Order = 5)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCdeb { get; set; }

        //numeric 
        [Required]
        [Column("cred", TypeName = "numeric", Order = 6)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCcred { get; set; }

        //numeric
        [Required]
        [Column("edeb", TypeName = "numeric", Order = 7)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCedeb { get; set; }

        //numeric
        [Required]
        [Column("ecred", TypeName = "numeric", Order = 8)]
        [DisplayFormat(NullDisplayText = "Sem ecred registado", ApplyFormatInEditMode = true)]
        public decimal TbCCecred { get; set; }

        //char 55
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de nome nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de nome nao pode ter mais que 55 caracteres")]
        [Column("nome", TypeName = "varchar", Order = 9)]
        public string TbCCnome { get; set; }

        //var char 11
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de Cmoeda nao pode ser nulo")]
        [MaxLength(11, ErrorMessage = "O campo de Cmoeda nao pode ter mais que 11 caracteres")]
        [Column("Cmoeda", TypeName = "varchar", Order = 10)]
        public string TbCCmoeda { get; set; }

        //varchar 50
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ultdoc nao pode ser nulo")]
        [MaxLength(50, ErrorMessage = "O campo de ultdoc nao pode ter mais que 50 caracteres")]
        [Column("ultdoc", TypeName = "varchar", Order = 11)]
        public string TbCCultdoc { get; set; }

        //numeric
        [Required]
        [Column("no", TypeName = "numeric", Order = 12)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCno { get; set; }

        //numeric
        [Required]
        [Column("cm", TypeName = "numeric", Order = 13)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCcm { get; set; }


        //numeric
        [Required]
        [Column("c", TypeName = "numeric", Order = 14)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCcr { get; set; }

        //numeric
        [Required]
        [Column("docref", TypeName = "numeric", Order = 15)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCdocref { get; set; }

        //numeric
        [Required]
        [Column("debf", TypeName = "numeric", Order = 16)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCdebf { get; set; }

        //numeric 
        [Required]
        [Column("edebf", TypeName = "numeric", Order = 17)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCedebf { get; set; }

        //numeric
        [Required]
        [Column("credf", TypeName = "numeric", Order = 18)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCcredf { get; set; }

        //numeric 
        [Required]
        [Column("ecredf", TypeName = "numeric", Order = 19)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCecredf { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de fref nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de fref nao pode ter mais que 20 caracteres")]
        [Column("fref", TypeName = "varchar", Order = 20)]
        public string TbCCfref { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ccusto nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de ccusto nao pode ter mais que 20 caracteres")]
        [Column("ccusto", TypeName = "varchar", Order = 21)]
        public string TbCCccusto { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ncusto nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de ncusto nao pode ter mais que 20 caracteres")]
        [Column("ncusto", TypeName = "varchar", Order = 22)]
        public string TbCCncusto { get; set; }

        //varchar 2
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de origem nao pode ser nulo")]
        [MaxLength(2, ErrorMessage = "O campo de origem nao pode ter mais que 2 caracteres")]
        [Column("origem", TypeName = "varchar", Order = 23)]
        public string TbCCorigem { get; set; }

        //numeric
        [Required]
        [Column("debm", TypeName = "numeric", Order = 23)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCdebm { get; set; }

        //numeric
        [Required]
        [Column("credm", TypeName = "numeric", Order = 24)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCcredm { get; set; }

        //numeric
        [Required]
        [Column("debfm", TypeName = "numeric", Order = 25)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCdebfm { get; set; }

        //numeric
        [Required]
        [Column("credfm", TypeName = "numeric", Order = 26)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCcredfm { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de zona nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de zona nao pode ter mais que 20 caracteres")]
        [Column("zona", TypeName = "varchar", Order = 27)]
        public string TbCCzona { get; set; }

        //bit
        [Required]
        [Column("recibado", TypeName = "bit", Order = 28)]
        public bool TbCCrecibado { get; set; }

        //numeric
        [Required]
        [Column("vendedor", TypeName = "numeric", Order = 29)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCvendedor { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de vendnm nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de vendnm nao pode ter mais que 20 caracteres")]
        [Column("vendnm", TypeName = "varchar", Order = 30)]
        public string TbCCvendnm { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de nome nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de nome nao pode ter mais que 20 caracteres")]
        [Column("crdesc", TypeName = "varchar", Order = 31)]
        public string TbCCcrdesc { get; set; }

        //bit
        [Required]
        [Column("incobra", TypeName = "bit", Order = 32)]
        public bool TbCCincobra { get; set; }

        //numeric
        [Required]
        [Column("ftndoc", TypeName = "numeric", Order = 33)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCftndoc { get; set; }

        //numeric
        [Required]
        [Column("ftfno", TypeName = "numeric", Order = 34)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCftfno { get; set; }

        //varhcar 250
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de obs nao pode ser nulo")]
        [MaxLength(250, ErrorMessage = "O campo de obs nao pode ter mais que 250 caracteres")]
        [Column("obs", TypeName = "varchar", Order = 35)]
        public string TbCCobs { get; set; }

        //varchar 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de obscob nao pode ser nulo")]
        [MaxLength(60, ErrorMessage = "O campo de obscob nao pode ter mais que 60 caracteres")]
        [Column("obscob", TypeName = "varchar", Order = 36)]
        public string TbCCobscob { get; set; }

        //bit
        [Required]
        [Column("fmarcada", TypeName = "bit", Order = 37)]
        public bool TbCCfmarcada { get; set; }

        //varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de segmento nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de segmento nao pode ter mais que 25 caracteres")]
        [Column("segmento", TypeName = "varchar", Order = 38)]
        public string TbCCsegmento { get; set; }

        //numeric
        [Required]
        [Column("recino", TypeName = "numeric", Order = 39)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCrecino { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de odstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de odstamp nao pode ter mais que 25 caracteres")]
        [Column("odstamp", TypeName = "char", Order = 40)]
        public string TbCCodstamp { get; set; }

        //numeric
        [Required]
        [Column("escvtmp", TypeName = "numeric", Order = 41)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCescvtmp { get; set; }

        //numeric
        [Required]
        [Column("vtmp", TypeName = "numeric", Order = 42)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCvtmp { get; set; }

        //numeric
        [Required]
        [Column("evtmp", TypeName = "numeric", Order = 43)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCevtmp { get; set; }


        //varchar 22
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de cobranca nao pode ser nulo")]
        [MaxLength(22, ErrorMessage = "O campo de cobranca nao pode ter mais que 22 caracteres")]
        [Column("cobranca", TypeName = "varchar", Order = 44)]
        public string TbCCcobranca { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ftstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de ftstamp nao pode ter mais que 25 caracteres")]
        [Column("ftstamp", TypeName = "char", Order = 45)]
        public string TbCCftstamp { get; set; }


        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de restamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de restamp nao pode ter mais que 25 caracteres")]
        [Column("restamp", TypeName = "char", Order = 46)]
        public string TbCCrestamp { get; set; }

        //bit
        [Required]
        [Column("cambiofixo", TypeName = "bit", Order = 47)]
        public Boolean TbCCcambiofixo { get; set; }

        //numeric
        [Required]
        [Column("edifcambio", TypeName = "numeric", Order = 48)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCedifcambio { get; set; }


        //numeric
        [Required]
        [Column("difcambio", TypeName = "numeric", Order = 49)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCdifcambio { get; set; }


        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de nome nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de nome nao pode ter mais que 20 caracteres")]
        [Column("tipo", TypeName = "varchar", Order = 50)]
        public string TbCCtipo { get; set; }

        //numeric
        [Required]
        [Column("pais", TypeName = "numeric", Order = 51)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCpais { get; set; }

        //numeric
        [Required]
        [Column("estab", TypeName = "numeric", Order = 52)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCestab { get; set; }

       
        //numeric
        [Required]
        [Column("iva1", TypeName = "numeric", Order = 53)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCivavu { get; set; }
        
        //numeric
        [Required]
        [Column("iva2", TypeName = "numeric", Order = 54)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCivavd { get; set; }

        //numeric
        [Required]
        [Column("iva3", TypeName = "numeric", Order = 55)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCivavt { get; set; }

        //numeric
        [Required]
        [Column("iva4", TypeName = "numeric", Order = 56)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCivavq { get; set; }

        //numeric
        [Required]
        [Column("iva5", TypeName = "numeric", Order = 57)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCivavc { get; set; }

        //numeric
        [Required]
        [Column("iva6", TypeName = "numeric", Order = 58)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCivavse { get; set; }

        //numeric
        [Required]
        [Column("iva7", TypeName = "numeric", Order = 59)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCivavset { get; set; }

        //numeric
        [Required]
        [Column("iva8", TypeName = "numeric", Order = 60)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCivavo { get; set; }

        //numeric
        [Required]
        [Column("iva9", TypeName = "numeric", Order = 61)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCivavnov { get; set; }
       

        //numeric
        [Required]
        [Column("eiva1", TypeName = "numeric", Order = 62)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCeivavu{ get; set; }

        //numeric
        [Required]
        [Column("eiva2", TypeName = "numeric", Order = 63)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCeivavd { get; set; }

        //numeric
        [Required]
        [Column("eiva3", TypeName = "numeric", Order = 64)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCeivavt { get; set; }

        //numeric
        [Required]
        [Column("eiva4", TypeName = "numeric", Order = 65)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCeivavq { get; set; }

        //numeric
        [Required]
        [Column("eiva5", TypeName = "numeric", Order = 66)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCeivavc { get; set; }

        //numeric
        [Required]
        [Column("eiva6", TypeName = "numeric", Order = 67)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCeivavs { get; set; }

        //numeric
        [Required]
        [Column("eiva7", TypeName = "numeric", Order = 68)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCeivavset { get; set; }

        //numeric
        [Required]
        [Column("eiva8", TypeName = "numeric", Order = 69)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCeivavo { get; set; }

        //numeric
        [Required]
        [Column("eiva9", TypeName = "numeric", Order = 70)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCeivavn { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ftccstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de ftccstamp nao pode ter mais que 25 caracteres")]
        [Column("ftccstamp", TypeName = "char", Order = 71)]
        public string TbCCftccstamp { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de nome nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de nome nao pode ter mais que 25 caracteres")]
        [Column("rdstamp", TypeName = "char", Order = 72)]
        public string TbCCrdstamp { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de cobrador nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de cobrador nao pode ter mais que 20 caracteres")]
        [Column("cobrador", TypeName = "varchar", Order = 73)]
        public string TbCCcobrador { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de rota nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de rota nao pode ter mais que 20 caracteres")]
        [Column("rota", TypeName = "varchar", Order = 74)]
        public string TbCCrota { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de clbanco nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de clbanco nao pode ter mais que 20 caracteres")]
        [Column("clbanco", TypeName = "varchar", Order = 75)]
        public string TbCCclbanco { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de clcheque nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de clcheque nao pode ter mais que 20 caracteres")]
        [Column("clcheque", TypeName = "varchar", Order = 76)]
        public string TbCCclcheque { get; set; }

        //numeric
        [Required]
        [Column("valch", TypeName = "numeric", Order = 77)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCvalch { get; set; }

        //numeric
        [Required]
        [Column("evalch", TypeName = "numeric", Order = 78)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCevalch { get; set; }

        //decimal
        [Required]
        [Column("valre", TypeName = "numeric", Order = 79)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCvalre { get; set; }

        //decimal
        [Required]
        [Column("evalre", TypeName = "numeric", Order = 80)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCevalre { get; set; }

        //decimal
        [Required]
        [Column("mvalre", TypeName = "numeric", Order = 81)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCmvalre { get; set; }

        //varchar 10
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de intid nao pode ser nulo")]
        [MaxLength(10, ErrorMessage = "O campo de intid nao pode ter mais que 10 caracteres")]
        [Column("intid", TypeName = "varchar", Order = 82)]
        public string TbCCintid { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de lestamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de lestamp nao pode ter mais que 25 caracteres")]
        [Column("lestamp", TypeName = "char", Order = 83)]
        public string TbCClestamp { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de lrstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de lrstamp nao pode ter mais que 25 caracteres")]
        [Column("lrstamp", TypeName = "char", Order = 84)]
        public string TbCClrstamp { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de lmstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de lmstamp nao pode ter mais que 25 caracteres")]
        [Column("lmstamp", TypeName = "char", Order = 85)]
        public string TbCClmstamp { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de tpstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de tpstamp nao pode ter mais que 25 caracteres")]
        [Column("tpstamp", TypeName = "char", Order = 86)]
        public string TbCCtpstamp { get; set; }

        //varchar 55
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de tpdesc nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de tpdesc nao pode ter mais que 55 caracteres")]
        [Column("tpdesc", TypeName = "varchar", Order = 87)]
        public string TbCCtpdesc { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de chstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de chstamp nao pode ter mais que 25 caracteres")]
        [Column("chstamp", TypeName = "char", Order = 88)]
        public string TbCCchstamp { get; set; }

        //decimal
        [Required]
        [Column("covezes", TypeName = "numeric", Order = 89)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCcovezes { get; set; }

        //decimal
        [Required]
        [Column("virs", TypeName = "numeric", Order = 90)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCvirs { get; set; }

        //decimal
        [Required]
        [Column("evirs", TypeName = "numeric", Order = 91)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCevirs { get; set; }

        //decimal
        [Required]
        [Column("virsreg", TypeName = "numeric", Order = 92)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCvirsreg { get; set; }

        //decimal 
        [Required]
        [Column("evirsreg", TypeName = "numeric", Order = 93)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCevirsreg { get; set; }

        //decimal
        [Required]
        [Column("irsdif", TypeName = "numeric", Order = 94)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCirsdif { get; set; }

        //decimal
        [Required]
        [Column("eirsdif", TypeName = "numeric", Order = 95)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCeirsdif { get; set; }

        //decimal
        [Required]
        [Column("difccont", TypeName = "numeric", Order = 96)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCdifccont { get; set; }

        //decimal
        [Required]
        [Column("edifccont", TypeName = "numeric", Order = 97)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCedifccont { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de faccstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de faccstamp nao pode ter mais que 25 caracteres")]
        [Column("faccstamp", TypeName = "char", Order = 98)]
        public string TbCCfaccstamp { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de faclstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de faclstamp nao pode ter mais que 25 caracteres")]
        [Column("faclstamp", TypeName = "char", Order = 99)]
        public string TbCCfaclstamp { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de occstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de occstamp nao pode ter mais que 25 caracteres")]
        [Column("occstamp", TypeName = "varchar", Order = 100)]
        public string TbCCoccstamp { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ousrinis nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo de ousrinis nao pode ter mais que 30 caracteres")]
        [Column("ousrinis", TypeName = "varchar", Order = 101)]
        public string TbCCousrinis { get; set; }

        //datetime
        [Required]
        [Column("ousrdata", TypeName = "datetime", Order = 102)]
        public DateTime TbCCousrdata { get; set; }


        //varchar 8
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ousrhora nao pode ser nulo")]
        [MaxLength(8, ErrorMessage = "O campo de ousrhora nao pode ter mais que 8 caracteres")]
        [Column("ousrhora", TypeName = "varchar", Order = 103)]
        public string TbCCousrhora { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de usrinis nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo de usrinis nao pode ter mais que 30 caracteres")]
        [Column("usrinis", TypeName = "varchar", Order = 104)]
        public string TbCCusrinis { get; set; }

        //datetime
        [Required]
        [Column("usrdata", TypeName = "datetime", Order = 105)]
        public DateTime TbCCusrdata { get; set; }

        //varchar 8
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de usrhora nao pode ser nulo")]
        [MaxLength(8, ErrorMessage = "O campo de usrhora nao pode ter mais que 8 caracteres")]
        [Column("usrhora", TypeName = "varchar", Order = 106)]
        public string TbCCusrhora { get; set; }

        //bit
        [Required]
        [Column("marcada", TypeName = "bit", Order = 107)]
        public bool TbCCmarcada { get; set; }

        //bit
        [Required]
        [Column("dispcbb", TypeName = "bit", Order = 108)]
        public bool TbCCdispcbb { get; set; }


        //numeric
        [Required]
        [Column("cbbno", TypeName = "numeric", Order = 109)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCcbbno { get; set; }

        //numeric
        [Required]
        [Column("ivatx1", TypeName = "numeric", Order = 110)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCivatxu { get; set; }

        //numeric
        [Required]
        [Column("ivatx2", TypeName = "numeric", Order = 111)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCivatxd { get; set; }

        //numeric
        [Required]
        [Column("ivatx3", TypeName = "numeric", Order = 112)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCivatxt { get; set; }

        //numeric
        [Required]
        [Column("ivatx4", TypeName = "numeric", Order = 113)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCivatxq { get; set; }

        //numeric
        [Required]
        [Column("ivatx5", TypeName = "numeric", Order = 114)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCivatxc { get; set; }

        //numeric
        [Required]
        [Column("ivatx6", TypeName = "numeric", Order = 115)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCivatxs { get; set; }

        //numeric
        [Required]
        [Column("ivatx7", TypeName = "numeric", Order = 116)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCivatxsete { get; set; }

        //numeric
        [Required]
        [Column("ivatx8", TypeName = "numeric", Order = 117)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCivatxo { get; set; }

        //numeric
        [Required]
        [Column("ivatx9", TypeName = "numeric", Order = 118)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCCivatxn { get; set; }

        //bit
        [Required]
        [Column("reexgiva", TypeName = "bit", Order = 119)]
        public bool TbCCreexgiva { get; set; }

        //varchar 1
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de formapag nao pode ser nulo")]
        [MaxLength(1, ErrorMessage = "O campo de formapag nao pode ter mais que 1 caracteres")]
        [Column("formapag", TypeName = "varchar", Order = 120)]
        public string TbCCformapag { get; set; }

        //varchar 1
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de situacao nao pode ser nulo")]
        [MaxLength(1, ErrorMessage = "O campo de situacao nao pode ter mais que 1 caracteres")]
        [Column("situacao", TypeName = "varchar", Order = 121)]
        public string TbCCsituacao { get; set; }

        //bit
        [Required]
        [Column("cobradovunicre", TypeName = "bit", Order = 122)]
        public bool TbCCcobradovunicre { get; set; }

        public virtual ICollection<TbPContaCorrente> ContasCorrentes { get; set; }
    }
}
