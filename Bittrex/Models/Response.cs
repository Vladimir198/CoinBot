﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittrex.Models
{
    public abstract class Response
    {
        public bool success { get; set; }
	    public string message { get; set; }
    }
}
