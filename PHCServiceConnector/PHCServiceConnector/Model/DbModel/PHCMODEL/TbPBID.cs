using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConnectorService.Model.PHCModel
{
    [Table("bi2")]
    public class TbPBID
    {
        //char 25
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo bistamp   nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de bistamp nao pode ter mais que 25 caracteres")]
        [Column("bi2stamp", TypeName = "char", Order = 0)]
        public string TbBiDbidstamp { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de precatstamp nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de precatstamp nao pode ter mais que 25 caracteres")]
        [Column("precatstamp", TypeName = "char", Order = 1)]
        public string TbBiDprecatstamp { get; set; }

        //numeric
        [Column("qttadj", TypeName = "numeric", Order = 2)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBiDqttadj { get; set; }

        //numeric
        [Column("qttmedida", TypeName = "numeric", Order = 3)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBiDqttmedida { get; set; }

        //numeric
        [Column("qttmedidaval", TypeName = "numeric", Order = 4)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBiDqttmedidaval { get; set; }

        //numeric
        [Column("eqttmedidaval", TypeName = "numeric", Order = 5)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBiDeqttmedidaval { get; set; }

        //numeric
        [Column("qttmedidaperc", TypeName = "numeric", Order = 6)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBiDqttmedidaperc { get; set; }

        //numeric
        [Column("tbrmais", TypeName = "numeric", Order = 7)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBiDtbrmais { get; set; }

        //numeric
        [Column("tbrmaisval", TypeName = "numeric", Order = 8)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBiDtbrmaisval { get; set; }

        //numeric
        [Column("etbrmaisval", TypeName = "numeric", Order = 9)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbBiDetbrmaisval { get; set; }

        //numeric
        [Column("qttapr", TypeName = "numeric", Order = 10)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDqttapr { get; set; }

        //numeric
        [Column("qttaprval", TypeName = "numeric", Order = 11)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDqttaprval { get; set; }

        //numeric
        [Column("eqttaprval", TypeName = "numeric", Order = 12)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDeqttaprval { get; set; }

        //numeric
        [Column("qttnoapr", TypeName = "numeric", Order = 13)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDqttnoapr { get; set; }

        //numeric
        [Column("qttnoaprval", TypeName = "numeric", Order = 14)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDqttnoaprval { get; set; }

        //numeric
        [Column("eqttnoaprval", TypeName = "numeric", Order = 15)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDeqttnoaprval { get; set; }

        //numeric
        [Column("tbrmenos", TypeName = "numeric", Order = 16)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDtbrmenos { get; set; }

        //numeric
        [Column("tbrmenosval", TypeName = "numeric", Order = 17)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDtbrmenosval { get; set; }

        //numeric
        [Column("etbrmenosval", TypeName = "numeric", Order = 18)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDetbrmenosval { get; set; }

        //numeric
        [Column("qttfalta", TypeName = "numeric", Order = 19)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDqttfalta { get; set; }

        //numeric
        [Column("qttfaltaval", TypeName = "numeric", Order = 20)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDqttfaltaval { get; set; }

        //numeric
        [Column("eqttfaltaval", TypeName = "numeric", Order = 21)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDeqttfaltaval { get; set; }

        //numeric
        [Column("qttnew", TypeName = "numeric", Order = 22)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDqttnew { get; set; }

        //numeric
        [Column("valnew", TypeName = "numeric", Order = 23)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDvalnew { get; set; }

        //numeric
        [Column("evalnew", TypeName = "numeric", Order = 24)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDevalnew { get; set; }

        //numeric
        [Column("percnew", TypeName = "numeric", Order = 25)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDpercnew { get; set; }

        //numeric
        [Column("noaprov", TypeName = "numeric", Order = 26)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDnoaprov { get; set; }

        //varchar 40
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de lobsauto nao pode ser nulo")]
        [MaxLength(40, ErrorMessage = "O campo de lobsauto nao pode ter mais que 40 caracteres")]
        [Column("lobsauto", TypeName = "varchar", Order = 27)]
        public string TbiDlobsauto { get; set; }

        //numeric
        [Column("qtttbrmais", TypeName = "numeric", Order = 28)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDqtttbrmais { get; set; }

        //numeric
        [Column("qtttbrmenos", TypeName = "numeric", Order = 29)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDqtttbrmenos { get; set; }

        //numeric
        [Column("qttnewd", TypeName = "numeric", Order = 30)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDqttnewd { get; set; }

        //numeric
        [Column("noaprov2", TypeName = "numeric", Order = 31)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDnoaprovd { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de bostamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de bostamp nao pode ter mais que 25 caracteres")]
        [Column("bostamp", TypeName = "char", Order = 32)]
        public string TbiDbostamp { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ousrinis nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo de ousrinis nao pode ter mais que 30 caracteres")]
        [Column("ousrinis", TypeName = "varchar", Order = 33)]
        public string TbiDousrinis { get; set; }

        //datetime
        [Required]
        [Column("ousrdata", TypeName = "datetime", Order = 34)]
        public DateTime TbiDousrdata { get; set; }

        //varchar 8
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ousrhora nao pode ser nulo")]
        [MaxLength(8, ErrorMessage = "O campo de ousrhora nao pode ter mais que 8 caracteres")]
        [Column("ousrhora", TypeName = "varchar", Order = 35)]
        public string TbiDousrhora { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de usrinis nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo de usrinis nao pode ter mais que 30 caracteres")]
        [Column("usrinis", TypeName = "varchar", Order = 36)]
        public string TbiDusrinis { get; set; }

        //datetime
        [Required]
        [Column("usrdata", TypeName = "datetime", Order = 37)]
        public DateTime TbiDusrdata { get; set; }

        //varchar 8
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de usrhora nao pode ser nulo")]
        [MaxLength(8, ErrorMessage = "O campo de usrhora nao pode ter mais que 8 caracteres")]
        [Column("usrhora", TypeName = "varchar", Order = 38)]
        public string TbiDusrhora { get; set; }

        // bit
        [Required]
        [Column("marcada", TypeName = "bit", Order = 39)]
        public bool TbiDmarcada { get; set; }

        //varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de alvstamp1 nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de alvstamp1 nao pode ter mais que 25 caracteres")]
        [Column("alvstamp1", TypeName = "varchar", Order = 40)]
        public string TbiDalvstampu { get; set; }

        //varchar 55
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de identificacao1 nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de identificacao1 nao pode ter mais que 55 caracteres")]
        [Column("identificacao1", TypeName = "varchar", Order = 41)]
        public string TbiDidentificacaou { get; set; }

        //varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de szzstamp1 nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de szzstamp1 nao pode ter mais que 25 caracteres")]
        [Column("szzstamp1", TypeName = "varchar", Order = 42)]
        public string TbiDszzstampu { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de zona1 nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo de zona1 nao pode ter mais que 30 caracteres")]
        [Column("zona1", TypeName = "varchar", Order = 43)]
        public string TbiDzonau { get; set; }

        //varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de alvstamp2 nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de alvstamp2 nao pode ter mais que 25 caracteres")]
        [Column("alvstamp2", TypeName = "varchar", Order = 44)]
        public string TbiDalvstampd { get; set; }

        //varchar 55
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de identificacao2 nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de identificacao2 nao pode ter mais que 55 caracteres")]
        [Column("identificacao2", TypeName = "varchar", Order = 45)]
        public string TbiDidentificacaod { get; set; }

        //varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de szzstamp2 nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de szzstamp2 nao pode ter mais que 25 caracteres")]
        [Column("szzstamp2", TypeName = "varchar", Order = 46)]
        public string TbiDszzstamp { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de zona2 nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo de zona2 nao pode ter mais que 30 caracteres")]
        [Column("zona2", TypeName = "varchar", Order = 47)]
        public string TbiDzonad { get; set; }

        //numeric
        [Column("qttcompra2", TypeName = "numeric", Order = 48)]
        [DisplayFormat(NullDisplayText = "Sem qttcompra2 registado", ApplyFormatInEditMode = true)]
        public decimal TbiDqttcompra { get; set; }

        //numeric
        [Column("qttenc", TypeName = "numeric", Order = 49)]
        [DisplayFormat(NullDisplayText = "Sem qttenc registado", ApplyFormatInEditMode = true)]
        public decimal TbiDqttenc { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ooobranome nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de ooobranome nao pode ter mais que 20 caracteres")]
        [Column("ooobranome", TypeName = "varchar", Order = 50)]
        public string TbiDooobranome { get; set; }

        // numeric
        [Column("ooobrano", TypeName = "numeric", Order = 51)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDooobrano { get; set; }

        //numeric
        [Column("ooboano", TypeName = "numeric", Order = 52)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDooboano { get; set; }

        //varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de fnstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de fnstamp nao pode ter mais que 25 caracteres")]
        [Column("fnstamp", TypeName = "varchar", Order = 53)]
        public string TbiDfnstamp { get; set; }

        // varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de fodocnome nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de fodocnome nao pode ter mais que 20 caracteres")]
        [Column("fodocnome", TypeName = "varchar", Order = 54)]
        public string TbiDfodocnome { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de foadoc nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de foadoc nao pode ter mais que 20 caracteres")]
        [Column("foadoc", TypeName = "varchar", Order = 55)]
        public string TbiDfoadoc { get; set; }

        // varchar 24
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de oonmdos nao pode ser nulo")]
        [MaxLength(24, ErrorMessage = "O campo de oonmdos nao pode ter mais que 24 caracteres")]
        [Column("oonmdos", TypeName = "varchar", Order = 56)]
        public string TbiDoonmdos { get; set; }

        //bit
        [Required]
        [Column("desemb", TypeName = "datetime", Order = 57)]
        public bool TbiDdesemb { get; set; }

        // char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de origbistamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de origbistamp nao pode ter mais que 25 caracteres")]
        [Column("origbistamp", TypeName = "char", Order = 58)]
        public string TbiDorigbistamp { get; set; }

        //bit
        [Required]
        [Column("semserprv", TypeName = "bit", Order = 59)]
        public bool TbiDsemserprv { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de fistamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de fistamp nao pode ter mais que 25 caracteres")]
        [Column("fistamp", TypeName = "char", Order = 60)]
        public string TbiDfistamp { get; set; }

        // bit
        [Required]
        [Column("aviado", TypeName = "bit", Order = 61)]
        public bool TbiDaviado { get; set; }

        // varhcar 50
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de cladrsdesc nao pode ser nulo")]
        [MaxLength(50, ErrorMessage = "O campo de cladrsdesc nao pode ter mais que 50 caracteres")]
        [Column("cladrsdesc", TypeName = "varchar", Order = 62)]
        public string TbiDcladrsdesc { get; set; }

        // varchar 55
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de morada nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de morada nao pode ter mais que 55 caracteres")]
        [Column("morada", TypeName = "varchar", Order = 63)]
        public string TbiDmorada { get; set; }

        // varhcar 43
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de local nao pode ser nulo")]
        [MaxLength(43, ErrorMessage = "O campo de local nao pode ter mais que 43 caracteres")]
        [Column("local", TypeName = "varchar", Order = 64)]
        public string TbiDlocal { get; set; }

        // varchar 45
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de codpostal nao pode ser nulo")]
        [MaxLength(45, ErrorMessage = "O campo de codpostal nao pode ter mais que 45 caracteres")]
        [Column("codpostal", TypeName = "varchar", Order = 65)]
        public string TbiDcodpostal { get; set; }

        // varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de cladrszona nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo de cladrszona nao pode ter mais que 20 caracteres")]
        [Column("cladrszona", TypeName = "varchar", Order = 66)]
        public string TbiDcladrszona { get; set; }

        // varchar 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de telefone nao pode ser nulo")]
        [MaxLength(60, ErrorMessage = "O campo de telefone nao pode ter mais que 60 caracteres")]
        [Column("telefone", TypeName = "varchar", Order = 67)]
        public string TbiDtelefone { get; set; }

        //varchar 50
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de contacto nao pode ser nulo")]
        [MaxLength(50, ErrorMessage = "O campo de contacto nao pode ter mais que 50 caracteres")]
        [Column("contacto", TypeName = "varchar", Order = 68)]
        public string TbiDcontacto { get; set; }

        //varchar 45
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de email nao pode ser nulo")]
        [MaxLength(45, ErrorMessage = "O campo de email nao pode ter mais que 45 caracteres")]
        [Column("email", TypeName = "varchar", Order = 69)]
        public string TbiDemail { get; set; }

        // varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de cladrsstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de cladrsstamp nao pode ter mais que 25 caracteres")]
        [Column("cladrsstamp", TypeName = "varchar", Order = 70)]
        public string TbiDcladrsstamp { get; set; }

        // bit
        [Required]
        [Column("temfx", TypeName = "bit", Order = 71)]
        public bool TbiDtemfx { get; set; }

        // char 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de descfx nao pode ser nulo")]
        [MaxLength(60, ErrorMessage = "O campo de descfx nao pode ter mais que 60 caracteres")]
        [Column("descfx", TypeName = "char", Order = 72)]
        public string TbiDdescfx { get; set; }

        // char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ofcstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de ofcstamp nao pode ter mais que 25 caracteres")]
        [Column("ofcstamp", TypeName = "char", Order = 73)]
        public string TbiDofcstamp { get; set; }

        //numeric
        [Column("tkhpmp", TypeName = "numeric", Order = 74)]
        [DisplayFormat(NullDisplayText = "Sem tkhpmp registado", ApplyFormatInEditMode = true)]
        public decimal TbiDtkhpmp { get; set; }

        // numeric
        [Column("tkhcodcmb", TypeName = "numeric", Order = 75)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDtkhcodcmb { get; set; }

        //varchar 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de tkhposlstamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de tkhposlstamp nao pode ter mais que 25 caracteres")]
        [Column("tkhposlstamp", TypeName = "varchar", Order = 76)]
        public string TbiDtkhposlstamp { get; set; }

        // numeric
        [Column("eftaxamt_a", TypeName = "numeric", Order = 77)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDeftaxamta { get; set; }

        // numeric
        [Column("eftaxamt_b", TypeName = "numeric", Order = 78)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDeftaxamtb { get; set; }


        //numeric
        [Column("ftaxamt_a", TypeName = "numeric", Order = 79)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDftaxamta { get; set; }

        //numeric
        [Column("ftaxamt_b", TypeName = "numeric", Order = 80)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDftaxamtb { get; set; }

        //varchar 2
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de nome nao pode ser nulo")]
        [MaxLength(2, ErrorMessage = "O campo de nome nao pode ter mais que 2 caracteres")]
        [Column("pscmori", TypeName = "varchar", Order = 81)]
        public string TbiDpscmori { get; set; }

        //varchar 70
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de nome nao pode ser nulo")]
        [MaxLength(70, ErrorMessage = "O campo de nome nao pode ter mais que 70 caracteres")]
        [Column("pscmoridesc", TypeName = "varchar", Order = 82)]
        public string TbiDpscmoridesc { get; set; }

        // varchar 3
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de u_haccpfo nao pode ser nulo")]
        [MaxLength(3, ErrorMessage = "O campo de u_haccpfo nao pode ter mais que 3 caracteres")]
        [Column("u_haccpfo", TypeName = "varchar", Order = 83)]
        public string TbiDuhaccpfo { get; set; }

        // varchar 3
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de u_haccpso nao pode ser nulo")]
        [MaxLength(3, ErrorMessage = "O campo de u_haccpso nao pode ter mais que 3 caracteres")]
        [Column("u_haccpso", TypeName = "varchar", Order = 84)]
        public string TbiDuhaccpso { get; set; }

        // varchar 3
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de u_haccplf nao pode ser nulo")]
        [MaxLength(3, ErrorMessage = "O campo de u_haccplf nao pode ter mais que 3 caracteres")]
        [Column("u_haccplf", TypeName = "varchar", Order = 85)]
        public string TbiDuhaccplf { get; set; }

        // bit
        [Required]
        [Column("u_haccpteo", TypeName = "bit", Order = 86)]
        public bool TbiDuhaccpteo { get; set; }

        // varchar 3
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de u_haccplin nao pode ser nulo")]
        [MaxLength(3, ErrorMessage = "O campo de u_haccplin nao pode ter mais que 3 caracteres")]
        [Column("u_haccplin", TypeName = "varchar", Order = 87)]
        public string TbiDuhaccplin { get; set; }

        // varchar 3
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de u_haccptp nao pode ser nulo")]
        [MaxLength(3, ErrorMessage = "O campo de u_haccptp nao pode ter mais que 3 caracteres")]
        [Column("u_haccptp", TypeName = "varchar", Order = 88)]
        public string TbiDuhaccptp { get; set; }

         // varchar 3
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de u_haccptlp nao pode ser nulo")]
        [MaxLength(3, ErrorMessage = "O campo de u_haccptlp nao pode ter mais que 3 caracteres")]
        [Column("u_haccptlp", TypeName = "varchar", Order = 89)]
        public string TbiDuhaccptlp { get; set; }

        [Required]
        [Column("u_haccpaf", TypeName = "bit", Order = 90)]
         // bit 
        public bool TbiDuhaccpaf { get; set; }

         // bit
        [Required]
        [Column("u_haccptra", TypeName = "bit", Order = 91)]
        public bool TbiDuhaccptra { get; set; }

      // bit
        [Required]
        [Column("u_haccptem", TypeName = "bit", Order = 92)]
        public bool TbiDuhaccptem { get; set; }

         // bit
        [Required]
        [Column("u_haccpemb", TypeName = "bit", Order = 93)]
        public bool TbiDuhaccpemb { get; set; }

        // bit
        [Required]
        [Column("u_haccprot", TypeName = "bit", Order = 94)]
        public bool TbiDuhaccprot { get; set; }
        
         // bit 
        [Required]
        [Column("u_haccpdat", TypeName = "bit", Order = 95)]
        public bool TbiDuhaccpdat { get; set; }
        
         // bit 
        [Required]
        [Column("u_haccppro", TypeName = "bit", Order = 96)]
        public bool TbiDuhaccppro { get; set; }

        //numeric
        [Required]
        [Column("u_haccphor", TypeName = "numeric", Order = 97)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDuhaccphor { get; set; }

        //numeric
        [Required]
        [Column("Dmcomercial", TypeName = "numeric", Order = 98)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDmcomercial { get; set; }

        //bit
        [Required]
        [Column("usamcomercial", TypeName = "bit", Order = 99)]
        public bool TbiDusamcomercial { get; set; }

        //numeric
        [Required]
        [Column("qttatrib", TypeName = "numeric", Order = 100)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDqttatrib { get; set; }

        //numeric
        [Required]
        [Column("qttorcamento", TypeName = "numeric", Order = 101)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDqttorcamento { get; set; }

        //numeric 
        [Required]
        [Column("ecustoindorcamento", TypeName = "numeric", Order = 102)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDecustoindorcamento { get; set; }

        //numeric
        [Required]
        [Column("ustoindorcamento", TypeName = "numeric", Order = 103)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDcustoindorcamento { get; set; }

        //numeric
        [Required]
        [Column("ecustototalorcamento", TypeName = "numeric", Order = 104)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDecustototalorcamento { get; set; }

        //numeric
        [Required]
        [Column("custototalorcamento", TypeName = "numeric", Order = 105)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDcustototalorcamento { get; set; }

        //numeric
        [Required]
        [Column("emargemorcamento", TypeName = "numeric", Order = 106)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDemargemorcamento { get; set; }

        //numeric
        [Required]
        [Column("margemorcamento", TypeName = "numeric", Order = 107)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDmargemorcamento { get; set; }

        //numeric
        [Required]
        [Column("qttdif", TypeName = "numeric", Order = 108)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDqttdif { get; set; }

        //numeric
        [Required]
        [Column("ecustoinddif", TypeName = "numeric", Order = 109)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDecustoinddif { get; set; }

        //numeric
        [Required]
        [Column("ustoinddif", TypeName = "numeric", Order = 110)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDcustoinddif { get; set; }

        //numeric
        [Required]
        [Column("ecustotaldif", TypeName = "numeric", Order = 111)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDecustotaldif { get; set; }

        //numeric
        [Required]
        [Column("custotaldif", TypeName = "numeric", Order = 112)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDcustotaldif { get; set; }

        //numeric
        [Required]
        [Column("emargemdif", TypeName = "numeric", Order = 113)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDemargemdif { get; set; }


        //numeric
        [Required]
        [Column("margemdif", TypeName = "numeric", Order = 114)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDmargemdif { get; set; }

        //numeric
        [Required]
        [Column("qttdifperc", TypeName = "numeric", Order = 115)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDqttdifperc { get; set; }

        //numeric
        [Required]
        [Column("custoinddifperc", TypeName = "numeric", Order = 116)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDcustoinddifperc { get; set; }

        //numeric
        [Required]
        [Column("custotaldifperc", TypeName = "numeric", Order = 117)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbiDcustotaldifperc { get; set; }

        public virtual ICollection<TbPBID> TbBiDois { get; set; } 

    }

}
