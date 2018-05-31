using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittrex.Models
{
    public class Orderbook
    {
        public double Quantity { get; set; }
        public double Rate { get; set; }
    }

    public class OrederbooksResult
    {
        public List<Orderbook> buy { get; set; }
        public List<Orderbook> sell { get; set; }
    }

    public class OrderbooksResponse : Response
    {
        public OrderbooksResponse()
        {
            result = new OrederbooksResult();
        }

        public OrederbooksResult result { get; set; }
    }
}
