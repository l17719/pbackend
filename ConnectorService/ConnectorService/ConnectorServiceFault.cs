using System.Runtime.Serialization;

namespace ConnectorService
{
     [DataContract]
    public class ConnectorServiceFault
    {
        [DataMember]
        public string DataMessage { get; set; }

        [DataMember]
        public string DataDetails { get; set; }
    }
}