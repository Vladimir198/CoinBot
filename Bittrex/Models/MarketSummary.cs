using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittrex.Models
{
    public class MarketSummary: Tiker
    {
        public string MarketName { get; set; }
        public double Higth { get; set; }
        public double Low { get; set; }
        public double Volume { get; set; }
        public double BaseVolume { get; set; }
        public string TimeStamp { get; set; }
        public int OpenBuyOrders { get; set; }
        public int OpenSellOrders { get; set; }
        public double PrevDay { get; set; }
        public string DateTime { get; set; }
        public string DisplayMarketName { get; set; }
    }

    public class MarketSummaryResponse : Response
    {
        public MarketSummaryResponse()
        {
            result = new List<MarketSummary>();
        }
        public List<MarketSummary> result { get; set; }
    }

    public class MarketSummariesResponse : Response
    {
        public MarketSummariesResponse()
        {
            result = new List<MarketSummary>();
        }

        public List<MarketSummary> result { get; set; }
    }
}
