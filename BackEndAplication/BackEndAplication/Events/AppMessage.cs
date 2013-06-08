namespace BackEndAplication.Events
{
    public enum AppMessageType
    {
        InicioConfiguracao,
        RegistoApp,
        ConfigWebServer,
        InstallWebService,
        ServerConfig,
        FimConfiguracao,
        ListaTerminais
    }

    public class AppMessage
    {
        public AppMessage(AppMessageType appMessageType)
        {
            AppMessageType = appMessageType;
        }

        public AppMessageType AppMessageType { get; set; }
    }
}