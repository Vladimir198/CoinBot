using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Bittrex.Models
{
    [DataContract]
    public class Market
    {
        [DataMember]
        public string MarketCurrency { get; set; }
        [DataMember]
        public string BaseCurrency { get; set; }
        [DataMember]
        public string MarketCurrencyLong { get; set; }
        [DataMember]
        public string BaseCurrencyLong { get; set; }
        [DataMember]
        public double MinTradeSize { get; set; }
        [DataMember]
        public string MarketName { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
        [DataMember]
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
