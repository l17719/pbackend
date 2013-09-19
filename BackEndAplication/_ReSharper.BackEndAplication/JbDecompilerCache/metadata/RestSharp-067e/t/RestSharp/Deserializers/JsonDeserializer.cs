// Type: RestSharp.Deserializers.JsonDeserializer
// Assembly: RestSharp, Version=104.1.0.0, Culture=neutral, PublicKeyToken=null
// Assembly location: C:\Users\joao\Dropbox\ifelse\source\bibliotecas\RestSharp10.4\RestSharp.dll

using RestSharp;
using System.Globalization;

namespace RestSharp.Deserializers
{
    public class JsonDeserializer : IDeserializer
    {
        public T Deserialize<T>(IRestResponse response);
        public string RootElement { get; set; }
        public string Namespace { get; set; }
        public string DateFormat { get; set; }
        public CultureInfo Culture { get; set; }
    }
}
