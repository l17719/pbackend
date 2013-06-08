using System;
using System.Runtime.Serialization;

namespace ConnectorService.Model.IFModel.VODadosTerminal
{
    [DataContract(Name = "AcesskeyData")]
    [Serializable]
    public class AcesskeyData
    {
        [DataMember(IsRequired = true, Name = "AccessKey", Order = 0)]
        public string DataAccessKey { get; set; }
    }
}