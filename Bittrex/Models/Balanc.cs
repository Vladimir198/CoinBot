using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittrex.Models
{
    public class Balanc
    {
        public string Currency { get; set; }
        public double Balance { get; set; }
        public double Available { get; set; }
        public double Pending { get; set; }
        public string CryptoAddress { get; set; }
        public bool Requested { get; set; }
        public string Uuid { get; set; }
    }

    public class BalancesResponse: Response
    {
        public BalancesResponse()
        {
            result = new List<Balanc>();
        }
        public List<Balanc> result { get; set; }
    }

    public class BalanceResponse : Response
    {
        public BalanceResponse()
        {
            result = new Balanc();
        }
        public Balanc result { get; set; }
    }

}
