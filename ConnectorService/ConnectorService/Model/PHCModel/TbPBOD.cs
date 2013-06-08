using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ConnectorService.Model.PHCModel
{
    [Table("bo2")]
    public class TbPBOD
    {

        //char 25
        [Key]
        [MaxLength(25, ErrorMessage = "O campo de bo2stamp nao pode ter mais que 25 caracteres")]
        [Column("bo2stamp", TypeName = "char", Order = 0)]
        public string TbBobodstamp { get; set; }

        //varchar 2
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de pscm nao pode ser nulo")]
        [MaxLength(2, ErrorMessage = "O campo de pscm nao pode ter mais que 2 caracteres")]
        [Column("pscm", TypeName = "varchar", Order = 1)]
        public string TbBodpscm { get; set; }

        //numeric
        [Required]
        [Column("zncm", TypeName = "numeric", Order = 2)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodzncm { get; set; }

        //numeric
        [Required]
        [Column("excm", TypeName = "numeric", Order = 3)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoexcm { get; set; }

        //varchar 3
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ptcm nao pode ser nulo")]
        [MaxLength(3, ErrorMessage = "O campo de ptcm nao pode ter mais que 3 caracteres")]
        [Column("ptcm", TypeName = "varchar", Order = 4)]
        public string TbBodptcm { get; set; }

        //varchar 3
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de encm nao pode ser nulo")]
        [MaxLength(3, ErrorMessage = "O campo de encm nao pode ter mais que 3 caracteres")]
        [Column("encm", TypeName = "varchar", Order = 5)]
        public string TbBodencm { get; set; }

        //numeric
        [Required]
        [Column("ntcm", TypeName = "numeric", Order = 6)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodntcm { get; set; }

        //varchar 70
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de pscmdesc nao pode ser nulo")]
        [MaxLength(70, ErrorMessage = "O campo de pscmdesc nao pode ter mais que 70 caracteres")]
        [Column("pscmdesc", TypeName = "varchar", Order = 7)]
        public string TbBodpscmdesc { get; set; }

        //varchar 70
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de znregiao nao pode ser nulo")]
        [MaxLength(70, ErrorMessage = "O campo de znregiao nao pode ter mais que 70 caracteres")]
        [Column("znregiao", TypeName = "varchar", Order = 8)]
        public string TbBodznregiao { get; set; }

        //varchar 70
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de excmdesc nao pode ser nulo")]
        [MaxLength(70, ErrorMessage = "O campo de excmdesc nao pode ter mais que 70 caracteres")]
        [Column("excmdesc", TypeName = "varchar", Order = 9)]
        public string TbBodexcmdesc { get; set; }

        //varchar 70
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ptcmdesc nao pode ser nulo")]
        [MaxLength(70, ErrorMessage = "O campo de ptcmdesc nao pode ter mais que 70 caracteres")]
        [Column("ptcmdesc", TypeName = "varchar", Order = 10)]
        public string TbBodptcmdesc { get; set; }

        //varchar 70
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de encmdesc nao pode ser nulo")]
        [MaxLength(70, ErrorMessage = "O campo de encmdesc nao pode ter mais que 70 caracteres")]
        [Column("encmdesc", TypeName = "varchar", Order = 11)]
        public string TbBoencmdesc { get; set; }

        //bit
        [Required]
        [Column("ncin", TypeName = "bit", Order = 12)]
        public bool TbBodncin { get; set; }

        //bit
        [Required]
        [Column("ncout", TypeName = "bit", Order = 13)]
        public bool TbBodncout { get; set; }

        //bit
        [Required]
        [Column("usaintra", TypeName = "bit", Order = 14)]
        public bool TbBodusaintra { get; set; }

        //numeric
        [Required]
        [Column("ettieca", TypeName = "numeric", Order = 15)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodettieca { get; set; }

        //numeric
        [Required]
        [Column("ttieca", TypeName = "numeric", Order = 16)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodttieca { get; set; }

        //numeric
        [Required]
        [Column("estab", TypeName = "numeric", Order = 17)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodmttieca { get; set; }

        //bit
        [Required]
        [Column("iectisento", TypeName = "bit", Order = 18)]
        public bool TbBodiectisento { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de adjbostamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de adjbostamp nao pode ter mais que 25 caracteres")]
        [Column("adjbostamp", TypeName = "char", Order = 19)]
        public string TbBodadjbostamp { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de processo nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de processo nao pode ter mais que 20 caracteres")]
        [Column("processo", TypeName = "char", Order = 20)]
        public string TbBodprocesso { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de subproc nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de subproc nao pode ter mais que 20 caracteres")]
        [Column("subproc", TypeName = "varchar", Order = 21)]
        public string TbBodsubproc { get; set; }

        //bit
        [Required]
        [Column("adjudicado", TypeName = "bit", Order = 22)]
        public bool TbBodadjudicado { get; set; }

        //bit
        [Required]
        [Column("orcamento", TypeName = "bit", Order = 23)]
        public bool TbBodorcamento { get; set; }

        //numeric
        [Required]
        [Column("mcomercial", TypeName = "numeric", Order = 24)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodmcomercial { get; set; }

        //varchar 40
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de dpedidpov nao pode ser nulo")]
        [MaxLength(40, ErrorMessage = "O campo de dpedidpov nao pode ter mais que 40 caracteres")]
        [Column("dpedidpov", TypeName = "varchar", Order = 25)]
        public string TbBoddpedidpov { get; set; }

        //bit
        [Required]
        [Column("autos", TypeName = "bit", Order = 26)]
        public bool TbBoautos { get; set; }

        //numeric
        [Required]
        [Column("autotipo", TypeName = "numeric", Order = 27)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodautotipo { get; set; }

        //numeric
        [Required]
        [Column("autoper", TypeName = "numeric", Order = 28)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodautoper { get; set; }

        //numeric
        [Required]
        [Column("mensaldia", TypeName = "numeric", Order = 29)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodmensaldia { get; set; }

        //numeric
        [Required]
        [Column("vencimento", TypeName = "numeric", Order = 30)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodvencimento { get; set; }

        //numeric
        [Required]
        [Column("autono", TypeName = "numeric", Order = 31)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodautono { get; set; }

        //bit
        [Required]
        [Column("tbrsemmed", TypeName = "bit", Order = 32)]
        public bool TbBodtbrsemmed { get; set; }

        //numeric
        [Required]
        [Column("pdtipo", TypeName = "numeric", Order = 33)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodpdtipo { get; set; }

        //bit
        [Required]
        [Column("planeamento", TypeName = "bit", Order = 34)]
        public bool TbBodplaneamento { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de calistamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de calistamp nao pode ter mais que 25 caracteres")]
        [Column("calistamp", TypeName = "char", Order = 35)]
        public string TbBodcalistamp { get; set; }

        //varchar 5
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de tipoobra nao pode ser nulo")]
        [MaxLength(5, ErrorMessage = "O campo de tipoobra nao pode ter mais que 5 caracteres")]
        [Column("tipoobra", TypeName = "varchar", Order = 36)]
        public string TbBodtipoobra { get; set; }

        //varchar 55
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de descobra nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de descobras nao pode ter mais que 55 caracteres")]
        [Column("descobra", TypeName = "varchar", Order = 37)]
        public string TbBoddescobra { get; set; }

        //bit
        [Required]
        [Column("sujrvp", TypeName = "bit", Order = 1)]
        public bool TbBodsujrvp { get; set; }

        //numeric
        [Required]
        [Column("ttecoval", TypeName = "numeric", Order = 38)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodttecoval { get; set; }

        //numeric
        [Required]
        [Column("ettecoval", TypeName = "numeric", Order = 39)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodettecoval { get; set; }

        //varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ngstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de ngstamp nao pode ter mais que 25 caracteres")]
        [Column("ngstamp", TypeName = "varchar", Order = 40)]
        public string TbBodngstamp { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de negocio nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo de negocio nao pode ter mais que 30 caracteres")]
        [Column("negocio", TypeName = "varchar", Order = 41)]
        public string TbBodnegocio { get; set; }

        //varchar 55
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de descnegocio nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de descnegocio nao pode ter mais que 55 caracteres")]
        [Column("descnegocio", TypeName = "varchar", Order = 42)]
        public string TbBoddescnegocio { get; set; }

        //varchar 40
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ngstatus nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de ngstatus nao pode ter mais que 25 caracteres")]
        [Column("ngstatus", TypeName = "varchar", Order = 43)]
        public string TbBodngstatus { get; set; }


        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ousrinis nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo de ousrinis nao pode ter mais que 30 caracteres")]
        [Column("ousrinis", TypeName = "varchar", Order = 44)]
        public string TbBodousrinis { get; set; }

        //datetime
        [Required]
        [Column("ousrdata", TypeName = "datetime", Order = 45)]
        public DateTime TbBodousrdata { get; set; }

        //varchar 8
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ousrhora nao pode ser nulo")]
        [MaxLength(8, ErrorMessage = "O campo de ousrhora nao pode ter mais que 8 caracteres")]
        [Column("ousrhora", TypeName = "varchar", Order = 46)]
        public string TbBodousrhora { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de usrinis nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo de usrinis nao pode ter mais que 30 caracteres")]
        [Column("usrinis", TypeName = "varchar", Order = 47)]
        public string TbBodusrinis { get; set; }

        //datetime 
        [Required]
        [Column("usrdata", TypeName = "datetime", Order = 48)]
        public DateTime TbBodusrdata { get; set; }

        //varchar 8
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de usrhora nao pode ser nulo")]
        [MaxLength(8, ErrorMessage = "O campo de usrhora nao pode ter mais que 8 caracteres")]
        [Column("usrhora", TypeName = "varchar", Order = 49)]
        public string TbBodusrhora { get; set; }

        //bit
        [Required]
        [Column("marcada", TypeName = "bit", Order = 50)]
        public bool TbBodmarcada { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de autostamp nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de autostamp nao pode ter mais que 25 caracteres")]
        [Column("autostamp", TypeName = "char", Order = 51)]
        public string TbBodautostamp { get; set; }

        //numeric
        [Required]
        [Column("bo71_bins", TypeName = "numeric", Order = 52)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodbosetumbins { get; set; }

        //numeric
        [Required]
        [Column("bo71_iva", TypeName = "numeric", Order = 53)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodsetumiva { get; set; }

        //numeric
        [Required]
        [Column("ebo71_bins", TypeName = "numeric", Order = 54)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodebosetumbins { get; set; }

        //numeric
        [Required]
        [Column("ebo71_iva", TypeName = "numeric", Order = 55)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodesetumiva { get; set; }

        //numeric
        [Required]
        [Column("bo81_bins", TypeName = "numeric", Order = 56)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodbooiumbins { get; set; }

        //numeric
        [Required]
        [Column("bo81_iva", TypeName = "numeric", Order = 57)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodoiumiva { get; set; }

        //numeric
        [Required]
        [Column("ebo81_bins", TypeName = "numeric", Order = 58)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodebooiumbins { get; set; }

        //numeric
        [Required]
        [Column("ebo81_iva", TypeName = "numeric", Order = 59)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodeoiumiva { get; set; }

        //numeric
        [Required]
        [Column("bo91_bins", TypeName = "numeric", Order = 60)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodbonovumbins { get; set; }

        //numeric
        [Required]
        [Column("bo91_iva", TypeName = "numeric", Order = 61)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodnovumiva { get; set; }

        //numeric
        [Required]
        [Column("ebo91_bins", TypeName = "numeric", Order = 62)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodebonovumbins { get; set; }

        //numeric
        [Required]
        [Column("ebo91_iva", TypeName = "numeric", Order = 63)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodenovumiva { get; set; }


        //numeric
        [Required]
        [Column("bo72_bins", TypeName = "numeric", Order = 64)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodbosetdoisbins { get; set; }

        //numeric
        [Required]
        [Column("bo72_iva", TypeName = "numeric", Order = 65)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodsetdoisiva { get; set; }

        //numeric
        [Required]
        [Column("ebo72_bins", TypeName = "numeric", Order = 66)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodebosetdoisbins { get; set; }

        //numeric
        [Required]
        [Column("ebo72_iva", TypeName = "numeric", Order = 67)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodesetdoisiva { get; set; }

        //numeric
        [Required]
        [Column("bo82_bins", TypeName = "numeric", Order = 68)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodbooidoisbins { get; set; }

        //numeric
        [Required]
        [Column("bo82_iva", TypeName = "numeric", Order = 69)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodbooidoisbiva { get; set; }

        //numeric
        [Required]
        [Column("ebo82_bins", TypeName = "numeric", Order = 70)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodebooidoisbins { get; set; }

        //numeric
        [Required]
        [Column("ebo82_iva", TypeName = "numeric", Order = 71)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodeoidoisiva { get; set; }

        //numeric
        [Required]
        [Column("bo92_bins", TypeName = "numeric", Order = 72)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodbonovdoisbins { get; set; }

        //numeric
        [Required]
        [Column("bo92_iva", TypeName = "numeric", Order = 73)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodnovdoisiva { get; set; }

        //numeric
        [Required]
        [Column("ebo92_bins", TypeName = "numeric", Order = 74)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodebonovdoisbins { get; set; }

        //numeric
        [Required]
        [Column("ebo92_iva", TypeName = "numeric", Order = 75)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodenovdoisiva { get; set; }

        //varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de alvstamp1 nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de alvstamp1 nao pode ter mais que 25 caracteres")]
        [Column("alvstamp1", TypeName = "varchar", Order = 76)]
        public string TbBodalvstampum { get; set; }

        //varchar 55
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de identificacao1 nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de identificacao1 nao pode ter mais que 55 caracteres")]
        [Column("identificacao1", TypeName = "varchar", Order = 77)]
        public string TbBodidentificacaoum { get; set; }

        //varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de szzstamp1 nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de szzstamp1 nao pode ter mais que 25 caracteres")]
        [Column("szzstamp1", TypeName = "varchar", Order = 78)]
        public string TbBodszzstampum { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de zona1 nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo de zona1 nao pode ter mais que 30 caracteres")]
        [Column("zona1", TypeName = "varchar", Order = 79)]
        public string TbBodzonaum { get; set; }

        //varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de alvstamp2 nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de alvstamp2 nao pode ter mais que 25 caracteres")]
        [Column("alvstamp2", TypeName = "varchar", Order = 80)]
        public string TbBodalvstampdois { get; set; }

        //varchar 55
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de identificacao2 nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de identificacao2 nao pode ter mais que 55 caracteres")]
        [Column("identificacao2", TypeName = "varchar", Order = 81)]
        public string TbBodidentificacaodois { get; set; }

        //varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de szzstamp2  nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de szzstamp2 nao pode ter mais que 25 caracteres")]
        [Column("szzstamp2", TypeName = "varchar", Order = 82)]
        public string TbBodszzstampdois { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de zona2 nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo de zona2 nao pode ter mais que 30 caracteres")]
        [Column("zona2", TypeName = "varchar", Order = 83)]
        public string TbBodzonadois { get; set; }

        //numeric
        [Required]
        [Column("armazem", TypeName = "numeric", Order = 84)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodarmazem { get; set; }

        //numeric
        [Required]
        [Column("ar2mazem", TypeName = "numeric", Order = 85)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodardoismazem { get; set; }

        //varchar 100
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de dprocesso nao pode ser nulo")]
        [MaxLength(100, ErrorMessage = "O campo de dprocesso nao pode ter mais que 100 caracteres")]
        [Column("dprocesso", TypeName = "varchar", Order = 86)]
        public string TbBoddprocesso { get; set; }

        //numeric
        [Required]
        [Column("diasde", TypeName = "numeric", Order = 87)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoddiasde { get; set; }

        //numeric
        [Required]
        [Column("diasate", TypeName = "numeric", Order = 88)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBoddiasate { get; set; }

        //numeric
        [Required]
        [Column("ttecoval2", TypeName = "numeric", Order = 89)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodttecovaldois { get; set; }

        //numeric
        [Required]
        [Column("ettecoval2", TypeName = "numeric", Order = 90)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodettecovaldois { get; set; }

        //numeric
        [Required]
        [Column("nopkng", TypeName = "numeric", Order = 91)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodnopkng { get; set; }

        //varchar 120
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de xpdviatura nao pode ser nulo")]
        [MaxLength(120, ErrorMessage = "O campo de xpdviatura nao pode ter mais que 120 caracteres")]
        [Column("xpdviatura", TypeName = "varchar", Order = 92)]
        public string TbBodxpdviatura { get; set; }

        //datetime
        [Required]
        [Column("xpddata", TypeName = "datetime", Order = 93)]
        public DateTime TbBodxpddata { get; set; }

        //varchar 5
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de xpdhora nao pode ser nulo")]
        [MaxLength(5, ErrorMessage = "O campo de xpdhora nao pode ter mais que 5 caracteres")]
        [Column("xpdhora", TypeName = "varchar", Order = 94)]
        public string TbBodxpdhora { get; set; }

        //varchar 55
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de versaocrono nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de versaocrono nao pode ter mais que 55 caracteres")]
        [Column("versaocrono", TypeName = "varchar", Order = 95)]
        public string TbBodversaocrono { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de crpstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de crpstamp nao pode ter mais que 25 caracteres")]
        [Column("crpstamp", TypeName = "char", Order = 96)]
        public string TbBodcrpstamp { get; set; }

        //bit
        [Required]
        [Column("exportado", TypeName = "bit", Order = 97)]
        public bool TbBodexportado { get; set; }

        //varchar 50
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de cladrsdesc nao pode ser nulo")]
        [MaxLength(50, ErrorMessage = "O campo de cladrsdesc nao pode ter mais que 50 caracteres")]
        [Column("cladrsdesc", TypeName = "varchar", Order = 98)]
        public string TbBodcladrsdesc { get; set; }

        //varchar 55
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de morada nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de morada nao pode ter mais que 55 caracteres")]
        [Column("morada", TypeName = "varchar", Order = 99)]
        public string TbBodmorada { get; set; }

        //varchar 43
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de local nao pode ser nulo")]
        [MaxLength(43, ErrorMessage = "O campo de local nao pode ter mais que 43 caracteres")]
        [Column("local", TypeName = "varchar", Order = 100)]
        public string TbBodlocal { get; set; }

        //varchar 45
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de codpostal nao pode ser nulo")]
        [MaxLength(45, ErrorMessage = "O campo de codpostal nao pode ter mais que 45 caracteres")]
        [Column("codpostal", TypeName = "varchar", Order = 101)]
        public string TbBodcodpostal { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de cladrszona nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de cladrszona nao pode ter mais que 20 caracteres")]
        [Column("cladrszona", TypeName = "varchar", Order = 102)]
        public string TbBodcladrszona { get; set; }

        //varchar 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de telefone nao pode ser nulo")]
        [MaxLength(60, ErrorMessage = "O campo de telefone nao pode ter mais que 60 caracteres")]
        [Column("telefone", TypeName = "varchar", Order = 103)]
        public string TbBodtelefone { get; set; }

        //varchar 50
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de contacto nao pode ser nulo")]
        [MaxLength(50, ErrorMessage = "O campo de contacto nao pode ter mais que 50 caracteres")]
        [Column("contacto", TypeName = "varchar", Order = 104)]
        public string TbBodcontacto { get; set; }

        //varchar 45
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de email nao pode ser nulo")]
        [MaxLength(45, ErrorMessage = "O campo de email nao pode ter mais que 45 caracteres")]
        [Column("email", TypeName = "varchar", Order = 105)]
        public string TbBodemail { get; set; }

        //varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de cladrsstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de cladrsstamp nao pode ter mais que 25 caracteres")]
        [Column("cladrsstamp", TypeName = "varchar", Order = 106)]
        public string TbBodcladrsstamp { get; set; }

        //char 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de area nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de area nao pode ter mais que 20 caracteres")]
        [Column("area", TypeName = "char", Order = 107)]
        public string TbBodarea { get; set; }

        //numeric
        [Required]
        [Column("tkhtyp", TypeName = "numeric", Order = 108)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodtkhtyp { get; set; }

        //varchar 15
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de tkhcarrs nao pode ser nulo")]
        [MaxLength(15, ErrorMessage = "O campo de tkhcarr nao pode ter mais que 15 caracteres")]
        [Column("tkhcarr", TypeName = "varchar", Order = 109)]
        public string TbBodtkhcarr { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de tkhref nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de tkhref nao pode ter mais que 20 caracteres")]
        [Column("tkhref", TypeName = "varchar", Order = 110)]
        public string TbBodtkhref { get; set; }

        //numeric
        [Required]
        [Column("eftaxamt_a", TypeName = "numeric", Order = 111)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodeftaxamta { get; set; }

        //numeric
        [Required]
        [Column("eftaxamt_b", TypeName = "numeric", Order = 112)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodeftaxamtb { get; set; }

        //numeric
        [Required]
        [Column("ftaxamt_a", TypeName = "numeric", Order = 113)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodftaxamta { get; set; }

        //numeric 
        [Required]
        [Column("ftaxamt_b", TypeName = "numeric", Order = 114)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodftaxamtb { get; set; }

        //varchar 5
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de tkhhora nao pode ser nulo")]
        [MaxLength(5, ErrorMessage = "O campo de tkhhora nao pode ter mais que 5 caracteres")]
        [Column("tkhhora", TypeName = "varchar", Order = 115)]
        public string TbBodtkhhora { get; set; }

        //datetime
        [Required]
        [Column("tkhdata", TypeName = "datetime", Order = 116)]
        public decimal TbBodtkhdata { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de tkhlre nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de tkhlre nao pode ter mais que 20 caracteres")]
        [Column("tkhlre", TypeName = "varchar", Order = 117)]
        public string TbBodtkhlref { get; set; }

        //numeric
        [Required]
        [Column("tkhshf", TypeName = "numeric", Order = 118)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodtkhshf { get; set; }

        //varchar 15
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de tkhopid nao pode ser nulo")]
        [MaxLength(15, ErrorMessage = "O campo de tkhopid nao pode ter mais que 15 caracteres")]
        [Column("tkhopid", TypeName = "varchar", Order = 119)]
        public string TbBodtkhopid { get; set; }

        //numeric
        [Required]
        [Column("tkhltyp", TypeName = "numeric", Order = 120)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodtkhltyp { get; set; }

        //numeric
        [Required]
        [Column("tkhlpnt", TypeName = "numeric", Order = 121)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodtkhlpnt { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de tkhid nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de tkhid nao pode ter mais que 20 caracteres")]
        [Column("tkhid", TypeName = "varchar", Order = 122)]
        public string TbBodtkhid { get; set; }

        //varchar 50
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de tkhpan nao pode ser nulo")]
        [MaxLength(50, ErrorMessage = "O campo de tkhpan nao pode ter mais que 50 caracteres")]
        [Column("tkhpan", TypeName = "varchar", Order = 123)]
        public string TbBodtkhpan { get; set; }

        //numeric
        [Required]
        [Column("tkhodo", TypeName = "numeric", Order = 124)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodtkhodo { get; set; }

        //numeric
        [Required]
        [Column("tkhdid", TypeName = "numeric", Order = 125)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodtkhdid { get; set; }

        //varchar 6
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de nome nao pode ser nulo")]
        [MaxLength(6, ErrorMessage = "O campo de nome nao pode ter mais que 6 caracteres")]
        [Column("nome", TypeName = "varchar", Order = 126)]
        public string TbBodtkhsttnr { get; set; }

        //varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de tkhposcstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de tkhposcstamp nao pode ter mais que 25 caracteres")]
        [Column("tkhposcstamp", TypeName = "varchar", Order = 127)]
        public string TbBodtkhposcstamp { get; set; }

        //varchar 55
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de nomects nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de nomects nao pode ter mais que 55 caracteres")]
        [Column("nomects", TypeName = "varchar", Order = 128)]
        public string TbBodnomects { get; set; }

        //numeric
        [Required]
        [Column("nocts", TypeName = "numeric", Order = 129)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodnocts { get; set; }

        //varchar 2
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de pscmori nao pode ser nulo")]
        [MaxLength(2, ErrorMessage = "O campo de pscmori nao pode ter mais que 2 caracteres")]
        [Column("pscmori", TypeName = "varchar", Order = 130)]
        public string TbBodpscmori { get; set; }

        //varchar 70
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de pscmoridesc nao pode ser nulo")]
        [MaxLength(70, ErrorMessage = "O campo de pscmoridesc nao pode ter mais que 70 caracteres")]
        [Column("pscmoridesc", TypeName = "varchar", Order = 131)]
        public string TbBodpscmoridesc { get; set; }

        //numeric
        [Required]
        [Column("mtotalciva", TypeName = "numeric", Order = 132)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodmtotalciva { get; set; }

        //numeric
        [Required]
        [Column("etotalciva", TypeName = "numeric", Order = 133)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodetotalciva { get; set; }

        //numeric
        [Required]
        [Column("totalciva", TypeName = "numeric", Order = 134)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodtotalciva { get; set; }

        //numeric
        [Required]
        [Column("etotiva", TypeName = "numeric", Order = 135)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodetotiva { get; set; }

        //numeric
        [Required]
        [Column("totiva", TypeName = "numeric", Order = 136)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodtotiva { get; set; }

        //numeric
        [Required]
        [Column("mtotiva", TypeName = "numeric", Order = 137)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodmtotiva { get; set; }

        //varchar 250
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de u_haccpnc nao pode ser nulo")]
        [MaxLength(250, ErrorMessage = "O campo de u_haccpnc nao pode ter mais que 250 caracteres")]
        [Column("u_haccpnc", TypeName = "varchar", Order = 138)]
        public string TbBoduhaccpnc { get; set; }

        //bit
        [Required]
        [Column("u_haccpvei", TypeName = "bit", Order = 139)]
        public bool TbBoduhaccpvei { get; set; }

        //bit
        [Required]
        [Column("u_haccpves", TypeName = "bit", Order = 140)]
        public bool TbBoduhaccpves { get; set; }

        //bit
        [Required]
        [Column("u_haccparr", TypeName = "bit", Order = 141)]
        public bool TbBoduhaccparr { get; set; }

        //bit
        [Required]
        [Column("u_haccptct", TypeName = "bit", Order = 142)]
        public bool TbBoduhaccptct { get; set; }

        //varchar 4
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de u_haccptcc nao pode ser nulo")]
        [MaxLength(4, ErrorMessage = "O campo de u_haccptcc nao pode ter mais que 4 caracteres")]
        [Column("u_haccptcc", TypeName = "varchar", Order = 143)]
        public string TbBoduhaccptcc { get; set; }

        //bit
        [Required]
        [Column("cambiofixo", TypeName = "bit", Order = 144)]
        public bool TbBodcambiofixo { get; set; }

        //numeric
        [Required]
        [Column("cambio", TypeName = "numeric", Order = 145)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodcambio { get; set; }

        //varchar ver tamanhi
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de nome nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de nome nao pode ter mais que 55 caracteres")]
        [Column("nome", TypeName = "varchar", Order = 146)]
        public string TbBodassinatura { get; set; }

        //varchar 40
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de versaochave nao pode ser nulo")]
        [MaxLength(40, ErrorMessage = "O campo de versaochave nao pode ter mais que 40 caracteres")]
        [Column("versaochave", TypeName = "varchar", Order = 147)]
        public string TbBodversaochave { get; set; }

        //bit
        [Required]
        [Column("reorcamento", TypeName = "bit", Order = 148)]
        public bool TbBodreorcamento { get; set; }

        //varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de stamporcamento nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de stamporcamento nao pode ter mais que 25 caracteres")]
        [Column("stamporcamento", TypeName = "varchar", Order = 149)]
        public string TbBodstamporcamento { get; set; }

        //numeric
        [Required]
        [Column("obranoorcamento", TypeName = "numeric", Order = 150)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodobranoorcamento { get; set; }

        //varchar 40
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de versaoorcamento nao pode ser nulo")]
        [MaxLength(40, ErrorMessage = "O campo de versaoorcamento nao pode ter mais que 40 caracteres")]
        [Column("versaoorcamento", TypeName = "varchar", Order = 151)]
        public string TbBodversaoorcamento { get; set; }

        //numeric
        [Required]
        [Column("custototalorc", TypeName = "numeric", Order = 152)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodcustototalorc { get; set; }

        //numeric
        [Required]
        [Column("ecustototalorc", TypeName = "numeric", Order = 153)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodecustototalorc { get; set; }

        //numeric
        [Required]
        [Column("custototalreorc", TypeName = "numeric", Order = 154)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodcustototalreorc { get; set; }

        //numeric
        [Required]
        [Column("ecustototalreorc", TypeName = "numeric", Order = 155)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodecustototalreorc { get; set; }

        //numeric
        [Required]
        [Column("custotaldif", TypeName = "numeric", Order = 156)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal Tbbodcustotaldif { get; set; }

        //numeric
        [Required]
        [Column("ecustotaldif", TypeName = "numeric", Order = 157)]
        [DisplayFormat(NullDisplayText = "Sem ecustotaldif registado", ApplyFormatInEditMode = true)]
        public decimal Tbbodecustotaldif { get; set; }

        //numeric
        [Required]
        [Column("margemtotalorc", TypeName = "numeric", Order = 158)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodmargemtotalorc { get; set; }

        //numeric
        [Required]
        [Column("emargemtotalorc", TypeName = "numeric", Order = 159)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodemargemtotalorc { get; set; }

        //numeric
        [Required]
        [Column("margemtotaldif", TypeName = "numeric", Order = 160)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodmargemtotaldif { get; set; }

        //numeric
        [Required]
        [Column("emargemtotaldif", TypeName = "numeric", Order = 161)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodemargemtotaldif { get; set; }

        //numeric
        [Required]
        [Column("margemorcperc", TypeName = "numeric", Order = 162)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodmargemorcperc { get; set; }

        //numeric
        [Required]
        [Column("margemreorcperc", TypeName = "numeric", Order = 163)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodmargemreorcperc { get; set; }

        //varchar 8
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de horasl nao pode ser nulo")]
        [MaxLength(8, ErrorMessage = "O campo de horasl nao pode ter mais que 8 caracteres")]
        [Column("horasl", TypeName = "varchar", Order = 164)]
        public string TbBodhorasl { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ndosmanual nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de ndosmanual nao pode ter mais que 20 caracteres")]
        [Column("ndosmanual", TypeName = "varchar", Order = 165)]
        public string TbBodndosmanual { get; set; }
        
        //numeric
        [Required]
        [Column("obranomanual", TypeName = "numeric", Order = 166)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBodobranomanual { get; set; }

        public virtual ICollection<TbPBOD> TbBoDs { get; set; } 
    }
}
