using System.Collections.Generic;
using ConnectorService.Model.PHCModel.VODadosPHC;
using Newtonsoft.Json;

namespace ConnectorService.Model.PHCModel
{
    public class RootElement
    {
        [JsonProperty("DADOSBI")]
        public IList<VoBi> VoBiList { get; set; }

        [JsonProperty("DADOSBO")]
        public IList<Vobo> VoBoList { get; set; }

       
    }
}
