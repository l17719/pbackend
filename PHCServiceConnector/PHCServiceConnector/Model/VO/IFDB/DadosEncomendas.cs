using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ConnectorService.Model.PHCModel.VODadosPHC;

namespace ConnectorService.Model.IFModel.VODadosTerminal
{
    [DataContract(Name = "DadosEncomendas")]
    [Serializable]
    public class DadosEncomendas
    {
        [DataMember(Name = "LinhasEncomendas", IsRequired = true, Order = 0)]
        public List<VoBi> DadosLinhas { get; set; }
        

        [DataMember(Name = "CabecalhoEncomendas",IsRequired = true,Order = 1)]
        public List<Vobo> DadosCabeca { get; set; }

    }
}