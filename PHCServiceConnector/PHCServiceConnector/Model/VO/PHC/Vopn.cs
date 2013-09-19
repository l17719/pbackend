using System;
using System.Runtime.Serialization;

namespace ConnectorService.Model.PHCModel.VODadosPHC
{
    [DataContract(Name = "Vopn")]
    [Serializable]
    public class Vopn
    {
        [DataMember(IsRequired = true, Name = "PnStamp", Order = 0)]
        public string PnStamp { get; set; }

        [DataMember(IsRequired = true, Name = "Pnno", Order = 1)]
        public int PnNo { get; set; }

        [DataMember(IsRequired = true, Name = "PnEstab", Order = 2)]
        public int PnEstab { get; set; }

        [DataMember(IsRequired = true, Name = "PnRef", Order = 3)]
        public string PnRef { get; set; }

        [DataMember(IsRequired = true, Name = "PnDesign", Order = 4)]
        public string PnDesign { get; set; }

        [DataMember(IsRequired = true, Name = "PnFdata", Order = 5)]
        public string PnFdata { get; set; }

        [DataMember(IsRequired = true, Name = "PnNmdoc", Order = 6)]
        public string PnNmDoc { get; set; }

        [DataMember(IsRequired = true, Name = "PnFno", Order = 7)]
        public int PnFno { get; set; }

        [DataMember(IsRequired = true, Name = "PnQtt", Order = 8)]
        public decimal PnQtt { get; set; }

        [DataMember(IsRequired = true, Name = "PnEpv", Order = 9)]
        public decimal PnEpv { get; set; }

        [DataMember(IsRequired = true, Name = "PnEtiliquido", Order = 10)]
        public decimal PnEtiliquido { get; set; }

    }
}