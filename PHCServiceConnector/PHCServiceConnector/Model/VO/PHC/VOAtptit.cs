using System;
using System.Runtime.Serialization;

namespace ConnectorService.Model.PHCModel.VODadosPHC
{
    [DataContract(Name = "VOAtptit")]
    [Serializable]
    public class VoAtptit
    {
         [DataMember(IsRequired = true, Name = "atptitstamp", Order = 0)]
        public string Atptitstamp { get; set; }

         [DataMember(IsRequired = true, Name = "", Order = 1)]
        public string Campo { get; set; }
    }
}
