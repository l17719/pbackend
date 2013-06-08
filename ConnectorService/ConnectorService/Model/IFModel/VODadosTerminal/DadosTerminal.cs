using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ConnectorService.Model.PHCModel.VODadosPHC;

namespace ConnectorService.Model.IFModel.VODadosTerminal
{
    [DataContract(Name = "VODadosTerminal")]
    [Serializable]
    public class DadosTerminal
    {
        [DataMember(IsRequired = true, Name = "DadosStocks", Order = 0)]
        public List<VOst> DadosStocks { get; set; }

        [DataMember(IsRequired = true, Name = "DadosClientes", Order = 1)]
        public List<Vocl> DadosClientes { get; set; }

        [DataMember(IsRequired = true, Name = "DadosContasCorrentes", Order = 2)]
        public List<Vocc> DadosContasCorrentes { get; set; }

        [DataMember(IsRequired = true, Name = "DadosTaxasIVa", Order = 3)]
        public List<VOtaxasIva> DadosTaxasIva { get; set; }

        [DataMember(IsRequired = true, Name = "Dadospn", Order = 4)]
        public List<Vopn> DadosPn { get; set; }

        //[DataMember(IsRequired = true, Name = "DadosStobs", Order = 5)]
        //public List<VoStObs> DadosStobs { get; set; } 
    }
}