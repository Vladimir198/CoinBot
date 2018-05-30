using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittrex.Models
{
    public class CurrencyAddress
    {
        public string Currency { get; set; }
        public string Address { get; set; }
    }

    public class CurrencyAddressResponse: Response
    {
        public CurrencyAddressResponse()
        {
            result = new CurrencyAddress();
        }

        CurrencyAddress result;
    }
}
