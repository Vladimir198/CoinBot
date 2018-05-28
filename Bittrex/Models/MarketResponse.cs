using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Bittrex.Models
{
    public class MarketResponse : Response
    {
        public List<Market> result { get; set; }

        public MarketResponse()
        {
            result = new List<Market>();
        }
    }
}
