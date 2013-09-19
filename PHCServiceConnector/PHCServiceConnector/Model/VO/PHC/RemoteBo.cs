using System;
using System.Runtime.Serialization;

namespace ConnectorService.Model.PHCModel.VODadosPHC
{
    [DataContract(Name = "RemoteBo")]
    [Serializable]
    public class RemoteBo
    {
        [DataMember(IsRequired = true, Name = "st", Order = 0)]
        public string BOstamp { get; set; }
        [DataMember(IsRequired = true, Name = "nv", Order = 1)]
        public decimal Vendedor { get; set; }
        [DataMember(IsRequired = true, Name = "ndos", Order = 2)]
        public decimal Ndos { get; set; }
        [DataMember(IsRequired = true, Name = "obrano", Order = 3)]
        public int Obrano { get; set; }
        [DataMember(IsRequired = true, Name = "data", Order = 4)]
        public string Dataobra { get; set; }
        [DataMember(IsRequired = true, Name = "nome", Order = 5)]
        public string BoNome { get; set; }
        [DataMember(IsRequired = true, Name = "no", Order = 6)]
        public int No { get; set; }
        [DataMember(IsRequired = true, Name = "estab", Order = 7)]
        public decimal Estab { get; set; }
        [DataMember(IsRequired = true, Name = "etotdeb", Order = 8)]
        public decimal Etotaldeb { get; set; }
        [DataMember(IsRequired = true, Name = "stpda", Order = 9)]
        public string Statuspda { get; set; }
        [DataMember(IsRequired = true, Name = "ebo2tvall", Order = 10)]
        public decimal Ebo2Tvall { get; set; }
        [DataMember(IsRequired = true, Name = "ebo2tdes1", Order = 11)]
        public decimal Ebo2Tdes1 { get; set; }
        [DataMember(IsRequired = true, Name = "ebo2tdes2", Order = 12)]
        public decimal Ebo2Tdes2 { get; set; }
        [DataMember(IsRequired = true, Name = "ebototp2", Order = 13)]
        public decimal EboTotp2 { get; set; }
        [DataMember(IsRequired = true, Name = "edescc", Order = 14)]
        public decimal Edescc { get; set; }
        [DataMember(IsRequired = true, Name = "ebo12bins", Order = 15)]
        public decimal Ebo12Bins { get; set; }
        [DataMember(IsRequired = true, Name = "ebo12iva", Order = 16)]
        public decimal Ebo12Iva { get; set; }
        [DataMember(IsRequired = true, Name = "ebo22bins", Order = 17)]
        public decimal Ebo22Bins { get; set; }
        [DataMember(IsRequired = true, Name = "ebo22iva", Order = 18)]
        public decimal Ebo22Iva { get; set; }
        [DataMember(IsRequired = true, Name = "ebo32bins", Order = 19)]
        public decimal Ebo32Bins { get; set; }
        [DataMember(IsRequired = true, Name = "ebo32iva", Order = 20)]
        public decimal Ebo32Iva { get; set; }
        [DataMember(IsRequired = true, Name = "ebo42bins", Order = 21)]
        public decimal Ebo42Bins { get; set; }
        [DataMember(IsRequired = true, Name = "ebo42iva", Order = 22)]
        public decimal Ebo42Iva { get; set; }
        [DataMember(IsRequired = true, Name = "ebo52bins", Order = 23)]
        public decimal Ebo52Bins { get; set; }
        [DataMember(IsRequired = true, Name = "ebo52iva", Order = 24)]
        public decimal Ebo52Iva { get; set; }
        [DataMember(IsRequired = true, Name = "ebo62bins", Order = 25)]
        public decimal Ebo62Bins { get; set; }
        [DataMember(IsRequired = true, Name = "ebo62iva", Order = 26)]
        public decimal Ebo62Iva { get; set; }

    }
}
