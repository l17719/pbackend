using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ConnectorService.Model.PHCModel
{
    [Table("cl")]
    public class TbPClientes
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de stamp nao pode ser nulo")]
        [MaxLength(25, ErrorMessage = "O campo de stamp nao pode ter mais que 25 caracteres")]
        [Column("clstamp", TypeName = "varchar", Order = 0)]
        public string TbClStamp { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de nome nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo de nome nao pode ter mais que 25 caracteres")]
        [Column("nome", TypeName = "varchar", Order = 1)]
        public string TbClNome { get; set; }

        [Key]
        [Column("no", TypeName = "numeric", Order = 2)]
        public decimal TbClNo { get; set; }

        [Key]
        [Column("estab", TypeName = "numeric", Order = 3)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClEstab { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo para conter o nome do vendedor nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo para conter o nome do vendedor nao pode ter mais que 20 caracteres")]
        [Column("vendnm", TypeName = "varchar", Order = 4)]
        public string TbClNomeVendedor { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o numero de contribuinte nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo conter o numero de contribuinte nao pode ter mais que 20 caracteres")]
        [Column("ncont", TypeName = "varchar", Order = 5)]
        public string TbClNumContribuinte { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o numero de contribuinte nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo conter o numero de contribuinte nao pode ter mais que 55 caracteres")]
        [Column("nome2", TypeName = "varchar", Order = 6)]
        public string TbClNomeD { get; set; }


        [Required(ErrorMessage = "O campo saldo nao pode ser vazio")]
        [Column("saldo", TypeName = "numeric", Order = 7)]
        [DisplayFormat(NullDisplayText = "Sem saldo registado", ApplyFormatInEditMode = true)]
        public decimal TbClSaldo { get; set; }

        [Required(ErrorMessage = "O campo saldo em euros nao pode ser vazio")]
        [Column("esaldo", TypeName = "numeric", Order = 8)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClEsaldo { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor da moeda nao pode ser nulo")]
        [MaxLength(11, ErrorMessage = "O campo conter o valor da moeda nao pode ter mais que 11 caracteres")]
        [Column("moeda", TypeName = "varchar", Order = 9)]
        public string TbClMoeda { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o numero de fax nao pode ser nulo")]
        [MaxLength(60, ErrorMessage = "O campo conter  o numero de fax nao pode ter mais que 60 caracteres")]
        [Column("fax", TypeName = "varchar", Order = 10)]
        public string TbClfax { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o numero de telefone nao pode ser nulo")]
        [MaxLength(60, ErrorMessage = "O campo conter  o numero de telefone nao pode ter mais que 60 caracteres")]
        [Column("telefone", TypeName = "varchar", Order = 11)]
        public string TbClTelefone { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor do contacto nao pode ser nulo")]
        [MaxLength(30, ErrorMessage = "O campo conter  o valor do contacto nao pode ter mais que 30 caracteres")]
        [Column("contacto", TypeName = "varchar", Order = 12)]
        public string TbClContacto { get; set; }

        [Required(ErrorMessage = "O campo para conter facturacao acumulada nao pode ser vazio")]
        [Column("acmfact", TypeName = "numeric", Order = 13)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClFactAcumulada { get; set; }

        [Required(ErrorMessage = "O campo para conter facturacao acumulada em euros nao pode ser vazio")]
        [Column("eacmfact", TypeName = "numeric", Order = 14)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClFactAcumuladaEuros { get; set; }

        [Required(ErrorMessage = "O campo para conter rentabilidade acumulada nao pode ser vazio")]
        [Column("rentval", TypeName = "numeric", Order = 15)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClRentAcumulada { get; set; }

        [Required(ErrorMessage = "O campo para conter rentabilidade acumulada em euros nao pode ser vazio")]
        [Column("erentval", TypeName = "numeric", Order = 16)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClRentAcumuladaEuros { get; set; }

        [Required]
        [Column("eem", TypeName = "bit", Order = 17)]
        public bool TbClEcontacto { get; set; }

        [Required(ErrorMessage = "O campo para conter o numero do cliente nao pode ser vazio")]
        [Column("emno", TypeName = "numeric", Order = 18)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClNumeroCliente { get; set; }

        [Required(ErrorMessage = "O campo para designar se e entidade nao pode ser nulo")]
        [Column("eag", TypeName = "bit", Order = 19)]
        public bool TbClEentidade { get; set; }


        [Required(ErrorMessage = "O campo para conter numero entidade nao pode ser vazio")]
        [Column("agno", TypeName = "numeric", Order = 20)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClNumeroEntidade { get; set; }

        [Required]
        [Column("eid", TypeName = "bit", Order = 21)]
        public bool TbClEid { get; set; }

        [Required(ErrorMessage = "O campo para conter numero paciente nao pode ser vazio")]
        [Column("idno", TypeName = "numeric", Order = 22)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClNumeroPaciente { get; set; }

        [Required]
        [Column("efl", TypeName = "bit", Order = 23)]
        public bool TbClEFornecedor { get; set; }

        [Required(ErrorMessage = "O campo para conter numero fornecdor nao pode ser vazio")]
        [Column("flno", TypeName = "numeric", Order = 24)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClNumeroFornecedor { get; set; }

        [Required(ErrorMessage = "O campo para conter numero Estabelecimento nao pode ser vazio")]
        [Column("flestab", TypeName = "numeric", Order = 25)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClNumEstabelecimento { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor da morada nao pode ser nulo")]
        [MaxLength(55, ErrorMessage = "O campo conter  o valor da morada nao pode ter mais que 55 caracteres")]
        [Column("morada", TypeName = "varchar", Order = 26)]
        public string TbClMorada { get; set; }


        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor da localidade nao pode ser nulo")]
        [MaxLength(43, ErrorMessage = "O campo conter  o valor da localidade nao pode ter mais que 43 caracteres")]
        [Column("local", TypeName = "varchar", Order = 27)]
        public string TbClLocalidade { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor do codigo postal nao pode ser nulo")]
        [MaxLength(45, ErrorMessage = "O campo conter o valor do codigo postal nao pode ter mais que 45 caracteres")]
        [Column("codpost", TypeName = "varchar", Order = 28)]
        public string TbClCodigoPostal { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor da zona nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo conter  o valor da zona nao pode ter mais que 20 caracteres")]
        [Column("zona", TypeName = "varchar", Order = 29)]
        public string TbClZona { get; set; }


        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor do tipo de cliente nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo conter o valor do tipo de cliente nao pode ter mais que 20 caracteres")]
        [Column("tipo", TypeName = "varchar", Order = 30)]
        public string TbClTipoCliente { get; set; }

        [Required(ErrorMessage = "O campo para conter o valor de desconto nao pode ser vazio")]
        [Column("desconto", TypeName = "numeric", Order = 31)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClValorDesconto { get; set; }


        [Required(ErrorMessage = "O campo para conter o numero de vendedor nao pode ser vazio")]
        [Column("vendedor", TypeName = "numeric", Order = 32)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClNumeroVendedor { get; set; }

        [Required(ErrorMessage = "O campo para conter o valor de vencimento nao pode ser vazio")]
        [Column("vencimento", TypeName = "numeric", Order = 33)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClVencimento { get; set; }

        [Required(ErrorMessage = "O campo para conter o valor de plafond nao pode ser vazio")]
        [Column("plafond", TypeName = "numeric", Order = 34)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClPlafond { get; set; }

        [Required(ErrorMessage = "O campo para conter o valor de credito de plafond nao pode ser vazio")]
        [Column("eplafond", TypeName = "numeric", Order = 35)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClPlafondCredito { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor das observacoes do cliente nao pode ser nulo")]
        [MaxLength(240, ErrorMessage = "O campo conter o valor das observacoes de cliente nao pode ter mais que 240 caracteres")]
        [Column("obs", TypeName = "varchar", Order = 36)]
        public string TbClObs { get; set; }


        [Required(ErrorMessage = "O campo para conter o valor de credito de tabela de precos nao pode ser vazio")]
        [Column("preco", TypeName = "numeric", Order = 37)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClTabelaPreco { get; set; }

        [Required(ErrorMessage = "O campo para conter o valor de pais nao pode ser vazio")]
        [Column("pais", TypeName = "numeric", Order = 38)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClNumPais { get; set; }

        [Required]
        [Column("particular", TypeName = "bit", Order = 39)]
        public bool TbClEParticular { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor do numb cliente nao pode ser nulo")]
        [MaxLength(20, ErrorMessage = "O campo conter o valor do numb de cliente nao pode ter mais que 20 caracteres")]
        [Column("bino", TypeName = "varchar", Order = 40)]
        public string TbClNumBiCliente { get; set; }

        [Required]
        [Column("bidata", TypeName = "datetime", Order = 41)]
        public DateTime TbClDataBiCliente { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor da localidade do cliente nao pode ser nulo")]
        [MaxLength(25,
            ErrorMessage = "O campo conter o valor da localidade cliente nao pode ter mais que 25 caracteres")]
        [Column("bilocal", TypeName = "varchar", Order = 42)]
        public string TbClLocalidadeBiCliente { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor da naturalidade do cliente nao pode ser nulo")]
        [MaxLength(17,
            ErrorMessage = "O campo conter o valor da naturalidade do cliente nao pode ter mais que 17 caracteres")]
        [Column("naturalid", TypeName = "varchar", Order = 43)]
        public string TbClNaturalidadeCliente { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor do pass do cliente nao pode ser nulo")]
        [MaxLength(15,
            ErrorMessage = "O campo conter o valor do pass do cliente nao pode ter mais que 15 caracteres")]
        [Column("passaporte", TypeName = "varchar", Order = 44)]
        public string TbClNumPassaporteCliente { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor de conta do cliente nao pode ser nulo")]
        [MaxLength(15,
            ErrorMessage = "O campo conter o valor de conta do cliente nao pode ter mais que 15 caracteres")]
        [Column("conta", TypeName = "varchar", Order = 45)]
        public string TbClNumeroContaContabilidade { get; set; }

        [Required]
        [Column("nascimento", TypeName = "datetime", Order = 46)]
        public DateTime TbClDataNascimento { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor de tipo pagamento do cliente nao pode ser nulo")]
        [MaxLength(28,
            ErrorMessage = "O campo conter o valor de tipo pagamento do cliente nao pode ter mais que 28 caracteres")]
        [Column("pagamento", TypeName = "varchar", Order = 47)]
        public string TbClPagamento { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor de tipo cobranca do cliente nao pode ser nulo")]
        [MaxLength(22,
            ErrorMessage = "O campo conter o valor de tipo cobranca do cliente nao pode ter mais que 22 caracteres")]
        [Column("cobranca", TypeName = "varchar", Order = 48)]
        public string TbClCobranca { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor de tipo n do cliente nao pode ser nulo")]
        [MaxLength(28,
            ErrorMessage = "O campo conter o valor de tipo n do cliente nao pode ter mais que 28 caracteres")]
        [Column("nib", TypeName = "varchar", Order = 49)]
        public string TbClNibCliente { get; set; }

        [Required(ErrorMessage = "O campo para conter o desconto financeiro nao pode ser vazio")]
        [Column("descpp", TypeName = "numeric", Order = 50)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClDescFinanceiro { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor da imagem cliente nao pode ser nulo")]
        [MaxLength(120,
            ErrorMessage = "O campo conter o valor da imagem do cliente nao pode ter mais que 120 caracteres")]
        [Column("imagem", TypeName = "varchar", Order = 51)]
        public string TbClImagem { get; set; }

        [Required(ErrorMessage = "O campo para conter o atraso medio nao pode ser vazio")]
        [Column("odatraso", TypeName = "numeric", Order = 52)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbAtrasoMedio { get; set; }

        [Required(ErrorMessage = "O campo para conter o valor da tabela de iva nao pode ser vazio")]
        [Column("tabiva", TypeName = "numeric", Order = 53)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClValorIva { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o primeiro valor do contacto telefonico nao pode ser nulo")]
        [MaxLength(60,
            ErrorMessage =
                "O campo para conter o primeiro valor do contacto telefonico nao pode ter mais que 60 caracteres")]
        [Column("c1tele", TypeName = "varchar", Order = 54)]
        public string TbClPContactoTelefonico { get; set; }

        [Required(AllowEmptyStrings = false,
           ErrorMessage = "O campo para conter o primeiro valor do contacto fax nao pode ser nulo")]
        [MaxLength(60,
            ErrorMessage =
                "O campo para conter o primeiro valor do contacto fax nao pode ter mais que 60 caracteres")]
        [Column("c1fax", TypeName = "varchar", Order = 55)]
        public string TbClPContactoFax { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o primeiro valor da funcao do cliente nao pode ser nulo")]
        [MaxLength(15,
            ErrorMessage =
                "O campo para conter o primeiro valor da funcao do cliente nao pode ter mais que 15 caracteres")]
        [Column("c1func", TypeName = "varchar", Order = 56)]
        public string TbClPFuncaoContacto { get; set; }


        //
        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o segundo valor do contacto telefonico nao pode ser nulo")]
        [MaxLength(60,
            ErrorMessage =
                "O campo para conter o valor do segundo contacto telefonico nao pode ter mais que 60 caracteres")]
        [Column("c2tele", TypeName = "varchar", Order = 57)]
        public string TbClSContactoTelefonico { get; set; }

        [Required(AllowEmptyStrings = false,
           ErrorMessage = "O campo para conter o segundo valor do contacto fax nao pode ser nulo")]
        [MaxLength(60,
            ErrorMessage =
                "O campo para conter o valor do segundo contacto fax nao pode ter mais que 60 caracteres")]
        [Column("c2fax", TypeName = "varchar", Order = 58)]
        public string TbClSContactoFax { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o segundo valor da funcao do cliente nao pode ser nulo")]
        [MaxLength(15,
            ErrorMessage =
                "O campo para conter o segundo valor da funcao do cliente nao pode ter mais que 15 caracteres")]
        [Column("c2func", TypeName = "varchar", Order = 59)]
        public string TbClFuncaoSContacto { get; set; }
        


        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o segundo valor de contacto do cliente nao pode ser nulo")]
        [MaxLength(30,
            ErrorMessage =
                "O campo para conter o segundo valor de contacto do cliente nao pode ter mais que 30 caracteres")]
        [Column("c2tacto", TypeName = "varchar", Order = 60)]
        public string TbClNomeSContacto { get; set; }
        //

        //
        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o terceiro valor do contacto telefonico nao pode ser nulo")]
        [MaxLength(60,
            ErrorMessage =
                "O campo para conter o valor do terceiro contacto telefonico nao pode ter mais que 60 caracteres")]
        [Column("c3tele", TypeName = "varchar", Order = 61)]
        public string TbClTContactoTelefonico { get; set; }

        [Required(AllowEmptyStrings = false,
           ErrorMessage = "O campo para conter o terceiro valor do contacto fax nao pode ser nulo")]
        [MaxLength(60,
            ErrorMessage =
                "O campo para conter o valor do terceiro contacto fax nao pode ter mais que 60 caracteres")]
        [Column("c3fax", TypeName = "varchar", Order = 62)]
        public string TbClTContactoFax { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o terceiro valor da funcao do cliente nao pode ser nulo")]
        [MaxLength(15,
            ErrorMessage =
                "O campo para conter o terceiro valor da funcao do cliente nao pode ter mais que 15 caracteres")]
        [Column("c3func", TypeName = "varchar", Order = 63)]
        public string TbClFuncaoTContacto { get; set; }



        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o terceiro valor de contacto do cliente nao pode ser nulo")]
        [MaxLength(30,
            ErrorMessage =
                "O campo para conter o terceiro valor de contacto do cliente nao pode ter mais que 30 caracteres")]
        [Column("c3tacto", TypeName = "varchar", Order = 64)]
        public string TbClNomeTContacto { get; set; }
        //

        [Required]
        [Column("dqtt", TypeName = "bit", Order = 65)]
        public bool TbClDescontoQuantidade { get; set; }

        [Required]
        [Column("clivd", TypeName = "bit", Order = 66)]
        public bool TbClienteVendaDinheiro { get; set; }


        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor de descarga nao pode ser nulo")]
        [MaxLength(60,
            ErrorMessage =
                "O campo para conter o  valor de descarga nao pode ter mais que 60 caracteres")]
        [Column("descarga", TypeName = "varchar", Order = 67)]
        public string TbClDescarga { get; set; }


        [Required]
        [Column("nocredit", TypeName = "bit", Order = 68)]
        public bool TbClienteFacturacaoCancelada { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor de segmento nao pode ser nulo")]
        [MaxLength(25,
            ErrorMessage =
                "O campo para conter o valor de segmento nao pode ter mais que 25 caracteres")]
        [Column("segmento", TypeName = "varchar", Order = 69)]
        public string TbClSegmentoMercado { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor de email cliente nao pode ser nulo")]
        [MaxLength(45,
            ErrorMessage =
                "O campo para conter o valor de email cliente nao pode ter mais que 45 caracteres")]
        [Column("email", TypeName = "varchar", Order = 70)]
        public string TbClEmailCliente { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor de referencia interna nao pode ser nulo")]
        [MaxLength(20,
            ErrorMessage =
                "O campo para conter o valor de referencia interna nao pode ter mais que 20 caracteres")]
        [Column("fref", TypeName = "varchar", Order = 71)]
        public string TbClRefinterna { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor de centro de custos nao pode ser nulo")]
        [MaxLength(20,
            ErrorMessage =
                "O campo para conter o  valor de centro de custos nao pode ter mais que 20 caracteres")]
        [Column("ccusto", TypeName = "varchar", Order = 72)]
        public string TbClCentroCustos { get; set; }

        [Required(AllowEmptyStrings = false,
           ErrorMessage = "O campo para conter o valor do numero de custos nao pode ser nulo")]
        [MaxLength(20,
            ErrorMessage =
                "O campo para conter o  valor do numero de custos nao pode ter mais que 20 caracteres")]
        [Column("ncusto", TypeName = "varchar", Order = 73)]
        public string TbClNumeroCustos { get; set; }

        [Required]
        [Column("naood", TypeName = "bit", Order = 74)]
        public bool TbClLancarPrevisoes { get; set; }

        [Required]
        [Column("naomail", TypeName = "bit", Order = 75)]
        public bool TbClEnviarMailingContasCorrentes { get; set; }

        [Required(AllowEmptyStrings = false,
         ErrorMessage = "O campo para conter o valor do titulos de divida em contabilidade nao pode ser nulo")]
        [MaxLength(15,
            ErrorMessage =
                "O campo para conter o  valor de titulos de divida em contabilidade nao pode ter mais que 15 caracteres")]
        [Column("contalet", TypeName = "varchar", Order = 76)]
        public string TbClTitDividaContabilidade { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter o valor do titulos de divida descontada em contabilidade nao pode ser nulo")]
        [MaxLength(15,
            ErrorMessage =
                "O campo para conter o  valor de titulos de divida descontada em contabilidade nao pode ter mais que 15 caracteres")]
        [Column("contaletdes", TypeName = "varchar", Order = 77)]
        public string TbClTitDividaDescContabilidade { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter o valor do titulos de divida de envio em contabilidade nao pode ser nulo")]
        [MaxLength(15,
            ErrorMessage =
                "O campo para conter o  valor de titulos de divida de envio em contabilidade nao pode ter mais que 15 caracteres")]
        [Column("contaletsac", TypeName = "varchar", Order = 78)]
        public string TbClTitDividaEnvioContabilidade { get; set; }


        [Required(ErrorMessage = "O campo para conter o valor do limite de credito nao pode ser vazio")]
        [Column("alimite", TypeName = "numeric", Order = 79)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClLimiteCredito { get; set; }

        [Required(ErrorMessage = "O campo para conter o valor do tipo de desconto nao pode ser vazio")]
        [Column("dqttval", TypeName = "numeric", Order = 80)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClTipoDesconto { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor de tipo de clientes descontos nao pode ser nulo")]
        [MaxLength(20,
            ErrorMessage =
                "O campo para conter o  valor de tipo de clientes descontos nao pode ter mais que 20 caracteres")]
        [Column("tipodesc", TypeName = "varchar", Order = 81)]
        public string TbClTipoClientesDesc { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o numero telemovel nao pode ser nulo")]
        [MaxLength(45,
            ErrorMessage =
                "O campo para conter o  valor do numero telemovel nao pode ter mais que 45 caracteres")]
        [Column("tlmvl", TypeName = "varchar", Order = 82)]
        public string TbClTelemovelCliente { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor do cobrador nao pode ser nulo")]
        [MaxLength(20,
            ErrorMessage =
                "O campo para conter o valor do cobrador nao pode ter mais que 20 caracteres")]
        [Column("cobrador", TypeName = "varchar", Order = 83)]
        public string TbClClienteCobrador { get; set; }

        [Required(AllowEmptyStrings = false,
          ErrorMessage = "O campo para conter o valor da rota nao pode ser nulo")]
        [MaxLength(20,
            ErrorMessage =
                "O campo para conter o valor da rota nao pode ter mais que 20 caracteres")]
        [Column("rota", TypeName = "varchar", Order = 84)]
        public string TbClClienteRota { get; set; }

        [Required(AllowEmptyStrings = false,
          ErrorMessage = "O campo para conter o valor Conta Adiantamentos incerto nao pode ser nulo")]
        [MaxLength(15,
            ErrorMessage =
                "O campo para conter o valor da Conta Adiantamentos incerto pode ter mais que 15 caracteres")]
        [Column("contaainc", TypeName = "varchar", Order = 85)]
        public string TbClContaAdiantamentoIn { get; set; }

        [Required(AllowEmptyStrings = false,
         ErrorMessage = "O campo para conter o valor Conta Adiantamentos certo nao pode ser nulo")]
        [MaxLength(15,
            ErrorMessage =
                "O campo para conter o valor da Conta Adiantamentos certo pode ter mais que 15 caracteres")]
        [Column("contaacer", TypeName = "varchar", Order = 86)]
        public string TbClContaAdiantamentoCer { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter o valor EAN certo nao pode ser nulo")]
        [MaxLength(35,
            ErrorMessage =
                "O campo para conter o valor da EAN pode ter mais que 35 caracteres")]
        [Column("eancl", TypeName = "varchar", Order = 87)]
        public string TbClEan { get; set; }

        [Required]
        [Column("ediexp", TypeName = "bit", Order = 88)]
        public bool TbClExportaFacturasEdi { get; set; }


        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor url  nao pode ser nulo")]
        [MaxLength(100,
            ErrorMessage =
                "O campo para conter o valor da url pode ter mais que 100 caracteres")]
        [Column("url", TypeName = "varchar", Order = 89)]
        public string TbClUrl { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor tstamp  nao pode ser nulo")]
        [MaxLength(25,
            ErrorMessage =
                "O campo para conter o valor da tstamp pode ter mais que 25 caracteres")]
        [Column("tpstamp", TypeName = "char", Order = 89)]
        public string TbClTpStamp { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o valor das condicoes pagamento nao pode ser nulo")]
        [MaxLength(55,
            ErrorMessage =
                "O campo para conter o valor das condicoes pagamento pode ter mais que 55 caracteres")]
        [Column("tpdesc", TypeName = "varchar", Order = 90)]
        public string TbClCondicoesPagamento { get; set; }

        [Required(AllowEmptyStrings = false,
           ErrorMessage = "O campo para conter o valor das iniciais do pais nao pode ser nulo")]
        [MaxLength(2,
            ErrorMessage =
                "O campo para conter o valor das iniciais do pais nao pode ter mais que 2 caracteres")]
        [Column("pncont", TypeName = "varchar", Order = 91)]
        public string TbClInitPais { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o contacto para efectuar cobrancas nao pode ser nulo")]
        [MaxLength(60,
            ErrorMessage =
                "O campo para conter o contacto para efectuar cobrancas nao pode ter mais que 60 caracteres")]
        [Column("cobtele", TypeName = "varchar", Order = 92)]
        public string TbClTelefoneCobranca { get; set; }

        [Required(AllowEmptyStrings = false,
           ErrorMessage = "O campo para conter o fax para efectuar cobrancas nao pode ser nulo")]
        [MaxLength(60,
            ErrorMessage =
                "O campo para conter o fax para efectuar cobrancas nao pode ter mais que 60 caracteres")]
        [Column("cobfax", TypeName = "varchar", Order = 93)]
        public string TbClFaxCobranca { get; set; }

        [Required(AllowEmptyStrings = false,
           ErrorMessage = "O campo para conter a funcao para efectuar cobrancas nao pode ser nulo")]
        [MaxLength(15,
            ErrorMessage =
                "O campo para conter a funcao para efectuar cobrancas nao pode ter mais que 15 caracteres")]
        [Column("cobfunc", TypeName = "varchar", Order = 94)]
        public string TbClFuncaoCobranca { get; set; }

        [Required(AllowEmptyStrings = false,
         ErrorMessage = "O campo para conter o nome para efectuar cobrancas nao pode ser nulo")]
        [MaxLength(45,
            ErrorMessage =
                "O campo para conter nome para efectuar cobrancas nao pode ter mais que 45 caracteres")]
        [Column("cobtacto", TypeName = "varchar", Order = 93)]
        public string TbClNomeCobranca { get; set; }

        [Required(AllowEmptyStrings = false,
         ErrorMessage = "O campo para conter o local t nao pode ser nulo")]
        [MaxLength(50,
            ErrorMessage =
                "O campo para conter local t nao pode ter mais que 50 caracteres")]
        [Column("ollocal", TypeName = "varchar", Order = 94)]
        public string TbClLocalCobranca { get; set; }

        [Required(ErrorMessage = "O campo para conter o num interno cb nao pode ser vazio")]
        [Column("contado", TypeName = "numeric", Order = 95)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClNumInternoContaBancaria { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o codigo do pais nao pode ser nulo")]
        [MaxLength(2,
            ErrorMessage =
                "O campo para conter o codigo do pais nao pode ter mais que 2 caracteres")]
        [Column("pscm", TypeName = "varchar", Order = 96)]
        public string TbClCodPais { get; set; }

        [Required(ErrorMessage = "O campo para conter o codigo da regiao nao pode ser vazio")]
        [Column("zncm", TypeName = "numeric", Order = 97)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClCodigoRegiao { get; set; }

        [Required(ErrorMessage = "O campo para conter o codigo da modo transporte nao pode ser vazio")]
        [Column("excm", TypeName = "numeric", Order = 98)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClCodigoTransporte { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o porto/aeroporto do pais nao pode ser nulo")]
        [MaxLength(4,
            ErrorMessage =
                "O campo para conter local o codigo do porto/aeroporto nao pode ter mais que 4 caracteres")]
        [Column("ptcm", TypeName = "varchar", Order = 99)]
        public string TbClCodigoPortoAeroP { get; set; }

        [Required(AllowEmptyStrings = false,
           ErrorMessage = "O campo para conter a condicao de entrega nao pode ser nulo")]
        [MaxLength(3,
            ErrorMessage =
                "O campo para conter  condicao de entrega nao pode ter mais que 4 caracteres")]
        [Column("encm", TypeName = "varchar", Order = 100)]
        public string TbClCodigoCondEntrega { get; set; }

        [Required(ErrorMessage = "O campo para conter a natureza de transaccao nao pode ser vazio")]
        [Column("ntcm", TypeName = "numeric", Order = 101)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClCodigoTrans { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter a descricao do pais nao pode ser nulo")]
        [MaxLength(70,
            ErrorMessage =
                "O campo para conter a descricao do pais nao pode ter mais que 70 caracteres")]
        [Column("pscmdesc", TypeName = "varchar", Order = 102)]
        public string TbClDescPais { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter a descricao da regiao nao pode ser nulo")]
        [MaxLength(70,
            ErrorMessage =
                "O campo para conter a descricao da regiao nao pode ter mais que 70 caracteres")]
        [Column("znregiao", TypeName = "varchar", Order = 103)]
        public string TbClDescRegiao { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter a descricao da modo transporte nao pode ser nulo")]
        [MaxLength(70,
            ErrorMessage =
                "O campo para conter a descricao da modo transporte nao pode ter mais que 70 caracteres")]
        [Column("excmdesc", TypeName = "varchar", Order = 104)]
        public string TbClDescTransporte { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter a descricao do porto/aeroporto nao pode ser nulo")]
        [MaxLength(70,
            ErrorMessage =
                "O campo para conter a descricao do porto/aeroporto nao pode ter mais que 70 caracteres")]
        [Column("ptcmdesc", TypeName = "varchar", Order = 105)]
        public string TbClDescPortoAero { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter a descricao da condicao de entrega nao pode ser nulo")]
        [MaxLength(70,
            ErrorMessage =
                "O campo para conter a descricao da condicao de entrega nao pode ter mais que 70 caracteres")]
        [Column("encmdesc", TypeName = "varchar", Order = 106)]
        public string TbClDescEntrega { get; set; }

        [Required]
        [Column("usaintra", Order = 107)]
        public bool TbClMapasIntra { get; set; }

        [Required]
        [Column("cobnao", Order = 108)]
        public bool TbClDificuldadeCobranca { get; set; }


        [Required(ErrorMessage = "O campo para conter saldo em titulos divida nao pode ser vazio")]
        [Column("saldlet", TypeName = "numeric", Order = 109)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClSaldoTitulosDiv { get; set; }

        [Required(ErrorMessage = "O campo para conter saldo em titulos divida euro nao pode ser vazio")]
        [Column("esaldlet", TypeName = "numeric", Order = 110)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClSaldoTitulosDivEuro { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter a loja nao pode ser nulo")]
        [MaxLength(20,
            ErrorMessage =
                "O campo para conter a loja nao pode ter mais que 20 caracteres")]
        [Column("site", TypeName = "varchar", Order = 111)]
        public string TbClLoja { get; set; }

        [Required(AllowEmptyStrings = false,
           ErrorMessage = "O campo para conter o endereco electronico para receber documentos nao pode ser nulo")]
        [MaxLength(45,
            ErrorMessage =
                "O campo para conter o endereco electronico para receber documentos nao pode ter mais que 45 caracteres")]
        [Column("bizzaddress", TypeName = "varchar", Order = 112)]
        public string TbClBiznessAddress { get; set; }

        [Required(ErrorMessage = "O campo para conter metodo para enviar/receber documentacao electronica nao pode ser vazio")]
        [Column("bizzproto", TypeName = "numeric", Order = 113)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClTransElectronica { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o centro assistencia nao pode ser nulo")]
        [MaxLength(20,
            ErrorMessage =
                "O campo para conter o centro assistencia nao pode ter mais que 20 caracteres")]
        [Column("cass", TypeName = "varchar", Order = 114)]
        public string TbClCentroAssistencia { get; set; }


        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter a classificacao documentos facturacao nao pode ser nulo")]
        [MaxLength(30,
            ErrorMessage =
                "O campo para conter a classificacao documentos facturacao nao pode ter mais que 30 caracteres")]
        [Column("classe", TypeName = "varchar", Order = 115)]
        public string TbClClassificaDocsFact { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o idioma nao pode ser nulo")]
        [MaxLength(20,
            ErrorMessage =
                "O campo para conter o idioma nao pode ter mais que 20 caracteres")]
        [Column("lang", TypeName = "char", Order = 116)]
        public string TbClIdioma { get; set; }

        [Required]
        [Column("iectisento", TypeName = "bit", Order = 117)]
        public bool TbClIsentoIec { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o numero iec nao pode ser nulo")]
        [MaxLength(20,
            ErrorMessage =
                "O campo para conter o numero iec nao pode ter mais que 20 caracteres")]
        [Column("niec", TypeName = "varchar", Order = 118)]
        public string TbClNiec { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o nome do grupo de acesso nao pode ser nulo")]
        [MaxLength(60,
            ErrorMessage =
                "O campo para conter o nome do grupo de acesso nao pode ter mais que 60 caracteres")]
        [Column("gaenome", TypeName = "char", Order = 118)]
        public string TbClNomeGrupoAcesso { get; set; }

        [Required(AllowEmptyStrings = false,
          ErrorMessage = "O campo para conter o stamp do grupo de acesso nao pode ser nulo")]
        [MaxLength(25,
            ErrorMessage =
                "O campo para conter o stamp de acesso nao pode ter mais que 25 caracteres")]
        [Column("gaestamp", TypeName = "char", Order = 119)]
        public string TbClStampGrupoAcesso { get; set; }

        [Required]
        [Column("clinica", TypeName = "bit", Order = 120)]
        public bool TbClClienteClinica { get; set; }

        [Required]
        [Column("ftndias", TypeName = "bit", Order = 121)]
        public bool TbClFacturaEscreveDiasFacturados { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o periodo de marcacoes pode ser nulo")]
        [MaxLength(40,
            ErrorMessage =
                "O campo para conter  o periodo de marcacoes nao pode ter mais que 40 caracteres")]
        [Column("txftndias", TypeName = "varchar", Order = 122)]
        public string TbClPeriodoMarcacoes { get; set; }


        [Required]
        [Column("ftdiasmr", TypeName = "bit", Order = 121)]
        public bool TbClDataMarcacoesFactura { get; set; }

        [Required(AllowEmptyStrings = false,
           ErrorMessage = "O campo para conter o periodo de marcacoes pode ser nulo")]
        [MaxLength(40,
            ErrorMessage =
                "O campo para conter  o periodo de marcacoes nao pode ter mais que 40 caracteres")]
        [Column("txftdias", TypeName = "varchar", Order = 123)]
        public string TbClFacturaPeriodoMarcacoes { get; set; }


        [Required]
        [Column("ftdatasmr", TypeName = "bit", Order = 124)]
        public bool TbClftdatasmr { get; set; }

        [Required(AllowEmptyStrings = false,
         ErrorMessage = "O campo para conter o txftdata pode ser nulo")]
        [MaxLength(40,
            ErrorMessage =
                "O campo para conter txftdata nao pode ter mais que 40 caracteres")]
        [Column("txftdata", TypeName = "varchar", Order = 125)]
        public string TbCltxftdata { get; set; }

        [Required]
        [Column("ftnid", TypeName = "bit", Order = 126)]
        public bool TbClftnid { get; set; }

        [Required(AllowEmptyStrings = false,
         ErrorMessage = "O campo para txftnid pode ser nulo")]
        [MaxLength(40,
            ErrorMessage =
                "O campo para conter txftnid nao pode ter mais que 40 caracteres")]
        [Column("txftnid", TypeName = "varchar", Order = 127)]
        public string TbCltxftnid { get; set; }

        [Required]
        [Column("ftidnome", TypeName = "bit", Order = 128)]
        public bool TbClftidnome { get; set; }

        [Required(AllowEmptyStrings = false,
         ErrorMessage = "O campo para txftnid pode ser nulo")]
        [MaxLength(40,
            ErrorMessage =
                "O campo para conter txftnid nao pode ter mais que 40 caracteres")]
        [Column("txftidnome", TypeName = "varchar", Order = 129)]
        public string TbCltxftidnome { get; set; }

        //
        [Required]
        [Column("ftidcontacto", TypeName = "bit", Order = 130)]
        public bool TbClftidcontacto { get; set; }

        [Required(AllowEmptyStrings = false,
         ErrorMessage = "O campo para txftidcontacto pode ser nulo")]
        [MaxLength(40,
            ErrorMessage =
                "O campo para conter txftidcontacto nao pode ter mais que 40 caracteres")]
        [Column("txftidcontacto", TypeName = "varchar", Order = 131)]
        public string TbCltxftidcontacto { get; set; }


        [Required]
        [Column("ftidnac", TypeName = "bit", Order = 132)]
        public bool TbClftidnac { get; set; }

        [Required(AllowEmptyStrings = false,
         ErrorMessage = "O campo para txftidnac pode ser nulo")]
        [MaxLength(40,
            ErrorMessage =
                "O campo para conter txftidnac nao pode ter mais que 40 caracteres")]
        [Column("txftidnac", TypeName = "varchar", Order = 133)]
        public string TbCltxftidnac { get; set; }


        [Required]
        [Column("ftidcont", TypeName = "bit", Order = 134)]
        public bool TbClftidcont { get; set; }

        [Required(AllowEmptyStrings = false,
         ErrorMessage = "O campo para ftidcont pode ser nulo")]
        [MaxLength(40,
            ErrorMessage =
                "O campo para conter txftidcont nao pode ter mais que 40 caracteres")]
        [Column("txftidcont", TypeName = "varchar", Order = 135)]
        public string TbCltxftidcont { get; set; }

        [Required]
        [Column("ftidutente", TypeName = "bit", Order = 136)]
        public bool TbClftidutente { get; set; }

        [Required(AllowEmptyStrings = false,
         ErrorMessage = "O campo para txftidutente pode ser nulo")]
        [MaxLength(40,
            ErrorMessage =
                "O campo para conter txftidutente nao pode ter mais que 40 caracteres")]
        [Column("txftidutente", TypeName = "varchar", Order = 137)]
        public string TbCltxftidutente { get; set; }


        [Required]
        [Column("ftidbi", TypeName = "bit", Order = 138)]
        public bool TbClftidbi { get; set; }

        [Required(AllowEmptyStrings = false,
         ErrorMessage = "O campo para txftidbi pode ser nulo")]
        [MaxLength(40,
            ErrorMessage =
                "O campo para conter txftidbi nao pode ter mais que 40 caracteres")]
        [Column("txftidbi", TypeName = "varchar", Order = 139)]
        public string TbCltxftidbi { get; set; }


        [Required]
        [Column("ftidcob", TypeName = "bit", Order = 140)]
        public bool TbClftidcob { get; set; }

        [Required(AllowEmptyStrings = false,
         ErrorMessage = "O campo para txftidbi pode ser nulo")]
        [MaxLength(40,
            ErrorMessage =
                "O campo para conter txftidbi nao pode ter mais que 40 caracteres")]
        [Column("txftidcob", TypeName = "varchar", Order = 141)]
        public string TbCltxftidcob { get; set; }

        [Required]
        [Column("ftmrtot", TypeName = "bit", Order = 142)]
        public bool TbClftmrtot { get; set; }

        [Required(AllowEmptyStrings = false,
         ErrorMessage = "O campo para ftmrtot pode ser nulo")]
        [MaxLength(40,
            ErrorMessage =
                "O campo para conter ftmrtot nao pode ter mais que 40 caracteres")]
        [Column("txftmrtot", TypeName = "varchar", Order = 143)]
        public string TbCltxftmrtot { get; set; }

        [Required]
        [Column("ftumamr", TypeName = "bit", Order = 144)]
        public bool TbClftumamr { get; set; }

        [Required]
        [Column("paramr", TypeName = "bit", Order = 145)]
        public bool TbClparamr { get; set; }

        [Required]
        [Column("filtrast", TypeName = "bit", Order = 146)]
        public bool TbClfiltrast { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter o titular conta pode ser nulo")]
        [MaxLength(40,
            ErrorMessage =
                "O campo para conter o titular conta nao pode ter mais que 40 caracteres")]
        [Column("contatit", TypeName = "varchar", Order = 147)]
        public string TbClcontatit { get; set; }

        [Required(AllowEmptyStrings = false,
           ErrorMessage = "O campo para conter o statuspda conta pode ser nulo")]
        [MaxLength(1,
            ErrorMessage =
                "O campo para conter o statuspda nao pode ter mais que 1 caracteres")]
        [Column("statuspda", TypeName = "varchar", Order = 148)]
        public string TbClstatuspda { get; set; }

        [Required]
        [Column("inactivo", TypeName = "bit", Order = 149)]
        public bool TbClinactivo { get; set; }

        [Required]
        [Column("naoencomenda", TypeName = "bit", Order = 150)]
        public bool TbClnaoencomenda { get; set; }

        [Required]
        [Column("clifactor", TypeName = "bit", Order = 151)]
        public bool TbClclifactor { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter cfact conta pode ser nulo")]
        [MaxLength(15,
            ErrorMessage =
                "O campo para conter o cfact nao pode ter mais que 15 caracteres")]
        [Column("contafac", TypeName = "varchar", Order = 152)]
        public string TbClContafac { get; set; }

        [Required]
        [Column("dfront", TypeName = "bit", Order = 153)]
        public bool TbCldfront { get; set; }

        [Required]
        [Column("dsuporte", TypeName = "bit", Order = 154)]
        public bool TbCldsuporte { get; set; }

        [Required]
        [Column("dformacao", TypeName = "bit", Order = 155)]
        public bool TbCldformacao { get; set; }

        [Required]
        [Column("dteam", TypeName = "bit", Order = 156)]
        public bool TbCldteam { get; set; }

        [Required]
        [Column("recdocdig", TypeName = "bit", Order = 157)]
        public bool TbClrecdocdig { get; set; }

        [Required(AllowEmptyStrings = false,
          ErrorMessage = "O campo para conter glncl conta pode ser nulo")]
        [MaxLength(35,
            ErrorMessage =
                "O campo para conter o glncl  nao pode ter mais que 16 caracteres")]
        [Column("glncl", TypeName = "varchar", Order = 158)]
        public string TbClglncl { get; set; }

        [Required(AllowEmptyStrings = false,
         ErrorMessage = "O campo para conter fornecedor  pode ser nulo")]
        [MaxLength(10,
            ErrorMessage =
                "O campo para conter o fornecedor  nao pode ter mais que 16 caracteres")]
        [Column("codfornecedor", TypeName = "varchar", Order = 159)]
        public string TbClcodfornecedor { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter entrega  pode ser nulo")]
        [MaxLength(10,
            ErrorMessage =
                "O campo para conter o entrega  nao pode ter mais que 16 caracteres")]
        [Column("localentrega", TypeName = "varchar", Order = 160)]
        public string TbCllocalentrega { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter observacoes conta pode ser nulo")]
        [Column("obsdoc", TypeName = "text", Order = 161)]
        public string TbClobsdoc { get; set; }

        [Required]
        [Column("ecoisento", TypeName = "bit", Order = 162)]
        public bool TbClecoisento { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter produtos  pode ser nulo")]
        [MaxLength(15,
            ErrorMessage =
                "O campo para conter produtos  nao pode ter mais que 15 caracteres")]
        [Column("tbprcod", TypeName = "varchar", Order = 163)]
        public string TbCltbprcod { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter area  pode ser nulo")]
        [MaxLength(20,
            ErrorMessage =
                "O campo para conter area  nao pode ter mais que 20 caracteres")]
        [Column("area", TypeName = "varchar", Order = 164)]
        public string TbClarea { get; set; }


        [Required]
        [Column("exporpos", TypeName = "bit", Order = 165)]
        public bool TbClexporpos { get; set; }

        [Required]
        [Column("temcred", TypeName = "bit", Order = 166)]
        public bool TbCltemcred { get; set; }

        [Required]
        [Column("temftglob", TypeName = "bit", Order = 167)]
        public bool TbCltemftglob { get; set; }

        [Required(ErrorMessage = "O campo para permitir desconto nao pode ser vazio")]
        [Column("ltyp", TypeName = "numeric", Order = 168)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClltyp { get; set; }

        [Required(ErrorMessage = "O campo para permitir percentagem desconto nao pode ser vazio")]
        [Column("lmlt", TypeName = "numeric", Order = 169)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCllmlt { get; set; }


        [Required(ErrorMessage = "O campo para permitir saldo fornecimento  nao pode ser vazio")]
        [Column("rbal", TypeName = "numeric", Order = 170)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClrbal { get; set; }

        [Required]
        [Column("addd", TypeName = "bit", Order = 171)]
        public bool TbCladdd { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter id  pode ser nulo")]
        [MaxLength(20,
            ErrorMessage =
                "O campo para conter id nao pode ter mais que 20 caracteres")]
        [Column("id", TypeName = "varchar", Order = 172)]
        public string TbClid { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter track  pode ser nulo")]
        [MaxLength(40,
            ErrorMessage =
                "O campo para conter track nao pode ter mais que 40 caracteres")]
        [Column("track", TypeName = "varchar", Order = 173)]
        public string TbCltrack { get; set; }

        [Required(ErrorMessage = "O campo para permitir tracknr nao pode ser vazio")]
        [Column("tracknr", TypeName = "numeric", Order = 174)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCltracknr { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter pi  pode ser nulo")]
        [MaxLength(4,
            ErrorMessage =
                "O campo para conter pi nao pode ter mais que 4 caracteres")]
        [Column("pin", TypeName = "varchar", Order = 175)]
        public string TbClpin { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter epi  pode ser nulo")]
        [MaxLength(4,
            ErrorMessage =
                "O campo para conter epi nao pode ter mais que 4 caracteres")]
        [Column("encrpin", TypeName = "varchar", Order = 176)]
        public string TbClencrpin { get; set; }

        [Required]
        [Column("blck", TypeName = "bit", Order = 177)]
        public bool TbClblck { get; set; }

        [Required(ErrorMessage = "O campo para permitir acc nao pode ser vazio")]
        [Column("acc", TypeName = "numeric", Order = 178)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbClacc { get; set; }

        [Required]
        [Column("repl", TypeName = "bit", Order = 179)]
        public bool TbClrepl { get; set; }

        [Required]
        [Column("odo", TypeName = "bit", Order = 180)]
        public bool TbClodo { get; set; }

        [Required]
        [Column("did", TypeName = "bit", Order = 181)]
        public bool TbCldid { get; set; }

        [Required]
        [Column("carr", TypeName = "bit", Order = 182)]
        public bool TbClcarr { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter fuels pode ser nulo")]
        [MaxLength(3,
            ErrorMessage =
                "O campo para conter fuels nao pode ter mais que 3 caracteres")]
        [Column("fuels", TypeName = "varchar", Order = 183)]
        public string TbClfuels { get; set; }


        [Required]
        [Column("cw", TypeName = "bit", Order = 184)]
        public bool TbClcw { get; set; }


        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter shop pode ser nulo")]
        [MaxLength(2,
            ErrorMessage =
                "O campo para conter shop nao pode ter mais que 2 caracteres")]
        [Column("shop", TypeName = "varchar", Order = 185)]
        public string TbClshop { get; set; }

        [Required(AllowEmptyStrings = false,
          ErrorMessage = "O campo para conter refc pode ser nulo")]
        [MaxLength(12,
            ErrorMessage =
                "O campo para conter refc nao pode ter mais que 12 caracteres")]
        [Column("refcli", TypeName = "varchar", Order = 186)]
        public string TbClrefcli { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter shop pode ser nulo")]
        [MaxLength(15,
            ErrorMessage =
                "O campo para conter shop nao pode ter mais que 15 caracteres")]
        [Column("matric", TypeName = "varchar", Order = 187)]
        public string TbClmatric { get; set; }

        [Required(ErrorMessage = "O campo para permitir desccmb nao pode ser vazio")]
        [Column("desccmb", TypeName = "numeric", Order = 188)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCldesccmb { get; set; }


        [Required(ErrorMessage = "O campo para permitir descloj nao pode ser vazio")]
        [Column("descloj", TypeName = "numeric", Order = 189)]
        [DisplayFormat(NullDisplayText = "Sem valor registado", ApplyFormatInEditMode = true)]
        public decimal TbCldescloj { get; set; }

        [Required]
        [Column("isperson", TypeName = "bit", Order = 190)]
        public bool TbClisperson { get; set; }


        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo para conter shop pode ser nulo")]
        [MaxLength(30,
            ErrorMessage =
                "O campo para conter shop nao pode ter mais que 30 caracteres")]
        [Column("ousrinis", TypeName = "varchar", Order = 191)]
        public string TbClousrinis { get; set; }

        [Required]
        [Column("ousrdata", TypeName = "datetime", Order = 192)]
        public DateTime TbCloursdata { get; set; }

        [Required(AllowEmptyStrings = false,
          ErrorMessage = "O campo para conter hora pode ser nulo")]
        [MaxLength(8,
            ErrorMessage =
                "O campo para conter hora nao pode ter mais que 8 caracteres")]
        [Column("ousrhora", TypeName = "varchar", Order = 193)]
        public string TbClousrhora { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter uinis pode ser nulo")]
        [MaxLength(30,
            ErrorMessage =
                "O campo para conter uinis nao pode ter mais que 30 caracteres")]
        [Column("usrinis", TypeName = "varchar", Order = 194)]
        public string TbClusrinis { get; set; }

        [Required]
        [Column("usrdata", TypeName = "datetime", Order = 195)]
        public DateTime TbClusrdata { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter uhora pode ser nulo")]
        [MaxLength(8,
            ErrorMessage =
                "O campo para conter uhora nao pode ter mais que 8 caracteres")]
        [Column("usrhora", TypeName = "varchar", Order = 196)]
        public string TbClusrhora { get; set; }

        [Required]
        [Column("marcada", TypeName = "bit", Order = 197)]
        public bool TbClmarcada { get; set; }


        [Required(ErrorMessage = "O campo para permitir tipo emp nao pode ser vazio")]
        [Column("radicaltipoemp", TypeName = "numeric", Order = 198)]
        [DisplayFormat(NullDisplayText = "Sem valor registado ", ApplyFormatInEditMode = true)]
        public decimal TbClradicaltipoemp { get; set; }

        [Required]
        [Column("autofact", TypeName = "bit", Order = 199)]
        public bool TbClautofact { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter repres pode ser nulo")]
        [MaxLength(20,
            ErrorMessage =
                "O campo para conter repres nao pode ter mais que 20 caracteres")]
        [Column("numcontrepres", TypeName = "varchar", Order = 200)]
        public string TbClnumcontrepres { get; set; }

        [Required(AllowEmptyStrings = false,
       ErrorMessage = "O campo para conter codigo provincia pode ser nulo")]
        [MaxLength(2,
            ErrorMessage =
                "O campo para conter codigo provincia nao pode ter mais que 2 caracteres")]
        [Column("codprovincia", TypeName = "varchar", Order = 201)]
        public string TbClcodprovincia { get; set; }

        [Required]
        [Column("autorizacaoactiva", TypeName = "bit", Order = 202)]
        public bool TbClautorizacaoactiva { get; set; }

        [Required(AllowEmptyStrings = false,
         ErrorMessage = "O campo para conter codigo autorizacao pode ser nulo")]
        [MaxLength(11,
            ErrorMessage =
                "O campo para conter codigo autorizacao nao pode ter mais que 11 caracteres")]
        [Column("numautorizacaosdd", TypeName = "varchar", Order = 203)]
        public string TbClnumautorizacaosdd { get; set; }

        [Required(ErrorMessage = "O campo para permitir numeroseq nao pode ser vazio")]
        [Column("numseqaut", TypeName = "numeric", Order = 204)]
        [DisplayFormat(NullDisplayText = "Sem valor registado ", ApplyFormatInEditMode = true)]
        public decimal TbClnumseqaut { get; set; }

        [Required(AllowEmptyStrings = false,
         ErrorMessage = "O campo para conter meses que nao irao ser pagos pode ser nulo")]
        [MaxLength(20,
            ErrorMessage =
                "O campo para conter meses que nao irao ser pagos nao pode ter mais que 20 caracteres")]
        [Column("mesesnaopg", TypeName = "varchar", Order = 205)]
        public string TbClmesesnaopg { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter dias pagamento pode ser nulo")]
        [MaxLength(20,
            ErrorMessage =
                "O campo para conter dias pagamento nao pode ter mais que 20 caracteres")]
        [Column("diaspag", TypeName = "varchar", Order = 206)]
        public string TbCldiaspag { get; set; }

        [Required]
        [Column("cancpos", TypeName = "bit", Order = 207)]
        public bool TbClcancpos { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter descricao regime iva pode ser nulo")]
        [MaxLength(60,
            ErrorMessage =
                "O campo para conter descricao regime iva nao pode ter mais que 60 caracteres")]
        [Column("descregiva", TypeName = "varchar", Order = 208)]
        public string TbCldescregiva { get; set; }

        [Required]
        [Column("pcktsyncdate", TypeName = "datetime", Order = 209)]
        public DateTime TbClpcktsyncdate { get; set; }

        [Required(AllowEmptyStrings = false,
       ErrorMessage = "O campo para conter sincro pocket pode ser nulo")]
        [MaxLength(8,
            ErrorMessage =
                "O campo para conter dsincro pocket nao pode ter mais que 8 caracteres")]
        [Column("pcktsynctime", TypeName = "varchar", Order = 210)]
        public string TbClpcktsynctime { get; set; }


        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter descricao do motivo de isencao imposto nao pode ser nulo")]
        [MaxLength(60,
            ErrorMessage =
                "O campo para conter descricao do motivo de isencao imposto nao pode ter mais que 60 caracteres")]
        [Column("motiseimp", TypeName = "varchar", Order = 211)]
        public string TbClmotiseimp { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter codigo do motivo de isencao imposto nao pode ser nulo")]
        [MaxLength(2,
            ErrorMessage =
                "O campo para conter codigo do motivo de isencao imposto nao pode ter mais que 2 caracteres")]
        [Column("codmotiseimp", TypeName = "varchar", Order = 212)]
        public string TbClcodmotiseimp { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter distrito nao pode ser nulo")]
        [MaxLength(20,
            ErrorMessage =
                "O campo para conter distrito nao pode ter mais que 20 caracteres")]
        [Column("distrito", TypeName = "varchar", Order = 213)]
        public string TbCldistrito { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter o primeiro mail nao pode ser nulo")]
        [MaxLength(60,
            ErrorMessage =
                "O campo para conter o primeiro mail nao pode ter mais que 60 caracteres")]
        [Column("c1email", TypeName = "varchar", Order = 214)]
        public string TbClcpmail { get; set; }

        [Required(AllowEmptyStrings = false,
       ErrorMessage = "O campo para conter o segundo mail nao pode ser nulo")]
        [MaxLength(60,
            ErrorMessage =
                "O campo para conter o segundo  mail nao pode ter mais que 60 caracteres")]
        [Column("c2email", TypeName = "varchar", Order = 215)]
        public string TbClcsmail { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter o terceiro mail nao pode ser nulo")]
        [MaxLength(60,
            ErrorMessage =
                "O campo para conter o terceiro mail nao pode ter mais que 60 caracteres")]
        [Column("c3email", TypeName = "varchar", Order = 216)]
        public string TbClctmail { get; set; }

        [Required(AllowEmptyStrings = false,
        ErrorMessage = "O campo para conter o mail cobrancas nao pode ser nulo")]
        [MaxLength(60,
            ErrorMessage =
                "O campo para conter o mail cobrancas nao pode ter mais que 60 caracteres")]
        [Column("cobemail", TypeName = "varchar", Order = 217)]
        public string TbClcobemail { get; set; }


        [Required]
        [Column("ccadmin", TypeName = "bit", Order = 218)]
        public bool TbClccadmin { get; set; }

        [Required]
        [Column("geramb", TypeName = "bit", Order = 219)]
        public bool TbClgeramb { get; set; }


        public virtual ICollection<TbPClientes> TbDadosClientes { get; set; } 
    }
}
