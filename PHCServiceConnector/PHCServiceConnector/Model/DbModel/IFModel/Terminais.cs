using System;

namespace PHCServiceConnector.Model.DbModel.IFModel
{
    public class Terminais
    {
        public Guid IDTerminal { get; set; }
        public Guid FkIdot { get; set; }
        public string NumPda { get; set; }
        public string MacAddress3G { get; set; }
        public string MacAddressWireless { get; set; }
        public Guid TerminalAccessKey { get; set; }
        public virtual OpcoesTerminais ListaOpcoesTerminal { get; set; }
    }
}
