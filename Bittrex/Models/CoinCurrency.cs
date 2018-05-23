using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittrex.Models
{
    class CoinCurrency
    {
        public string Currency {get; set; }
        public string CurrencyLong { get; set; }
        public double MinConfirmation { get; set; }
        public double TxFee { get; set; }
        public bool IsActive { get; set; }
        public string CoinType { get; set; }
        public string BaseAddress { get; set; }
    }
}
