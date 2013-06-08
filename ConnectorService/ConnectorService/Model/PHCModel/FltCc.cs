using System;

namespace ConnectorService.Model.PHCModel
{
    public class FltCc
    {
        public string Fltccstamp { get; set; }
        public string Ftitulo { get; set; }
        public string Texto { get; set; }
        public string Xbase { get; set; }
        public string StampFltCc { get; set; }
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
    }
}