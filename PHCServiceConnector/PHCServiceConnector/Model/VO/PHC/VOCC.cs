using System;
using System.Runtime.Serialization;

namespace ConnectorService.Model.PHCModel.VODadosPHC
{
    [DataContract(Name = "VOCC")]
    [Serializable]
    public class Vocc
    {
        [DataMember(IsRequired = true, Name = "ccstamp", Order = 1)]
        public string Ccstamp { get; set; }
        [DataMember(IsRequired = true, Name = "cmdesc", Order = 2)]
        public string Cmdesc { get; set; }
        [DataMember(IsRequired = true, Name = "nrdoc", Order = 3)]
        public decimal Nrdoc { get; set; }
        [DataMember(IsRequired = true, Name = "nome", Order = 4)]
        public string Nome { get; set; }
        [DataMember(IsRequired = true, Name = "no", Order = 5)]
        public int No { get; set; }
        [DataMember(IsRequired = true, Name = "estab", Order = 6)]
        public decimal Estab { get; set; }
        [DataMember(IsRequired = true, Name = "edeb", Order = 7)]
        public decimal Edeb { get; set; }
        [DataMember(IsRequired = true, Name = "edebf", Order = 8)]
        public decimal Edebf { get; set; }
        [DataMember(IsRequired = true, Name = "ecred", Order = 9)]
        public decimal Ecred { get; set; }
        [DataMember(IsRequired = true, Name = "ecredf", Order = 10)]
        public decimal Ecredf { get; set; }
        [DataMember(IsRequired = true, Name = "datalc", Order = 11)]
        public string Datalc { get; set; }
        [DataMember(IsRequired = true, Name = "dataven", Order = 12)]
        public string Dataven { get; set; }
        [DataMember(IsRequired = true, Name = "evalre", Order = 13)]
        public decimal Evalre { get; set; }
        [DataMember(IsRequired = true, Name = "evtmp", Order = 14)]
        public decimal Evtmp { get; set; }
        [DataMember(IsRequired = true, Name = "evirs", Order = 15)]
        public decimal Evirs { get; set; }
        [DataMember(IsRequired = true, Name = "eivav1", Order = 16)]
        public decimal Eivav1 { get; set; }
        [DataMember(IsRequired = true, Name = "eivav2", Order = 17)]
        public decimal Eivav2 { get; set; }
        [DataMember(IsRequired = true, Name = "eivav3", Order = 18)]
        public decimal Eivav3 { get; set; }
        [DataMember(IsRequired = true, Name = "eivav4", Order = 19)]
        public decimal Eivav4 { get; set; }
        [DataMember(IsRequired = true, Name = "eivav5", Order = 20)]
        public decimal Eivav5 { get; set; }
        [DataMember(IsRequired = true, Name = "eivav6", Order = 21)]
        public decimal Eivav6 { get; set; }
        [DataMember(IsRequired = true, Name = "eivav7", Order = 22)]
        public decimal Eivav7 { get; set; }
        [DataMember(IsRequired = true, Name = "eivav8", Order = 23)]
        public decimal Eivav8 { get; set; }
        [DataMember(IsRequired = true, Name = "eivav9", Order = 24)]
        public decimal Eivav9 { get; set; }
        [DataMember(IsRequired = true, Name = "moeda", Order = 25)]
        public string Moeda { get; set; }
        [DataMember(IsRequired = true, Name = "recibado", Order = 26)]
        public int Recibado { get; set; }
        [DataMember(IsRequired = true, Name = "origem", Order = 27)]
        public string Origem { get; set; }
        [DataMember(IsRequired = true, Name = "cm", Order = 28)]
        public decimal Cm { get; set; }
        [DataMember(IsRequired = true, Name = "inspda", Order = 29)]
        public int Inspda { get; set; }

    }
}
