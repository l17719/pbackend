namespace BackEndAplication.Events
{
    public enum TipoEventoModal
    {
        Ok,
        Cancel
    }

    public class EventoModal
    {
        public EventoModal(TipoEventoModal value)
        {
            EventoSelected = value;
        }

        public TipoEventoModal EventoSelected { get; set; }
    }
}