using BackEndAplication.Models.TerminalDBModel;

namespace BackEndAplication.Events
{
    public enum AccaoEfectuada
    {
        AddTerminalData,
        UpdateTerminalData,
        AddPhcData,
        UpdatePhcData,
        AddedTerminalData,
        AddedPhcData,
        UpdatedTerminalData,
        UpdatedPhcData,
        Cancel
    }

    public class EventoChangeActiveViewTerminal
    {
        public EventoChangeActiveViewTerminal(AccaoEfectuada valueAccao, TbTerminal valueData = null,
                                              TbOpcoesTerminal valueDadosOp = null)
        {
            EventoDataTerminal = valueData;
            EventoDataOpcoes = valueDadosOp;
            TipoAccao = valueAccao;
        }

        public TbTerminal EventoDataTerminal { get; set; }
        public TbOpcoesTerminal EventoDataOpcoes { get; set; }
        public AccaoEfectuada TipoAccao { get; set; }
    }
}