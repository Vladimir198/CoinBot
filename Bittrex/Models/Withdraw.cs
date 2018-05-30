using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittrex.Models
{
    public class Withdraw
    {
        public string uuid { get; set; }
    }

    public class WithdrawResponse: Response
    {
        public WithdrawResponse()
        {
            result = new Withdraw();
        }

        Withdraw result;
    }
}
