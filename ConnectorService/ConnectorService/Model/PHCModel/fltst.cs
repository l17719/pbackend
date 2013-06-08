using System;

namespace ConnectorService.Model.PHCModel
{
    public class Fltst
    {
        //public fltst()
        //{
        //    ListaFiltrosStocks= new List<fltst>();
        //}

        public string Fltststamp { get; set; }
        public string Ftitulo { get; set; }
        public string Texto { get; set; }
        public string Xbase { get; set; }
        public string FStStamp { get; set; }
        public bool Temvar { get; set; }
        public bool Privado { get; set; }
        public bool Altera { get; set; }
        public string Ousrinis { get; set; }
        public DateTime Ousrdata { get; set; }
        public string Ousrhora { get; set; }
        public string Usrinis { get; set; }
        public DateTime Usrdata { get; set; }
        public string Usrhora { get; set; }
        public bool Marcada { get; set; }

        //public virtual ICollection<fltst> ListaFiltrosStocks { get; set; }
    }
}