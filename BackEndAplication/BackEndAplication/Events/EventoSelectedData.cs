using BackEndAplication.Models.TerminalDBModel;

namespace BackEndAplication.Events
{
    public enum TipoSelected
    {
        TerminalDataSelected,
        PhcDataSelected
    }

    public class EventoSelectedData
    {
        public EventoSelectedData(TipoSelected valueSelectedItem, TbTerminal valueTerm = null,
                                  TbOpcoesTerminal valueOp = null)
        {
            TipoSelectedItem = valueSelectedItem;
            SelectedDataOpcoes = valueOp;
            SelectedDataTerminal = valueTerm;
        }

        public TipoSelected TipoSelectedItem { get; set; }
        public TbTerminal SelectedDataTerminal { get; set; }
        public TbOpcoesTerminal SelectedDataOpcoes { get; set; }
    }
}