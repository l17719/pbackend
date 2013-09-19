using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ConnectorService.Model.PHCModel
{
    [Table("st")]
    public class TbStock
    {
        // arranjar os campos e ordenacao

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("ststamp", TypeName = "char", Order = 0)]
        public string TbStockStamp { get; set; }
        //

        //key char 18
        [Key]
        [MaxLength(18, ErrorMessage = "O campo ref nao pode ter mais que 18 caracteres")]
        [Column("ref", TypeName = "char", Order = 1)]
        public string TbStockref { get; set; }

        //char 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo design nao pode ser nulo")]
        [MaxLength(60, ErrorMessage = "O campo stamp nao pode ter mais que 60 caracteres")]
        [Column("design", TypeName = "char", Order = 2)]
        public string TbStockdesign { get; set; }

        //varchar 18
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo familia nao pode ser nulo")]
        [MaxLength(18, ErrorMessage = "O campo familia nao pode ter mais que 18 caracteres")]
        [Column("familia", TypeName = "char", Order = 3)]
        public string TbStockfamilia { get; set; }

        //numeric
        [Required]
        [Column("stock", TypeName = "numeric", Order = 4)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockstock { get; set; }

        //numeric
        [Required]
        [Column("epv1", TypeName = "numeric", Order = 5)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockepv1 { get; set; }

        //numeric
        [Required]
        [Column("pv1", TypeName = "numeric", Order = 6)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockpv1 { get; set; }

        //char 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo forref nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo forref nao pode ter mais que 25 caracteres")]
        [Column("forref", TypeName = "char", Order = 7)]
        public string TbStockforref { get; set; }

        //varchar 55
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo fornecedor nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo fornecedor nao pode ter mais que 55 caracteres")]
        [Column("fornecedor", TypeName = "varchar", Order = 8)]
        public string TbStockfornecedor { get; set; }

        //varchar 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo desc3 nao pode ser nulo")]
        [MaxLength(60, ErrorMessage = "O campo desc3 nao pode ter mais que 60 caracteres")]
        [Column("desc3", TypeName = "varchar", Order = 9)]
        public string TbStockdesct { get; set; }

        //varchar 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo desc2 nao pode ser nulo")]
        [MaxLength(60, ErrorMessage = "O campo desc2 nao pode ter mais que 60 caracteres")]
        [Column("desc2", TypeName = "varchar", Order = 10)]
        public string TbStockdescd { get; set; }

        //varchar 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 60 caracteres")]
        [Column("desc1", TypeName = "varchar", Order = 11)]
        public string TbStockdescu { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo usr2 nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo usr2 nao pode ter mais que 20 caracteres")]
        [Column("usr2", TypeName = "varchar", Order = 12)]
        public string TbStockusrd { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo usr1 nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo usr1 nao pode ter mais que 20 caracteres")]
        [Column("usr1", TypeName = "varchar", Order = 13)]
        public string TbStockusru { get; set; }

        //datetime
        [Required]
        [Column("validade", TypeName = "datetime", Order = 14)]
        public DateTime TbStockvalidade { get; set; }

        //datetime
        [Required]
        [Column("usaid", TypeName = "datetime", Order = 15)]
        public DateTime TbStockusaid { get; set; }

        //datetime
        [Required]
        [Column("uintr", TypeName = "datetime", Order = 16)]
        public DateTime TbStockuintr { get; set; }

        //numeric
        [Required]
        [Column("usrqtt", TypeName = "numeric", Order = 17)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockusrqtt { get; set; }

        //numeric
        [Required]
        [Column("eoq", TypeName = "numeric", Order = 18)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockeoq { get; set; }

        //numeric
        [Required]
        [Column("pcult", TypeName = "numeric", Order = 19)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockpcult { get; set; }

        //numeric
        [Required]
        [Column("pcimp", TypeName = "numeric", Order = 20)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockpcimp { get; set; }

        //varchar 3
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("pcmoe", TypeName = "char", Order = 21)]
        public string TbStockpcmoe { get; set; }

        //numeric
        [Required]
        [Column("pvcon", TypeName = "numeric", Order = 22)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockpvcon { get; set; }

        //numeric
        [Required]
        [Column("pvultimo", TypeName = "numeric", Order = 23)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockpvultimo { get; set; }

        //numeric
        [Required]
        [Column("pv3", TypeName = "numeric", Order = 24)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockpvt { get; set; }
        
        //numeric
        [Required]
        [Column("pv2", TypeName = "numeric", Order = 25)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockpvd { get; set; }

        //varchar 4
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo unidade nao pode ser nulo")]
        [MaxLength(4, ErrorMessage = "O campo unidade nao pode ter mais que 4 caracteres")]
        [Column("unidade", TypeName = "char", Order = 26)]
        public string TbStockunidade { get; set; }

        //numeric
        [Required]
        [Column("ptoenc", TypeName = "numeric", Order = 27)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockptoenc { get; set; }

        //numeric
        [Required]
        [Column("tabiva", TypeName = "numeric", Order = 28)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStocktabiva { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo local nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo local nao pode ter mais que 25 caracteres")]
        [Column("local", TypeName = "char", Order = 29)]
        public string TbStocklocal { get; set; }

        //numeric
        [Required]
        [Column("fornec", TypeName = "numeric", Order = 30)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockforncec { get; set; }

        //numeric
        [Required]
        [Column("fornestab", TypeName = "numeric", Order = 31)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockfornestab { get; set; }

        //numeric
        [Required]
        [Column("qttfor", TypeName = "numeric", Order = 32)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockqttfor { get; set; }

        //numeric
        [Required]
        [Column("qttcli", TypeName = "numeric", Order = 33)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockqttcli { get; set; }

        //numeric
        [Required]
        [Column("qttrec", TypeName = "numeric", Order = 34)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockqttrec { get; set; }

        //datetime
        [Required]
        [Column("udata", TypeName = "datetime", Order = 35)]
        public DateTime TbStockudata { get; set; }

        //numeric
        [Required]
        [Column("pcusto", TypeName = "numeric", Order = 36)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockpcusto { get; set; }

        //numeric
        [Required]
        [Column("pcpond", TypeName = "numeric", Order = 37)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockpcpond { get; set; }

        //numeric
        [Required]
        [Column("qttacin", TypeName = "numeric", Order = 38)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockqttacin { get; set; }

        //numeric
        [Required]
        [Column("qttacout", TypeName = "numeric", Order = 39)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockqttacout { get; set; }

        //numeric
        [Required]
        [Column("qttvend", TypeName = "numeric", Order = 40)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockqttvend { get; set; }

        //numeric
        [Required]
        [Column("pmvenda", TypeName = "numeric", Order = 41)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockpmvenda { get; set; }

        //numeric
        [Required]
        [Column("valin", TypeName = "numeric", Order = 42)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockvalin { get; set; }

        //numeric
        [Required]
        [Column("valout", TypeName = "numeric", Order = 43)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockvalout { get; set; }

        //numeric
        [Required]
        [Column("stmax", TypeName = "numeric", Order = 44)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockstmax { get; set; }

        //numeric
        [Required]
        [Column("stmin", TypeName = "numeric", Order = 45)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockstmin { get; set; }

        //varchar 68
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("obs", TypeName = "char", Order = 46)]
        public string TbStockobs { get; set; }

        //char 40
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo codigo nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo codigo nao pode ter mais que 25 caracteres")]
        [Column("codigo", TypeName = "char", Order = 47)]
        public string TbStockcodigo { get; set; }

        //varchar 2
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo uni2 nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo uni2 nao pode ter mais que 25 caracteres")]
        [Column("uni2", TypeName = "char", Order = 48)]
        public string TbStockunidois { get; set; }

        //numeric
        [Required]
        [Column("conversao", TypeName = "numeric", Order = 49)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockconversao { get; set; }

        //bit
        [Required]
        [Column("ivaincl", TypeName = "bit", Order = 50)]
        public bool TbStockivaincl { get; set; }
        
        //bit
        [Required]
        [Column("nsujpp", TypeName = "bit", Order = 51)]
        public bool TbStocknsujpp { get; set; }

        //numeric
        [Required]
        [Column("ecomissao", TypeName = "numeric", Order = 52)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockecomissao { get; set; }

        //varchar 120
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo imagem nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo imagem nao pode ter mais que 25 caracteres")]
        [Column("imagem", TypeName = "char", Order = 53)]
        public string TbStockimagem { get; set; }

        //numeric
        [Required]
        [Column("cbbno", TypeName = "numeric", Order = 54)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockpvq { get; set; }

        //numeric
        [Required]
        [Column("pv4", TypeName = "numeric", Order = 55)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockpvc { get; set; }

        //numeric
        [Required]
        [Column("cpoc", TypeName = "numeric", Order = 56)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockcpoc { get; set; }

        //varchar 15
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo containv nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo containv nao pode ter mais que 25 caracteres")]
        [Column("containv", TypeName = "char", Order = 57)]
        public string TbStockcontainv { get; set; }

        //varchar 15
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo contacev nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo contacev nao pode ter mais que 25 caracteres")]
        [Column("contacev", TypeName = "char", Order = 58)]
        public string TbStockcontacev { get; set; }

        //varchar 15
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo contareo nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo contareo nao pode ter mais que 25 caracteres")]
        [Column("contareo", TypeName = "char", Order = 59)]
        public string TbStockcontareo { get; set; }

        //varchar 15
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo contacoe nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo contacoe nao pode ter mais que 25 caracteres")]
        [Column("contacoe", TypeName = "char", Order = 60)]
        public string TbStockcontacoe { get; set; }

        //numeric
        [Required]
        [Column("peso", TypeName = "numeric", Order = 61)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockpeso { get; set; }

        //bit
        [Required]
        [Column("bloqueado", TypeName = "bit", Order = 62)]
        public bool TbStockbloqueado { get; set; }

        //bit
        [Required]
        [Column("fobloq", TypeName = "bit", Order = 63)]
        public bool TbStockfobloq { get; set; }

        //numeric
        [Required]
        [Column("mfornec", TypeName = "numeric", Order = 64)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockmfornec { get; set; }

        //numeric
        [Required]
        [Column("mfornec2", TypeName = "numeric", Order = 65)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockmfornecd { get; set; }

        //numeric
        [Required]
        [Column("pentrega", TypeName = "numeric", Order = 66)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockpentrega { get; set; }

        //numeric
        [Required]
        [Column("consumo", TypeName = "numeric", Order = 67)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockconsumo { get; set; }

        //bit
        [Required]
        [Column("baixr", TypeName = "bit", Order = 68)]
        public bool TbStockbaixr { get; set; }

        //numeric
        [Required]
        [Column("despimp", TypeName = "numeric", Order = 109)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockdespimp { get; set; }

        //numeric
        [Required]
        [Column("mesescon", TypeName = "numeric", Order = 69)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockmesescon { get; set; }

        //numeric
        [Required]
        [Column("marg1", TypeName = "numeric", Order = 70)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockmargu { get; set; }

        //numeric
        [Required]
        [Column("marg2", TypeName = "numeric", Order = 71)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockmargd { get; set; }

        //numeric
        [Required]
        [Column("marg3", TypeName = "numeric", Order = 72)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockmargt { get; set; }

        //numeric
        [Required]
        [Column("marg4", TypeName = "numeric", Order = 73)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockmargq { get; set; }


        //numeric
        [Required]
        [Column("marg5", TypeName = "numeric", Order = 74)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockmargc { get; set; }

        //numeric
        [Required]
        [Column("diaspto", TypeName = "numeric", Order = 75)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockdiaspto { get; set; }

        //numeric
        [Required]
        [Column("diaseoq", TypeName = "numeric", Order = 76)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockdiaseoq { get; set; }

        //varchar 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo desc4 nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo desc4 nao pode ter mais que 25 caracteres")]
        [Column("desc4", TypeName = "char", Order = 77)]
        public string TbStockdescq { get; set; }

        //varchar 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo desc5 nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo desc5 nao pode ter mais que 25 caracteres")]
        [Column("desc5", TypeName = "char", Order = 78)]
        public string TbStockdescc { get; set; }

        //varchar 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo desc6 nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo desc6 nao pode ter mais que 25 caracteres")]
        [Column("desc6", TypeName = "char", Order = 79)]
        public string TbStockdescs { get; set; }

        //bit
        [Required]
        [Column("noserie", TypeName = "bit", Order = 80)]
        public bool TbStocknoserie { get; set; }

        //bit
        [Required]
        [Column("clinica", TypeName = "bit", Order = 81)]
        public bool TbStockclinica { get; set; }

        //bit
        [Required]
        [Column("vasilhame", TypeName = "bit", Order = 82)]
        public bool TbStockvasilhame { get; set; }

        //numeric
        [Required]
        [Column("pbruto", TypeName = "numeric", Order = 83)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockpbruto { get; set; }

        //numeric
        [Required]
        [Column("volume", TypeName = "numeric", Order = 84)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockvolume { get; set; }

        //bit
        [Required]
        [Column("usalote", TypeName = "bit", Order = 85)]
        public bool TbStockusalote { get; set; }

        //bit
        [Required]
        [Column("texteis", TypeName = "bit", Order = 86)]
        public bool TbStocktexteis { get; set; }

        //numeric
        [Required]
        [Column("garantia", TypeName = "numeric", Order = 87)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockgarantia { get; set; }

        //datetime
        [Required]
        [Column("opendata", TypeName = "datetime", Order = 88)]
        public DateTime TbStockopendata { get; set; }

        //varchar 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo faminome nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo faminome nao pode ter mais que 25 caracteres")]
        [Column("faminome", TypeName = "char", Order = 89)]
        public string TbStockfaminome { get; set; }

        //varchar 35
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo usr3 nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo usr3 nao pode ter mais que 25 caracteres")]
        [Column("usr3", TypeName = "char", Order = 90)]
        public string TbStockusrt { get; set; }

        //varchar 35
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo usr4 nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo usr4 nao pode ter mais que 25 caracteres")]
        [Column("usr4", TypeName = "char", Order = 91)]
        public string TbStockusrq { get; set; }

        //varchar 35
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo usr5 nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo usr5 nao pode ter mais que 25 caracteres")]
        [Column("usr5", TypeName = "char", Order = 92)]
        public string TbStockusrc { get; set; }

        //numeric
        [Required]
        [Column("qttesp", TypeName = "numeric", Order = 93)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockqttesp { get; set; }

        //numeric
        [Required]
        [Column("epv2", TypeName = "numeric", Order = 94)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockepvd { get; set; }

        //numeric
        [Required]
        [Column("epv3", TypeName = "numeric", Order = 96)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockepvt { get; set; }

        //numeric
        [Required]
        [Column("epv4", TypeName = "numeric", Order = 97)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockepvq { get; set; }

        //numeric
        [Required]
        [Column("epv5", TypeName = "numeric", Order = 98)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockepvc { get; set; }

        //numeric
        [Required]
        [Column("epcusto", TypeName = "numeric", Order = 99)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockepcusto { get; set; }

        //numeric
        [Required]
        [Column("epcpond", TypeName = "numeric", Order = 100)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockepcpond { get; set; }

        //numeric
        [Required]
        [Column("epcult", TypeName = "numeric", Order = 101)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockepcult { get; set; }

        //numeric
        [Required]
        [Column("epmvenda", TypeName = "numeric", Order = 102)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockepmvenda { get; set; }

        //numeric
        [Required]
        [Column("epvultimo", TypeName = "numeric", Order = 103)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockepvultimo { get; set; }

        //numeric
        [Required]
        [Column("epvcon", TypeName = "numeric", Order = 104)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockepvcon { get; set; }

        //bit
        [Required]
        [Column("iva1incl", TypeName = "bit", Order = 105)]
        public decimal TbStockivauincl { get; set; }

        //bit
        [Required]
        [Column("iva2incl", TypeName = "bit", Order = 106)]
        public decimal TbStockivadincl { get; set; }

        //bit
        [Required]
        [Column("iva3incl", TypeName = "bit", Order = 107)]
        public decimal TbStockivatincl { get; set; }

        //bit
        [Required]
        [Column("iva4incl", TypeName = "bit", Order = 108)]
        public decimal TbStockivaqincl { get; set; }

        //bit
        [Required]
        [Column("iva5incl", TypeName = "bit", Order = 109)]
        public decimal TbStockivacincl { get; set; }

        //bit
        [Required]
        [Column("ivapcincl", TypeName = "bit", Order = 110)]
        public bool TbStockivapcincl { get; set; }

        //bit
        [Required]
        [Column("stns", TypeName = "bit", Order = 111)]
        public bool TbStockstns { get; set; }

        //numeric
        [Required]
        [Column("stid", TypeName = "numeric", Order = 112)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockstid { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo tipodesc nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo tipodesc nao pode ter mais que 25 caracteres")]
        [Column("tipodesc", TypeName = "char", Order = 113)]
        public string TbStocktipodesc { get; set; }

        //varchar 3
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo usr6 nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo usr6 nao pode ter mais que 25 caracteres")]
        [Column("usr6", TypeName = "char", Order = 114)]
        public string TbStockusrseis { get; set; }

        //numeric
        [Required]
        [Column("convunsup", TypeName = "numeric", Order = 115)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockconvunsup { get; set; }

        //varchar 18
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo nccod nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo nccod nao pode ter mais que 25 caracteres")]
        [Column("nccod", TypeName = "char", Order = 116)]
        public string TbStocknccod { get; set; }

        //numeric
        [Required]
        [Column("massaliq", TypeName = "numeric", Order = 117)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockmassaliq { get; set; }

        //varchar 100
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo url nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo url nao pode ter mais que 25 caracteres")]
        [Column("url", TypeName = "char", Order = 118)]
        public string TbStockurl { get; set; }

        //numeric
        [Required]
        [Column("vaiwww", TypeName = "numeric", Order = 119)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockvaiwww { get; set; }

        //bit
        [Required]
        [Column("iectsug", TypeName = "bit", Order = 120)]
        public bool TbStockiectsug { get; set; }

        //numeric
        [Required]
        [Column("iectin", TypeName = "numeric", Order = 121)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockiectin { get; set; }

        //numeric
        [Required]
        [Column("eiectin", TypeName = "numeric", Order = 122)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockeiectin { get; set; }

        //bit
        [Required]
        [Column("iectinii", TypeName = "bit", Order = 123)]
        public bool TbStockiectinii { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo codfiscal nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo codfiscal nao pode ter mais que 25 caracteres")]
        [Column("codfiscal", TypeName = "char", Order = 124)]
        public string TbStockcodfiscal { get; set; }

        //bit
        [Required]
        [Column("iecasug", TypeName = "bit", Order = 125)]
        public bool TbStockiecasug { get; set; }
        
        //numeric
        [Required]
        [Column("iecagrad", TypeName = "numeric", Order = 126)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockiecagrad { get; set; }

        //varchar 18
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo iecaref nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo iecaref nao pode ter mais que 25 caracteres")]
        [Column("iecaref", TypeName = "char", Order = 127)]
        public string TbStockiecaref { get; set; }

        //varchar 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo iecarefnome nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo iecarefnome nao pode ter mais que 25 caracteres")]
        [Column("iecarefnome", TypeName = "char", Order = 128)]
        public string TbStockiecarefnome { get; set; }

        //varchar 18
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo txieca nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo txieca nao pode ter mais que 25 caracteres")]
        [Column("txieca", TypeName = "char", Order = 129)]
        public string TbStocktxieca { get; set; }

        //varchar 115
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo txiecanome nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo txiecanome nao pode ter mais que 25 caracteres")]
        [Column("txiecanome", TypeName = "char", Order = 130)]
        public string TbStocktxiecanome { get; set; }

        //varchar 4
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo iecautt nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo iecautt nao pode ter mais que 25 caracteres")]
        [Column("iecautt", TypeName = "char", Order = 131)]
        public string TbStockiecautt { get; set; }


        //bit
        [Required]
        [Column("iecamultgrad", TypeName = "bit", Order = 132)]
        public bool TbStockiecamultgrad { get; set; }

        //bit
        [Required]
        [Column("iecaisref", TypeName = "bit", Order = 108)]
        public bool TbStockiecaisref { get; set; }

        //varchar 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo site nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo site nao pode ter mais que 25 caracteres")]
        [Column("site", TypeName = "char", Order = 133)]
        public string TbStocksite { get; set; }

        //bit
        [Required]
        [Column("qlook", TypeName = "bit", Order = 134)]
        public bool TbStockqlook { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo txtqlook nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo txtqlook nao pode ter mais que 25 caracteres")]
        [Column("txtqlook", TypeName = "char", Order = 135)]
        public string TbStocktxtqlook { get; set; }

        //varchar 120
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo imgqlook nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo imgqlook nao pode ter mais que 25 caracteres")]
        [Column("imgqlook", TypeName = "char", Order = 136)]
        public string TbStockimgqlook { get; set; }

        //char 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("lang1", TypeName = "char", Order = 137)]
        public string TbStocklangu { get; set; }

        //char 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("langdes1", TypeName = "char", Order = 138)]
        public string TbStocklangdesu { get; set; }

        //char 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("lang2", TypeName = "char", Order = 139)]
        public string TbStocklangd { get; set; }

        //char 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("langdes2", TypeName = "char", Order = 140)]
        public string TbStocklangdesd { get; set; }

        //char 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("lang3", TypeName = "char", Order = 141)]
        public string TbStocklangt { get; set; }

        //char 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("langdes3", TypeName = "char", Order = 142)]
        public string TbStocklangdest { get; set; }

        //char 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("lang4", TypeName = "char", Order = 143)]
        public string TbStocklangq { get; set; }

        //char 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("langdes4", TypeName = "char", Order = 144)]
        public string TbStocklangdesq { get; set; }

        //char 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("lang5", TypeName = "char", Order = 145)]
        public string TbStocklangc { get; set; }

        //char 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("langdes5", TypeName = "char", Order = 146)]
        public string TbStocklangdesc { get; set; }

        //bit
        [Required]
        [Column("nexist", TypeName = "bit", Order = 147)]
        public bool TbStocknexist { get; set; }

        //varchar 1
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo statuspda nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo statuspda nao pode ter mais que 25 caracteres")]
        [Column("statuspda", TypeName = "char", Order = 148)]
        public string TbStockstatuspda { get; set; }

        //numeric
        [Required]
        [Column("qttcat", TypeName = "numeric", Order = 149)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockqttcat { get; set; }

        //bit
        [Required]
        [Column("compnovo", TypeName = "bit", Order = 150)]
        public bool TbStockcompnovo { get; set; }

        //bit
        [Required]
        [Column("ecovalor", TypeName = "bit", Order = 151)]
        public bool TbStockecovalor { get; set; }

        //numeric
        [Required]
        [Column("eecoval", TypeName = "numeric", Order = 152)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockeecolval { get; set; }

        //numeric
        [Required]
        [Column("ecoval", TypeName = "numeric", Order = 153)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockecoval { get; set; }

        //bit
        [Required]
        [Column("ecopl", TypeName = "bit", Order = 154)]
        public bool TbStockecopl { get; set; }

        //numeric
        [Required]
        [Column("eecopval", TypeName = "numeric", Order = 155)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockeecopval { get; set; }

        //numeric
        [Required]
        [Column("ecopval", TypeName = "numeric", Order = 156)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockecopval { get; set; }

        //bit
        [Required]
        [Column("ecoel", TypeName = "bit", Order = 157)]
        public bool TbStockecoel { get; set; }

        //numeric
        [Required]
        [Column("eecoeval", TypeName = "numeric", Order = 158)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockeecoeval { get; set; }

        //numeric
        [Required]
        [Column("ecoeval", TypeName = "numeric", Order = 159)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockecoeval { get; set; }

        //bit
        [Required]
        [Column("ecorl", TypeName = "bit", Order = 160)]
        public bool TbStockecorl { get; set; }

        //numeric
        [Required]
        [Column("eecorval", TypeName = "numeric", Order = 161)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockeecorval { get; set; }

        //numeric
        [Required]
        [Column("ecorval", TypeName = "numeric", Order = 162)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockecorval { get; set; }

        //bit
        [Required]
        [Column("ecool", TypeName = "bit", Order = 163)]
        public bool TbStockecool { get; set; }

        //numeric
        [Required]
        [Column("eecooval", TypeName = "numeric", Order = 164)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockeecooval { get; set; }

        //numeric
        [Required]
        [Column("ecooval", TypeName = "numeric", Order = 165)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockecooval { get; set; }
        
        //bit
        [Required]
        [Column("ecopilha", TypeName = "bit", Order = 166)]
        public bool TbStockecopilha { get; set; }

        //bit
        [Required]
        [Column("ecoacumulador", TypeName = "bit", Order = 167)]
        public bool TbStockecoacumulador { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ousrinis nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo de ousrinis nao pode ter mais que 30 caracteres")]
        [Column("ousrinis", TypeName = "varchar", Order = 168)]
        public string TbStockousrinis { get; set; }

        //datetime
        [Required]
        [Column("ousrdata", TypeName = "datetime", Order = 169)]
        public DateTime TbStockousrdata { get; set; }


        //varchar 8
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de ousrhora nao pode ser nulo")]
        [MaxLength(8, ErrorMessage = "O campo de ousrhora nao pode ter mais que 8 caracteres")]
        [Column("ousrhora", TypeName = "varchar", Order = 170)]
        public string TbStockousrhora { get; set; }

        //varchar 30
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de usrinis nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo de usrinis nao pode ter mais que 30 caracteres")]
        [Column("usrinis", TypeName = "varchar", Order = 171)]
        public string TbStockusrinis { get; set; }

        //datetime
        [Required]
        [Column("usrdata", TypeName = "datetime", Order = 172)]
        public DateTime TbStockusrdata { get; set; }

        //varchar 8
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de usrhora nao pode ser nulo")]
        [MaxLength(8, ErrorMessage = "O campo de usrhora nao pode ter mais que 8 caracteres")]
        [Column("usrhora", TypeName = "varchar", Order = 173)]
        public string TbStockusrhora { get; set; }

        //bit
        [Required]
        [Column("marcada", TypeName = "bit", Order = 174)]
        public bool TbStockmarcada { get; set; }

        //bit
        [Required]
        [Column("qtttouch", TypeName = "bit", Order = 175)]
        public bool TbStockqtttouch { get; set; }

        //bit
        [Required]
        [Column("semserprv", TypeName = "bit", Order = 176)]
        public bool TbStocksemserprv { get; set; }

        //varchar 15
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("contaieo", TypeName = "char", Order = 177)]
        public string TbStockcontaieo { get; set; }

        //bit
        [Required]
        [Column("inactivo", TypeName = "bit", Order = 178)]
        public bool TbStockinactivo { get; set; }

        //bit
        [Required]
        [Column("orcamento", TypeName = "bit", Order = 179)]
        public bool TbStockorcamento { get; set; }

        //char 18
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("refmo", TypeName = "char", Order = 180)]
        public string TbStockrefmo { get; set; }

        //char 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("descrmo", TypeName = "char", Order = 181)]
        public string TbStockdescrmo { get; set; }

        //numeric
        [Required]
        [Column("pcmo", TypeName = "numeric", Order = 182)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockpcmo { get; set; }

        //numeric
        [Required]
        [Column("epcmo", TypeName = "numeric", Order = 183)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockepcmo { get; set; }

        //numeric
        [Required]
        [Column("custo", TypeName = "numeric", Order = 184)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockcusto { get; set; }

        //numeric
        [Required]
        [Column("ecusto", TypeName = "numeric", Order = 109)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockecusto { get; set; }

        //numeric
        [Required]
        [Column("desci", TypeName = "numeric", Order = 185)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockdesci { get; set; }

        //numeric
        [Required]
        [Column("descii", TypeName = "numeric", Order = 186)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockdescii { get; set; }

        //datetime
        [Required]
        [Column("datar", TypeName = "datetime", Order = 187)]
        public DateTime TbStockdatar { get; set; }

        //numeric
        [Required]
        [Column("pcdisp", TypeName = "numeric", Order = 188)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockpcdisp { get; set; }

        //numeric
        [Required]
        [Column("epcdisp", TypeName = "numeric", Order = 189)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockepcdisp { get; set; }

        //numeric
        [Required]
        [Column("pclab", TypeName = "numeric", Order = 190)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockpclab { get; set; }

        //numeric
        [Required]
        [Column("epclab", TypeName = "numeric", Order = 191)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockepclab { get; set; }

        //numeric
        [Required]
        [Column("custof", TypeName = "numeric", Order = 192)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockcustof { get; set; }

        //numeric
        [Required]
        [Column("ecustof", TypeName = "numeric", Order = 193)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockecustof { get; set; }

        //char 25
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("ofcstamp", TypeName = "char", Order = 194)]
        public string TbStockofcstamp { get; set; }

        //numeric
        [Required]
        [Column("custog", TypeName = "numeric", Order = 195)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockcustog { get; set; }

        //numeric
        [Required]
        [Column("ecustog", TypeName = "numeric", Order = 196)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockecustog { get; set; }

        //varchar 4
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("unidadef", TypeName = "char", Order = 197)]
        public string TbStockunidadef { get; set; }

        //numeric
        [Required]
        [Column("codcmb", TypeName = "numeric", Order = 198)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbStockcodcmb { get; set; }

        //bit
        [Required]
        [Column("cancpos", TypeName = "bit", Order = 199)]
        public bool TbStockcancpos { get; set; }

        //datetime
        [Required]
        [Column("datanovpv", TypeName = "datetime", Order = 200)]
        public DateTime TbStockdatanovpv { get; set; }

        //varchar 5
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("horanovpv", TypeName = "char", Order = 0)]
        public string TbStockhoranovpv { get; set; }

        //varchar 3
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("tkhclass", TypeName = "char", Order = 201)]
        public string TbStocktkhclass { get; set; }

        //bit
        [Required]
        [Column("stocktch", TypeName = "bit", Order = 202)]
        public bool TbStockstocktch { get; set; }

        //varchar 55
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("u_strt", TypeName = "char", Order = 203)]
        public string TbStockustrt { get; set; }

        //bit
        [Required]
        [Column("mod", TypeName = "bit", Order = 204)]
        public bool TbStockmod { get; set; }

        //varchar 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("restctprep", TypeName = "char", Order = 205)]
        public string TbStockrestctprep { get; set; }

        //varchar 60
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("idudesign", TypeName = "char", Order = 206)]
        public string TbStockidudesign { get; set; }

        //bit
        [Required]
        [Column("notimpcp", TypeName = "bit", Order = 207)]
        public bool TbStocknotimpcp { get; set; }

        //bit
        [Required]
        [Column("impfuelpos", TypeName = "bit", Order = 208)]
        public bool TbStockimpfuelpos { get; set; }

        //bit
        [Required]
        [Column("amostra", TypeName = "bit", Order = 209)]
        public bool TbStockamostra { get; set; }

        //bit
        [Required]
        [Column("sujinv", TypeName = "bit", Order = 210)]
        public bool TbStocksujinv { get; set; }

        //char 20
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo stamp nao pode ter mais que 25 caracteres")]
        [Column("orcrefext", TypeName = "char", Order = 211)]
        public string TbStockorcrefext { get; set; }

        public ICollection<TbStock> TbStocks { get; set; } 
    }
}
