using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittrex.Models
{
    public class Tiker
    {
        public double Bid { get; set; }
        public double Ask { get; set; }
        public double Last { get; set; }
    }

    public class TikerResponse : Response
    {
        public TikerResponse()
        {
            result = new Tiker();
        }
        public Tiker result { get; set; }
    }
}
