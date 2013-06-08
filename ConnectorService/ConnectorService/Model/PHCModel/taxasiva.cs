using System;

namespace ConnectorService.Model.PHCModel
{
    public class Taxasiva
    {

        //public taxasiva()
        //{
        //    ListaTaxasIva= new List<taxasiva>();
        //}

        public string Taxasivastamp { get; set; }
        public decimal Codigo { get; set; }
        public decimal Taxa { get; set; }
        public string Ousrinis { get; set; }
        public DateTime Ousrdata { get; set; }
        public string Ousrhora { get; set; }
        public string Usrinis { get; set; }
        public DateTime Usrdata { get; set; }
        public string Usrhora { get; set; }
        public bool Marcada { get; set; }
        //public virtual ICollection<taxasiva> ListaTaxasIva { get; set; } 
    }
}