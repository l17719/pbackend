using System;
using System.Runtime.Serialization;

namespace ConnectorService.Model.PHCModel.VODadosPHC
{
    [DataContract(Name = "VOStObs")]
    [Serializable]
    public class VoStObs
    {
        [DataMember(IsRequired = true, Name = "ref", Order = 0)]
        public string StObsRef { get; set; }

        [DataMember(IsRequired = true, Name = "stobs", Order = 1)]
        public string Stobs { get; set; }

    }
}