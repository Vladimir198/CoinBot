using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bittrex.Models
{
    public class MarketSumaryResponse: IResponse
    {
        public MarketSumaryResponse()
        {
            result = new List<MarketSummary>();
        }

        public List<MarketSummary> result { get; set; }
        public bool success { get; set; }
        public string message { get; set; }
    }
}