using System;
using System.Runtime.Serialization;

namespace ConnectorService.Model.PHCModel.VODadosPHC
{
    [DataContract(Name = "RemoteBi")]
    [Serializable]
    public class RemoteBi
    {
        [DataMember(IsRequired = true, Name = "stamp", Order = 0)]
        public string BIstamp { get; set; }
        [DataMember(IsRequired = true, Name = "ivaincl", Order = 1)]
        public decimal Ivaincl { get; set; }
        [DataMember(IsRequired = true, Name = "iva", Order = 2)]
        public decimal Iva { get; set; }
        [DataMember(IsRequired = true, Name = "lordem", Order = 3)]
        public decimal Lordem { get; set; }
        [DataMember(IsRequired = true, Name = "tabiva", Order = 4)]
        public decimal Tabiva { get; set; }
        [DataMember(IsRequired = true, Name = "txiva", Order = 5)]
        public decimal Txiva { get; set; }
        [DataMember(IsRequired = true, Name = "promo", Order = 6)]
        public int Promo { get; set; }
        [DataMember(IsRequired = true, Name = "epromo", Order = 7)]
        public int Epromo { get; set; }
        [DataMember(IsRequired = true, Name = "bostamp", Order = 8)]
        public string Bostamp { get; set; }
        [DataMember(IsRequired = true, Name = "obrano", Order = 9)]
        public int Obrano { get; set; }
        [DataMember(IsRequired = true, Name = "ref", Order = 10)]
        public string Ref { get; set; }
        [DataMember(IsRequired = true, Name = "edebito", Order = 11)]
        public decimal Edebito { get; set; }
        [DataMember(IsRequired = true, Name = "desconto", Order = 12)]
        public decimal Desconto { get; set; }
        [DataMember(IsRequired = true, Name = "desc2", Order = 13)]
        public decimal Desc2 { get; set; }
        [DataMember(IsRequired = true, Name = "ettdeb", Order = 14)]
        public decimal Ettdeb { get; set; }
        [DataMember(IsRequired = true, Name = "qtt", Order = 15)]
        public decimal Qtt { get; set; }
        [DataMember(IsRequired = true, Name = "stipo", Order = 16)]
        public decimal Stipo { get; set; }
        [DataMember(IsRequired = true, Name = "armazem", Order = 17)]
        public decimal Armazem { get; set; }
        [DataMember(IsRequired = true, Name = "rdata", Order = 18)]
        public string Rdata { get; set; }

        [DataMember(IsRequired = false, Name = "desc3", Order = 19, EmitDefaultValue = true)]
        public decimal Desc3 { get; set; }

        [DataMember(IsRequired = false, Name = "desc4", Order = 20, EmitDefaultValue = true)]
        public decimal Desc4 { get; set; }

        [DataMember(IsRequired = false, Name = "desc5", Order = 21, EmitDefaultValue = true)]
        public decimal Desc5 { get; set; }

        [DataMember(IsRequired = false, Name = "desc6", Order = 22, EmitDefaultValue = true)]
        public decimal Desc6 { get; set; }
    }
}
