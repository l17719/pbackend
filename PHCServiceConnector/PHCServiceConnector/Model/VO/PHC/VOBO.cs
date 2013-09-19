using System;
using System.Runtime.Serialization;

namespace ConnectorService.Model.PHCModel.VODadosPHC
{
    [DataContract(Name = "VOBO")]
    [Serializable]
    public class Vobo
    {
        [DataMember(IsRequired = true, Name = "bostamp", Order = 0)]
        public string BOstamp { get; set; }
        [DataMember(IsRequired = true, Name = "vendedor", Order = 1)]
        public decimal Vendedor { get; set; }
        [DataMember(IsRequired = true, Name = "vendnm", Order = 2)]
        public string Vendnm { get; set; }
        [DataMember(IsRequired = true, Name = "nmdos", Order = 3)]
        public string Nmdos { get; set; }
        [DataMember(IsRequired = true, Name = "ndos", Order = 4)]
        public decimal Ndos { get; set; }
        [DataMember(IsRequired = true, Name = "obrano", Order = 5)]
        public int Obrano { get; set; }
        [DataMember(IsRequired = true, Name = "dataobra", Order = 6)]
        public string Dataobra { get; set; }
        [DataMember(IsRequired = true, Name = "obranome", Order = 7)]
        public string Obranome { get; set; }
        [DataMember(IsRequired = true, Name = "nome", Order = 8)]
        public string BoNome { get; set; }
        [DataMember(IsRequired = true, Name = "no", Order = 9)]
        public int No { get; set; }
        [DataMember(IsRequired = true, Name = "estab", Order = 10)]
        public decimal Estab { get; set; }
        [DataMember(IsRequired = true, Name = "etotaldeb", Order = 11)]
        public decimal Etotaldeb { get; set; }
        [DataMember(IsRequired = true, Name = "obs", Order = 12)]
        public string Obs { get; set; }
        [DataMember(IsRequired = true, Name = "statuspda", Order = 13)]
        public string Statuspda { get; set; }
        [DataMember(IsRequired = true, Name = "ebo_2tvall", Order = 14)]
        public decimal Ebo2Tvall { get; set; }
        [DataMember(IsRequired = true, Name = "ebo_2tdes1", Order = 15)]
        public decimal Ebo2Tdes1 { get; set; }
        [DataMember(IsRequired = true, Name = "ebo_2tdes2", Order = 16)]
        public decimal Ebo2Tdes2 { get; set; }
        [DataMember(IsRequired = true, Name = "ebo_totp2", Order = 17)]
        public decimal EboTotp2 { get; set; }
        [DataMember(IsRequired = true, Name = "edescc", Order = 18)]
        public decimal Edescc { get; set; }
        [DataMember(IsRequired = true, Name = "ebo12_bins", Order = 19)]
        public decimal Ebo12Bins { get; set; }
        [DataMember(IsRequired = true, Name = "ebo12_iva", Order = 20)]
        public decimal Ebo12Iva { get; set; }
        [DataMember(IsRequired = true, Name = "ebo22_bins", Order = 21)]
        public decimal Ebo22Bins { get; set; }
        [DataMember(IsRequired = true, Name = "ebo22_iva", Order = 22)]
        public decimal Ebo22Iva { get; set; }
        [DataMember(IsRequired = true, Name = "ebo32_bins", Order = 23)]
        public decimal Ebo32Bins { get; set; }
        [DataMember(IsRequired = true, Name = "ebo32_iva", Order = 24)]
        public decimal Ebo32Iva { get; set; }
        [DataMember(IsRequired = true, Name = "ebo42_bins", Order = 25)]
        public decimal Ebo42Bins { get; set; }
        [DataMember(IsRequired = true, Name = "ebo42_iva", Order = 26)]
        public decimal Ebo42Iva { get; set; }
        [DataMember(IsRequired = true, Name = "ebo52_bins", Order = 27)]
        public decimal Ebo52Bins { get; set; }
        [DataMember(IsRequired = true, Name = "ebo52_iva", Order = 28)]
        public decimal Ebo52Iva { get; set; }
        [DataMember(IsRequired = true, Name = "ebo62_bins", Order = 29)]
        public decimal Ebo62Bins { get; set; }
        [DataMember(IsRequired = true, Name = "ebo62_iva", Order = 30)]
        public decimal Ebo62Iva { get; set; }

        [DataMember(IsRequired = true, Name = "nome2", Order = 31)]
        public string Nome2 { get; set; }
       
    }
}
