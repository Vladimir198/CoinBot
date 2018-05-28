using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Bittrex.Models
{
    public class CurrenciesResponse : Response
    {
        public CurrenciesResponse()
        {
            result = new List<CoinCurrency>();
        }

        public List<CoinCurrency> result { get; set; }
    }
}