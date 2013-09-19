using System;
using System.Runtime.Serialization;

namespace ConnectorService.Model.PHCModel.VODadosPHC
{
    [DataContract(Name = "VOBOD")]
    [Serializable]
    public class Vobod
    {
        [DataMember(IsRequired = true, Name = "BO2stamp", Order = 0)]
        public string Bo2Stamp { get; set; }
        [DataMember(IsRequired = true, Name = "ebo72_bins", Order = 1)]
        public decimal Ebo72Bins { get; set; }
        [DataMember(IsRequired = true, Name = "ebo72_iva", Order = 2)]
        public decimal Ebo72Iva { get; set; }
        [DataMember(IsRequired = true, Name = "ebo82_bins", Order = 3)]
        public decimal Ebo82Bins { get; set; }
        [DataMember(IsRequired = true, Name = "ebo82_iva", Order = 4)]
        public decimal Ebo82Iva { get; set; }
        [DataMember(IsRequired = true, Name = "ebo92_bins", Order = 5)]
        public decimal Ebo92Bins { get; set; }
        [DataMember(IsRequired = true, Name = "ebo92_iva", Order = 6)]
        public decimal Ebo92Iva { get; set; }

    }
}
