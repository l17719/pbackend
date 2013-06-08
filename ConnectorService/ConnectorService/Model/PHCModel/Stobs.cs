using System;

namespace ConnectorService.Model.PHCModel
{
    public class Stobs
    {
        public string Stobsstamp { get; set; }
        public string StobsRef { get; set; }
        public string StobsObs { get; set; }
        public string Ousrinis { get; set; }
        public DateTime Ousrdata { get; set; }
        public string Ousrhora { get; set; }
        public string Usrinis { get; set; }
        public DateTime Usrdata { get; set; }
        public string Usrhora { get; set; }
        public bool Marcada { get; set; }
        public string Docdescription { get; set; }
        public bool Lepeso { get; set; }
        public bool Precotouch { get; set; }
        public decimal Pvverificador { get; set; }
        public bool Objusacor { get; set; }
        public decimal Objcolor { get; set; }
        public bool Objusacortit { get; set; }
        public bool Objusacorval { get; set; }
        public decimal Objcorval { get; set; }
        public bool Objusacortec { get; set; }
        public decimal Objcortec { get; set; }
        public bool Objmudafonte { get; set; }
        public string Btnfont { get; set; }
        public decimal Btnfontsize { get; set; }
        public bool Btnfontbold { get; set; }
        public bool Btnfontitalic { get; set; }
        public decimal Objcortit { get; set; }
        public string Txtord { get; set; }
        public bool Usafefo { get; set; }
        public string Motiseimp { get; set; }
        public string Codmotiseimp { get; set; }
    }
}
