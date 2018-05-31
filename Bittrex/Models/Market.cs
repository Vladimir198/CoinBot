using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Bittrex.Models
{
    public class Market
    {
        public string MarketCurrency { get; set; }
        public string BaseCurrency { get; set; }
        public string MarketCurrencyLong { get; set; }
        public string BaseCurrencyLong { get; set; }
        public double MinTradeSize { get; set; }
        public string MarketName { get; set; }
        public bool IsActive { get; set; }
        public string Created { get; set; }
    }

    public class MarketResponse : Response
    {
        public List<Market> result { get; set; }

        public MarketResponse()
        {
            result = new List<Market>();
        }
    }
}
