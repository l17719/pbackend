using System;
using System.Collections.Generic;

namespace PHCServiceConnector.Model.DbModel.IFModel
{
    public class OpcoesTerminais
    {
        public Guid ID { get; set; }
        public string PhcNomeFiltroClientes { get; set; }
        public int NumMaxDescontos { get; set; }
        public string PhcNomeFiltroArtigos { get; set; }
        public decimal ArmazemEnvio { get; set; }
        public decimal ArmazemRegisto { get; set; }
        public decimal PhcNumDossierInterno { get; set; }
        public string PhcNomeDossierInterno { get; set; }
        public string TipoRetencaoEncomendas { get; set; }
        public int NumeroEncomendasRetidas { get; set; }
        public int NumeroInicioClientes { get; set; }
        public int NumeroFimClientes { get; set; }
        public int NumeroInicioEncomendas { get; set; }
        public int NumeroFimEncomendas { get; set; }
        public bool EliminarEncomendas { get; set; }
        public bool AlterarPrecoVenda { get; set; }
        public bool IntroduzComponentes { get; set; }
        public bool MostrarDataLinhas { get; set; }
        public bool CriaLinhaEncomenda { get; set; }
        public bool UsaPreco1 { get; set; }
        public bool UsaPreco2 { get; set; }
        public bool UsaPreco3 { get; set; }
        public bool UsaPreco4 { get; set; }
        public bool UsaPreco5 { get; set; }
        public string IniciaisUs { get; set; }
        public int NumVendedor { get; set; }
        public string NomeVendedor { get; set; }
        public bool SincronizaCcNaoRegula { get; set; }
        public virtual ICollection<Terminais> ListaTerminais { get; set; }
    }
}