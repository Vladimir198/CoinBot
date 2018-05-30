using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittrex.Models
{
    public class CoinCurrency
    {
        public string Currency {get; set; }
        public string CurrencyLong { get; set; }
        public double MinConfirmation { get; set; }
        public double TxFee { get; set; }
        public bool IsActive { get; set; }
        public string CoinType { get; set; }
        public string BaseAddress { get; set; }
    }

    public class CurrenciesResponse : Response
    {
        public CurrenciesResponse()
        {
            result = new List<CoinCurrency>();
        }

        public List<CoinCurrency> result { get; set; }
    }
}
