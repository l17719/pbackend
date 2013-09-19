using System;
using System.Runtime.Serialization;

namespace ConnectorService.Model.PHCModel.VODadosPHC
{
    [DataContract(Name = "VoBi")]
    [Serializable]
    public class VoBi
    {
        [DataMember(IsRequired = true, Name = "bistamp", Order = 0)]
        public string BIstamp { get; set; }
        [DataMember(IsRequired = true, Name = "ivaincl", Order = 1)]
        public decimal Ivaincl { get; set; }
        [DataMember(IsRequired = true, Name = "vendnm", Order = 2)]
        public string Vendnm { get; set; }
        [DataMember(IsRequired = true, Name = "vendedor", Order = 3)]
        public decimal Vendedor { get; set; }
        [DataMember(IsRequired = true, Name = "iva", Order = 4)]
        public decimal Iva { get; set; }
        [DataMember(IsRequired = true, Name = "lordem", Order = 5)]
        public decimal Lordem { get; set; }
        [DataMember(IsRequired = true, Name = "tabiva", Order = 6)]
        public decimal Tabiva { get; set; }
        [DataMember(IsRequired = true, Name = "txiva", Order = 7)]
        public decimal Txiva { get; set; }
        [DataMember(IsRequired = true, Name = "familia", Order = 8)]
        public string Familia { get; set; }
        [DataMember(IsRequired = true, Name = "promo", Order = 9)]
        public int Promo { get; set; }
        [DataMember(IsRequired = true, Name = "epromo", Order = 10)]
        public int Epromo { get; set; }
        [DataMember(IsRequired = true, Name = "bostamp", Order = 11)]
        public string Bostamp { get; set; }
        [DataMember(IsRequired = true, Name = "nmdos", Order = 12)]
        public string Nmdos { get; set; }
        [DataMember(IsRequired = true, Name = "ndos", Order = 13)]
        public decimal Ndos { get; set; }
        [DataMember(IsRequired = true, Name = "obrano", Order = 14)]
        public int Obrano { get; set; }
        [DataMember(IsRequired = true, Name = "ref", Order = 15)]
        public string Ref { get; set; }
        [DataMember(IsRequired = true, Name = "design", Order = 16)]
        public string Design { get; set; }
        [DataMember(IsRequired = true, Name = "edebito", Order = 17)]
        public decimal Edebito { get; set; }
        [DataMember(IsRequired = true, Name = "desconto", Order = 18)]
        public decimal Desconto { get; set; }
        [DataMember(IsRequired = true, Name = "desc2", Order = 19)]
        public decimal Desc2 { get; set; }
        [DataMember(IsRequired = true, Name = "ettdeb", Order = 20)]
        public decimal Ettdeb { get; set; }
        [DataMember(IsRequired = true, Name = "qtt", Order = 21)]
        public decimal Qtt { get; set; }
        [DataMember(IsRequired = true, Name = "stipo", Order = 22)]
        public decimal Stipo { get; set; }
        [DataMember(IsRequired = true, Name = "armazem", Order = 23)]
        public decimal Armazem { get; set; }
        [DataMember(IsRequired = true, Name = "rdata", Order = 24)]
        public string Rdata { get; set; }
        //[DataMember(IsRequired = true, Name = "boobra", Order = 24)]
        //public string Boobra { get; set; }

        [DataMember(IsRequired = true, Name = "desc3", Order = 25)]
        public decimal Desc3 { get; set; }

        [DataMember(IsRequired = true, Name = "desc4", Order = 26)]
        public decimal Desc4 { get; set; }

        [DataMember(IsRequired = true, Name = "desc5", Order = 27)]
        public decimal Desc5 { get; set; }

        [DataMember(IsRequired = true, Name = "desc6", Order = 28)]
        public decimal Desc6 { get; set; }
    }
}
