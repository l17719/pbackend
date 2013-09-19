using System.Runtime.Serialization;

namespace PHCServiceConnector.Model.FaultVo
{
    [DataContract]
    public class ConnectorServiceFault
    {
        [DataMember(Order = 0, EmitDefaultValue = true, IsRequired = true, Name = "Mensagem")]
        public string DataDetails { get; set; }
        [DataMember(Order = 1,EmitDefaultValue = true,IsRequired = true,Name = "Detalhes")]
        public string DataMessage { get; set; }
    }
}