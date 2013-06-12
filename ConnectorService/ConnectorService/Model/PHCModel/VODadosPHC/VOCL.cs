using System;
using System.Runtime.Serialization;

namespace ConnectorService.Model.PHCModel.VODadosPHC
{
    [DataContract(Name = "VOCL")]
    [Serializable]
    public class Vocl
    {
        [DataMember(IsRequired = true, Name = "clstamp", Order = 0)]
        public string Clstamp { get; set; }

        [DataMember(IsRequired = true, Name = "preco", Order = 1)]
        public int Preco { get; set; }

        [DataMember(IsRequired = true, Name = "tabiva", Order = 2)]
        public int Tabiva { get; set; }

        [DataMember(IsRequired = true, Name = "desconto", Order = 3)]
        public decimal Desconto { get; set; }

        [DataMember(IsRequired = true, Name = "nocredit", Order = 4)]
        public int Nocredit { get; set; }

        [DataMember(IsRequired = true, Name = "no", Order = 5)]
        public int No { get; set; }

        [DataMember(IsRequired = true, Name = "estab", Order = 6)]
        public int Estab { get; set; }

        [DataMember(IsRequired = true, Name = "nome", Order = 7)]
        public string Nome { get; set; }

        [DataMember(IsRequired = true, Name = "abreviatura", Order = 8)]
        public string Abreviatura { get; set; }

        [DataMember(IsRequired = true, Name = "morada", Order = 9)]
        public string Morada { get; set; }

        [DataMember(IsRequired = true, Name = "local", Order = 10)]
        public string Local { get; set; }

        [DataMember(IsRequired = true, Name = "codpostal", Order = 11)]
        public string Codpostal { get; set; }

        [DataMember(IsRequired = true, Name = "obs", Order = 12)]
        public string Obs { get; set; }

        [DataMember(IsRequired = true, Name = "tlmvl", Order = 13)]
        public string Tlmvl { get; set; }

        [DataMember(IsRequired = true, Name = "telefone", Order = 14)]
        public string Telefone { get; set; }

        [DataMember(IsRequired = true, Name = "email", Order = 15)]
        public string Email { get; set; }

        [DataMember(IsRequired = true, Name = "esaldo", Order = 16)]
        public decimal Esaldo { get; set; }

        [DataMember(IsRequired = true, Name = "statuspda", Order = 17)]
        public string Statuspda { get; set; }

        [DataMember(IsRequired = true, Name = "vendedor", Order = 18)]
        public int Vendedor { get; set; }

        [DataMember(IsRequired = true, Name = "vendnm", Order = 19)]
        public string Vendnm { get; set; }

        [DataMember(IsRequired = true, Name = "ncont", Order = 20)]
        public string Ncont { get; set; }

        [DataMember(IsRequired = true, Name = "tipo", Order = 21)]
        public string Tipo { get; set; }

        [DataMember(IsRequired = true, Name = "contacto", Order = 22)]
        public string Contacto { get; set; }

       
    }



}
