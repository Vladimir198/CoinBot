using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittrex.Models
{
    public class MarketHistory
    {
        public int Id { get; set; }
        public string TimeStamp { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public string FillType { get; set; }
        public string OrderType { get; set; }
    }

    public class HistoryResponse : Response
    {
        public HistoryResponse()
        {
            result = new List<MarketHistory>();
        }

        public List<MarketHistory> result { get; set; }
    }
}
