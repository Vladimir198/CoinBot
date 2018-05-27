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
        public  static IResponse  GetData(string path, Type type)
        {
            IResponse response;
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(path);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(type);
            using (Stream stream = resp.GetResponseStream())
            {
                response = (MarketResponse)jsonFormatter.ReadObject(stream);
            }
            return response;
        }
    }
}
