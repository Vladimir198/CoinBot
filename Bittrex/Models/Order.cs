using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittrex.Models
{
    public class Order
    {
        public int AccountId { get; set; }
        public string OrderUuid { get; set; }
        public string Exchange { get; set; }
        public string Type { get; set; }
        public double Quantity { get; set; }
        public double QuantityRemaining { get; set; }
        public double Limit { get; set; }
        public double Reserved { get; set; }
        public double ReserveRemaining { get; set; }
        public double CommissionReserved { get; set; }
        public double CommissionReserveRemaining { get; set; }
        public double CommissionPaid { get; set; }
        public double Price { get; set; }
        public double PricePerUnit { get; set; }
        public string Opened { get; set; }
        public string Closed { get; set; }
        public bool IsOpen { get; set; }
        public string Sentinel { get; set; }
        public bool CancelInitiated { get; set; }
        public bool ImmediateOrCancel { get; set; }
        public bool IsConditional { get; set; }
        public string Condition { get; set; }
        public string ConditionTarget { get; set; }
    }
    public class OrderResponse: Response
    {
        public OrderResponse()
        {
            result = new Order();
        }
        Order result;
    }
}
