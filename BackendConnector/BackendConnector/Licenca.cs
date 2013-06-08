using System.Runtime.Serialization;

namespace BackendConnector
{
    [DataContract]
    public class Licenca
    {
        [DataMember]
        public string Mail { get; set; }
        [DataMember]
        public string ChaveSerial { get; set; }

        [DataMember]
        public bool IsValid { get; set; }
    }
}