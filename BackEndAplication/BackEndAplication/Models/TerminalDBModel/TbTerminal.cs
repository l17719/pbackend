using System;


namespace BackEndAplication.Models.TerminalDBModel
{
    public class TbTerminal
    {
        public Guid IDTerminal { get; set; }
        public Guid FkIDOT { get; set; }
        public string NumPda { get; set; }
        public string MacAddress3G { get; set; }
        public string MacAddressWireless { get; set; }
        public Guid TerminalAccessKey { get; set; }
        public virtual TbOpcoesTerminal TbOpcoesTerminal { get; set; }
    }
}