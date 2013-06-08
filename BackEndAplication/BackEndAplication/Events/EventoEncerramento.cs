namespace BackEndAplication.Events
{
    public enum EventoSeleccionado
    {
        Sim,
        Nao
    }

    public class EventoEncerramento
    {
        public EventoEncerramento(EventoSeleccionado value)
        {
            Seleccionado = value;
        }

        public EventoSeleccionado Seleccionado { get; set; }
    }
}