using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bittrex.Models
{
    public class MarketSummaryResponse: Response
    {
        public MarketSummaryResponse()
        {
            result = new List<MarketSummary>();
        }

        public List<MarketSummary> result { get; set; }
    }
}