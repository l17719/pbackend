using System;
using System.Runtime.Serialization;

namespace ConnectorService.Model.PHCModel.VODadosPHC
{
    [DataContract(Name = "VORE")]
    [Serializable]
    public class Vore
    {
        public string REstamp{get;set;}
		public  string Nmdoc{get;set;}
		public  decimal Ndoc{get;set;}
		public  decimal Rno{get;set;}
		public  string Rdata{get;set;}
		public  decimal Reano{get;set;}
		public  string Nome{get;set;}
		public  int No{get;set;}
		public  decimal Estab{get;set;}
		public  decimal Vendedor{get;set;}
		public  string Vendnm{get;set;}
		public  string Desc1{get;set;}
		public  decimal Etotal{get;set;}
		public  decimal Efinv{get;set;}
		public  decimal Fin{get;set;}
		public  int Introfin{get;set;}
		public  int Cheque{get;set;}
		public  string Chdata{get;set;}
		public  string Tptit{get;set;}
		public  string Clbanco{get;set;}
		public  decimal Echtotal{get;set;}
		public  string Clcheque{get;set;}
		public  string Statuspda{get;set;}
		public  string Ollocal{get;set;}
		public  string Telocal{get;set;}
		public  decimal Contado{get;set;}
		public  string Ncont{get;set;}
		public  string Morada{get;set;}
		public  string Codpost{get;set;}
		public  string Local{get;set;}
    }
}
