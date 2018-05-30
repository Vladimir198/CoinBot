using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittrex.Models
{
    public class BuySellResult
    {
        string uuid;
    }
    public class BuySelResponse: Response
    {
        public BuySelResponse()
        {
            result = new BuySellResult();
        }
        public BuySellResult result { get; set; }
    }
}
