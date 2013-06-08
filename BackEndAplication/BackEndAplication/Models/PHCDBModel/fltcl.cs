using System;

namespace BackEndAplication.Models.PHCDBModel
{
    public class Fltcl
    {
        //public fltcl()
        //{
        //    Listafltcl= new List<fltcl>();
        //}

        public string Fltclstamp { get; set; }
        public string Ftitulo { get; set; }
        public string Texto { get; set; }
        public string Xbase { get; set; }
        public string Stamp { get; set; }
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
        //public virtual ICollection<fltcl> Listafltcl { get; set; }
    }
}