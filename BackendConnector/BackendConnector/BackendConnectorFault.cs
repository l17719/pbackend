using System.Runtime.Serialization;

namespace BackendConnector
{
    [DataContract]
    public class BackendConnectorFault
    {
        [DataMember]
        public bool Result { get; set; }

        [DataMember]
        public string ErrorMessage { get; set; }

        [DataMember]
        public string ErrorDetails { get; set; }
    }
}