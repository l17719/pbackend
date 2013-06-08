namespace BackEndAplication.Events
{
    public enum EventoTipo
    {
        ConfiguracaoServidor,
        ConfiguracaoSQL,
        Erro,
        RegistoAplicacao
    }

    public class EventoBackend
    {
        public EventoBackend(EventoTipo valueTipo, dynamic valueData)
        {
            TipoEvento = valueTipo;
            EventData = valueData;
        }

        public EventoTipo TipoEvento { get; set; }
        public dynamic EventData { get; set; }
    }
}