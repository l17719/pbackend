using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConnectorService.Model.IFModel
{
    [Table("TbOpcoesTerminal")]
    public class TbOpcoesTerminal
    {
        [Key]
        [Column("ID", TypeName = "uniqueidentifier", Order = 0)]
        public Guid Id { get; set; }

        //[Required(AllowEmptyStrings = false,
        //    ErrorMessage = "O campo filtro de clientes nao pode ser vazio")]
        //[MaxLength(25, ErrorMessage = "O campo PHCFCStamp nao pode ter mais do que 25 caracteres")]
        //[Column("PHCIDFiltroClientes", TypeName = "varchar", Order = 1)]
        //[StringLength(25)]
        //public string PhcIdFiltroCliente { get; set; }


        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo nome filtro clientes nao pode ser vazio")]
        [MaxLength(150, ErrorMessage = "O campo nome filtro clientes nao pode ter mais que 150 caracteres")]
        [Column("PHCNomeFiltroClientes", TypeName = "varchar", Order = 1)]
        public string PhcnFiltroCl { get; set; }

        //[Required(AllowEmptyStrings = false,
        //    ErrorMessage = "O campo filtro de artigos nao pode ser vazio")]
        //[MaxLength(25, ErrorMessage = "O campo filtros de artigos nao pode ter mais do que 25 caracteres")]
        //[Column("PHCIDFiltroArtigos", TypeName = "varchar", Order = 3)]
        //public string PhcIdFiltroStock { get; set; }

        [Required(ErrorMessage = "O campo Numero Máximo de Descontos nao pode ser nulo")]
        [Column("NumMaxDescontos", TypeName = "int", Order = 2)]
        [DisplayFormat(NullDisplayText = "Sem armazem de envio registado", ApplyFormatInEditMode = true)]
        public int NumeroMaximoDescontos { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo nome filtro clientes nao pode ser vazio")]
        [MaxLength(150, ErrorMessage = "O campo nome filtro clientes nao pode ter mais que 150 caracteres")]
        [Column("PHCNomeFiltroArtigos", TypeName = "varchar", Order = 3)]
        public string PhcnFiltroAr { get; set; }

        [Required(ErrorMessage = "O campo armazem de envio nao pode ser vazio")]
        [Column("ArmazemEnvio", TypeName = "numeric", Order = 4)]
        [DisplayFormat(NullDisplayText = "Sem armazem de envio registado", ApplyFormatInEditMode = true)]
        public decimal Armenv { get; set; }

        [Required(ErrorMessage = "O campo armazem de registo nao pode ser vazio")]
        [Column("ArmazemRegisto", TypeName = "numeric", Order = 5)]
        [DisplayFormat(NullDisplayText = "Sem armazem de registo adicionado", ApplyFormatInEditMode = true)]
        public decimal Armreg { get; set; }

        // ver este campo na base dados numero dossier interno
        [Required]
        [Column("PHCNumDossierInterno", TypeName = "numeric", Order = 6)]
        [DisplayFormat(NullDisplayText = "Sem dossier interno registado", ApplyFormatInEditMode = true)]
        public decimal PhcNumDi { get; set; }
        //

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "O campo nome dossier interno nao pode ser vazio")]
        [MaxLength(25,
            ErrorMessage = "O campo nome dossier interno nao pode ter mais do que 25 caracteres")]
        [Column("PHCNomeDossierInterno", TypeName = "varchar", Order = 7)]
        public string PhcNomeDi { get; set; }


        [Required(ErrorMessage = "O campo para reter encomendas nao pode ser nulo",
            AllowEmptyStrings = false)]
        [MaxLength(2, ErrorMessage = "O campo reter encomendas nao pode ter mais que 1 caracter")]
        [Column("TipoRetencaoEncomendas", TypeName = "varchar", Order = 8)]
        public string RetemEncomendas { get; set; }

        [Required(ErrorMessage = "o campo numero de encomendas a reter nao pode ser menor que zero")]
        [Column("NumeroEncomendasRetidas", TypeName = "int", Order = 9)]
        [DisplayFormat(NullDisplayText = "Sem valor introduzido", ApplyFormatInEditMode = true)]
        public int NumEncomendasReter { get; set; }


        // adicionar os campos a db
        [Required(ErrorMessage = "o campo para inicio de registo de clientes nao pode ser igual ou menor que zero")]
        [Column("NumeroInicioClientes", TypeName = "int", Order = 10)]
        [DisplayFormat(NullDisplayText = "Sem valor introduzido", ApplyFormatInEditMode = true)]
        public int InitClientes { get; set; }

        [Required(ErrorMessage = "o campo para fim de registo de clientes nao pode ser igual ou menor que zero")]
        [Column("NumeroFimClientes", TypeName = "int", Order = 11)]
        public int FimClientes { get; set; }
        //


        //comparar este campo com a base dados
        [Required(ErrorMessage = "o campo para inicio de encomendas nao pode ser menor que zero")]
        [Column("NumeroInicioEncomendas", TypeName = "int", Order = 12)]
        [DisplayFormat(NullDisplayText = "Sem Valor Introduzido", ApplyFormatInEditMode = true)]
        public int InitEncomendas { get; set; }

        [Required(ErrorMessage = "O campo para fim de encomendas nao pode ser menor que zero")]
        [Column("NumeroFimEncomendas", TypeName = "int", Order = 13)]
        public int FimEncomendas { get; set; }
        //


        [Required]
        [Column("EliminarEncomendas", TypeName = "bit", Order = 14)]
        public bool EliminaEncomenda { get; set; }

        [Required]
        [Column("AlterarPrecoVenda", TypeName = "bit", Order = 15)]
        public bool AltPrecoVenda { get; set; }

        [Required]
        [Column("IntroduzComponentes", TypeName = "bit", Order = 16)]
        public bool IntCompSinc { get; set; }

        [Required]
        [Column("MostrarDataLinhas", TypeName = "bit", Order = 17)]
        public bool EncMostraData { get; set; }

        [Required]
        [Column("CriaLinhaEncomenda", TypeName = "bit", Order = 18)]
        public bool CriarLinha { get; set; }

        [Required]
        [Column("UsaPreco1", TypeName = "bit", Order = 19)]
        public bool UsaPrecoUm { get; set; }

        [Required]
        [Column("UsaPreco2", TypeName = "bit", Order = 20)]
        public bool UsaPrecoDois { get; set; }

        [Required]
        [Column("UsaPreco3", TypeName = "bit", Order = 21)]
        public bool UsaPrecoTres { get; set; }

        [Required]
        [Column("UsaPreco4", TypeName = "bit", Order = 22)]
        public bool UsaPrecoQuatro { get; set; }

        [Required]
        [Column("UsaPreco5", TypeName = "bit", Order = 22)]
        public bool UsaPrecoCinco { get; set; }

        [Required]
        [Column("IniciaisUS", TypeName = "varchar", Order = 23)]
        public string ValorIniciaisUs { get; set; }

        [Required(ErrorMessage = "O campo numero vendedor nao pode ser nulo")]
        [Column("NumVendedor", TypeName = "int", Order = 24)]
        public int NumVendedor { get; set; }

        [Required(ErrorMessage = "O campo para conter o numero de vendedor nao pode ser nulo",
            AllowEmptyStrings = false)]
        [MaxLength(50, ErrorMessage = "O campo NomeVendedor nao pode ter mais do que 50 caracteres")]
        [Column("NomeVendedor", TypeName = "varchar", Order = 25)]
        [StringLength(50)]
        public string NomeVendedor { get; set; }

        public virtual ICollection<TbTerminais> TbTerminals { get; set; }
    }
}