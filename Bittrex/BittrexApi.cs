using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Bittrex.Models;

namespace Bittrex
{
    public static class BittrexApi
    {
        public  static IResponse  GetPublic(string path)
        {
            IResponse response;
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(path);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(MarketResponse));
            using (Stream stream = resp.GetResponseStream())
            {
                response = (MarketResponse)jsonFormatter.ReadObject(stream);
            }
            return response;
        }
    }
}
