using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittrex.Models
{
    class MarketSummary
    {
        public string MarketName { get; set; }
        public double Higth { get; set; }
        public double Low { get; set; }
        public double Volume { get; set; }
        public double Last { get; set; }
        public double BaseVolume { get; set; }
        public DateTime TimeStamp { get; set; }
        public double Bid { get; set; }
        public double Ask { get; set; }
        public int OpenBuyOrders { get; set; }
        public int OpenSellOrders { get; set; }
        public double PrevDay { get; set; }
        public DateTime dateTime { get; set; }
        public string DisplayMarketName { get; set; }
    }
}
