using System;
using System.Runtime.Serialization;

namespace ConnectorService.Model.PHCModel.VODadosPHC
{
    [DataContract(Name = "VOBL")]
    [Serializable]
    public class Vobl
    {
       [DataMember(IsRequired = true, Name = "blstamp", Order = 0)]
        public string Blstamp { get; set; }

        [DataMember(IsRequired = true, Name = "banco", Order = 1)]
        public string Banco { get; set; }

        [DataMember(IsRequired = true, Name = "conta", Order = 2)]
        public string Conta { get; set; }

         [DataMember(IsRequired = true, Name = "contas", Order = 3)]
        public string Contas { get; set; }
    }
}
