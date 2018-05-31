using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittrex.Models
{
    public class CancelResponse: Response
    {
        public CancelResponse()
        {
            result = "";
        }
        public string result { get; set; }
    }
}
