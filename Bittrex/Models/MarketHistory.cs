﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittrex.Models
{
    class MarketHistory
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public string FillType { get; set; }
        public string OrderType { get; set; }
    }
}
