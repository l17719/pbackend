using System;
using System.Runtime.Serialization;

namespace ConnectorService.Model.PHCModel.VODadosPHC
{
    [DataContract(Name = "VOst")]
    [Serializable]
    public class VOst
    {
        [DataMember(IsRequired = true, Name = "ststamp", Order = 1)]
        public string Ststamp { get; set; }

        [DataMember(IsRequired = true, Name = "tabiva", Order = 2)]
        public decimal Tabiva { get; set; }

        [DataMember(IsRequired = true, Name = "bloqueado", Order = 3)]
        public int Bloqueado { get; set; }

        [DataMember(IsRequired = true, Name = "codigo", Order = 4)]
        public string Codigo { get; set; }

        [DataMember(IsRequired = true, Name = "forref", Order = 5)]
        public string Forref { get; set; }

        [DataMember(IsRequired = true, Name = "ref", Order = 6)]
        public string Ref { get; set; }//ref nao pode existir palavra reservada


        [DataMember(IsRequired = true, Name = "design", Order = 6)]
        public string Design { get; set; }

        [DataMember(IsRequired = true, Name = "familia", Order = 7)]
        public string Familia { get; set; }

        [DataMember(IsRequired = true, Name = "epv1", Order = 8)]
        public decimal Epv1 { get; set; }

        [DataMember(IsRequired = true, Name = "epv2", Order = 9)]
        public decimal Epv2 { get; set; }

        [DataMember(IsRequired = true, Name = "epv3", Order = 10)]
        public decimal Epv3 { get; set; }

        [DataMember(IsRequired = true, Name = "epv4", Order = 11)]
        public decimal Epv4 { get; set; }

        [DataMember(IsRequired = true, Name = "epv5", Order = 12)]
        public decimal Epv5 { get; set; }

        [DataMember(IsRequired = true, Name = "statuspda", Order = 13)]
        public string Statuspda { get; set; }
    }
}
