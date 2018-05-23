using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Bittrex.Models
{
    [DataContract]
    public class MarketResponse : IResponse
    {
        [DataMember]
        public bool success { get; set; }
        [DataMember]
        public string message { get; set; }
        [DataMember]
        public List<Market> result { get; set; }

        public MarketResponse()
        {
            result = new List<Market>();
        }
    }
}
