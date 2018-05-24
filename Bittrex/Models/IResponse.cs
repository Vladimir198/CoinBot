using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittrex.Models
{
    public interface IResponse
    {
        bool success { get; set; }
	    string message { get; set; }
    }
}
