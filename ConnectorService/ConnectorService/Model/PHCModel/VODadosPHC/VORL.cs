using System;
using System.Runtime.Serialization;

namespace ConnectorService.Model.PHCModel.VODadosPHC
{
    [DataContract(Name = "VORL")]
    [Serializable]
    public class Vorl
    {
        public string RLstamp{get;set;}
		public decimal Ndoc{get;set;}
		public decimal Rno{get;set;}
		public string Cdesc{get;set;}
		public decimal Nrdoc{get;set;}
		public string Datalc{get;set;}
		public string Dataven{get;set;}
		public string Restamp{get;set;}
		public string Ccstamp{get;set;}
		public decimal Cm{get;set;}
		public decimal Eval{get;set;}
		public decimal Erec{get;set;}
		public decimal Enaval{get;set;}
		public decimal Evori{get;set;}
		public int Cheque{get;set;}
    }
}
