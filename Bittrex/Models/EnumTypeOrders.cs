
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bittrex.Models
{
    public enum OrderType
    {
        Buy,
        Sell,
        Both
    }

    public static class EnumOrderType
    {
        public static string GetString(OrderType ot)
        {
            string result = "";
            switch (ot)
            {
                case OrderType.Buy: result = "buy";
                    break;
                case OrderType.Sell: result = "sell";
                    break;
                case OrderType.Both: result = "both";
                    break;
                default:
                    break;
            }
            return result;
        }

        public static OrderType GetOrderType(string ots)
        {
            ots = ots.Trim().ToLower();
            OrderType result = OrderType.Both;
            switch (ots)
            {
                case "buy":  result = OrderType.Buy; 
                    break;
                case "sell":
                    result = OrderType.Sell;
                    break;
            }
            return result;
        }
    }
}