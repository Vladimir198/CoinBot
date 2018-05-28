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
    using Properties;
    public static class BittrexApi
    {
        public static MarketResponse GetMarkets()
        {
            MarketResponse response;
            string path = Resources.GetmarketsPath;
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(path);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(MarketResponse));
            using (Stream stream = resp.GetResponseStream())
            {
                response = (MarketResponse)jsonFormatter.ReadObject(stream);
            }
            return response;
        }

        public static MarketSummaryResponse GetMarketSummary()
        {
            MarketSummaryResponse response;
            string path = Resources.GetmarketsummariesPath;
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(path);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(MarketSummaryResponse));
            using (Stream stream = resp.GetResponseStream())
            {
                response = (MarketSummaryResponse)jsonFormatter.ReadObject(stream);
            }
            return response;
        }

        public static CurrenciesResponse GetCurrencies()
        {
            CurrenciesResponse response;
            string path = Resources.GetcurrenciesPath;
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(path);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(CurrenciesResponse));
            using (Stream stream = resp.GetResponseStream())
            {
                response = (CurrenciesResponse)jsonFormatter.ReadObject(stream);
            }
            return response;
        }

        public static TikerResponse GetTicker(String mareket)
        {
            TikerResponse response;
            string path = Resources.GettickerPath + "?market=" + mareket;
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(path);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(TikerResponse));
            using (Stream stream = resp.GetResponseStream())
            {
                response = (TikerResponse)jsonFormatter.ReadObject(stream);
            }
            return response;
        }

        public static TikerSummaryResponse GetTickerSummary(String mareket)
        {
            TikerSummaryResponse response;
            string path = Resources. + "?market=" + mareket;
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(path);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(TikerSummaryResponse));
            using (Stream stream = resp.GetResponseStream())
            {
                response = (TikerSummaryResponse)jsonFormatter.ReadObject(stream);
            }
            return response;
        }
    }
}
