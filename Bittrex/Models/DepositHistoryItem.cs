using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittrex.Models
{
    public class DepositHistoryItem
    {
        public string PaymentUuid { get; set; }
        public string Currency { get; set; }
        public double Amount { get; set; }
        public string Address { get; set; }
        public string Opened { get; set; }
        public bool Authorized { get; set; }
        public bool PendingPayment { get; set; }
        public double TxCost { get; set; }
        public string TxId { get; set; }
        public bool Canceled { get; set; }
        public bool InvalidAddress { get; set; }
    }

    public class DepositHistoryResponce
    {
        public DepositHistoryResponce()
        {
            result = new List<DepositHistoryItem>();
        }
        public List<DepositHistoryItem> result { get; set; }
    }
}
