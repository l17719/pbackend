using System;
using System.Runtime.Serialization;

namespace ConnectorService.Model.IFModel.VODadosTerminal
{
    [DataContract(Name = "VOConfig")]
    [Serializable]
    public class ConfiguracaoTerminal
    {
        [DataMember(IsRequired = true, Name = "TerminalID", Order = 0)]
        public string IdConfiguracao { get; set; }

        [DataMember(IsRequired = true, Name = "NumPda", Order = 1)]
        public string NumPda { get; set; }

        [DataMember(IsRequired = true, Name = "NumVendedor", Order = 2)]
        public int NumVendedor { get; set; }

        [DataMember(IsRequired = true, Name = "NomeVendedor", Order = 3)]
        public string NomeVendedor { get; set; }

        [DataMember(IsRequired = true, Name = "PHCFiltroStock", Order = 4)]
        public string FiltroStock { get; set; }

        [DataMember(IsRequired = true, Name = "PHCFiltroCliente", Order = 5)]
        public string FiltroCliente { get; set; }

        //[DataMember(IsRequired = true, Name = "MacAddressG", Order = 6)]
        //public string MacAddressG { get; set; }

        //[DataMember(IsRequired = true, Name = "MacAddressW", Order = 7)]
        //public string MacAddressW { get; set; }

        //[DataMember(IsRequired = true, Name = "AccessKey", Order = 8)]
        //public string AccessKey { get; set; }

        [DataMember(IsRequired = true, Name = "ArmazemEnvioEncomenda", Order = 9)]
        public decimal ArmazemEnvioEncomenda { get; set; }

        [DataMember(IsRequired = true, Name = "ArmazemRegistoEncomenda", Order = 10)]
        public decimal ArmazemRegistoEncomenda { get; set; }

        [DataMember(IsRequired = true, Name = "PhcNumDossier", Order = 11)]
        public decimal PhcNumDossier { get; set; }

        [DataMember(IsRequired = true, Name = "PhcNomeDossier", Order = 12)]
        public string PhcNomeDossier { get; set; }

        [DataMember(IsRequired = true, Name = "TipoRetencaoEncomendas", Order = 13)]
        public string TipoRetencaoEncomendas { get; set; }

        [DataMember(IsRequired = true, Name = "NumeroEncomendasRetidas", Order = 14)]
        public int NumeroEncomendasRetidas { get; set; }

        [DataMember(IsRequired = true,Name = "NumeroInicioClientes",Order = 15)]
        public int NumeroInicioClientes { get; set; }

        [DataMember(IsRequired = true,Name = "NumeroFimClientes",Order = 16)]
        public int NumeroFimClientes { get; set; }

        [DataMember(IsRequired = true, Name = "NumeroInicioEncomendas", Order = 17)]
        public int NumeroInicioEncomendas { get; set; }

        [DataMember(IsRequired = true, Name = "NumeroFimEncomendas", Order = 18)]
        public int NumeroFimEncomendas { get; set; }

        [DataMember(IsRequired = true, Name = "EliminarEncomendas", Order = 19)]
        public int EliminarEncomendas { get; set; }

        [DataMember(IsRequired = true, Name = "AlterarPrecoVenda", Order = 20)]
        public int AlterarPrecoVenda { get; set; }

        [DataMember(IsRequired = true, Name = "IntroduzComponentes", Order = 21)]
        public int IntroduzComponentes { get; set; }

        [DataMember(IsRequired = true, Name = "MostrarDataLinhas", Order = 22)]
        public int MostrarDataLinhas { get; set; }

        [DataMember(IsRequired = true, Name = "CriaLinhaEncomenda", Order = 23)]
        public int CriaLinhaEncomenda { get; set; }

        [DataMember(IsRequired = true, Name = "UsaPrecoU", Order = 24)]
        public int UsaPrecoUm { get; set; }

        [DataMember(IsRequired = true, Name = "UsaPrecoD", Order = 25)]
        public int UsaPrecoDois { get; set; }

        [DataMember(IsRequired = true, Name = "UsaPrecoT", Order = 26)]
        public int UsaPrecoTres { get; set; }

        [DataMember(IsRequired = true, Name = "UsaPrecoQ", Order = 27)]
        public int UsaPrecoQuatro { get; set; }

        [DataMember(IsRequired = true, Name = "UsaPrecoC", Order = 28)]
        public int UsaPrecoCinco { get; set; }

        [DataMember(IsRequired = true, Name = "NumMaxDescontos", Order = 29)]
        public int NumMaxDescontos { get; set; }

        [DataMember(IsRequired = true, Name = "IniciaisPHC", Order = 30)]
        public string PhcInitials { get; set; }

        
       

    }
}