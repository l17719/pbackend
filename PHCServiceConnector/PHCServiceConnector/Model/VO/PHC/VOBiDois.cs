
using System;
using System.Runtime.Serialization;

namespace ConnectorService.Model.PHCModel.VODadosPHC
{
    [DataContract(Name = "VOBiDois")]
    [Serializable]
    public class VoBiDois
    {
         [DataMember(IsRequired = true, Name = "BiDStamp", Order = 0)]
        public string BiDStamp { get; set; }
         [DataMember(IsRequired = true, Name = "BiDBoStamp", Order = 1)]
        public string BiDBoStamp { get; set; }
         [DataMember(IsRequired = true, Name = "BiDousrdata", Order = 2)]
        public string BiDousrdata { get; set; }
         [DataMember(IsRequired = true, Name = "BiDusrusrdata", Order = 3)]
        public string BiDusrusrdata { get; set; }
    }
}
