using System;
using System.Runtime.Serialization;

namespace ConnectorService.Model.PHCModel.VODadosPHC
{
    [DataContract(Name = "VOtaxasIVA")]
    [Serializable]
    public class VOtaxasIva
    {
         [DataMember(IsRequired = true, Name = "taxasIVAstamp", Order = 0)]
        public string TaxasIvAstamp { get; set; }
         [DataMember(IsRequired = true, Name = "descricao", Order = 1)]
		public string  Descricao{ get; set; }
         [DataMember(IsRequired = true, Name = "valor", Order = 2)]
        public string Valor { get; set; }
    }
}
