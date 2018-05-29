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
        #region Public API

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

        public static MarketSummariesResponse GetMarketSummaries()
        {
            MarketSummariesResponse response;
            string path = Resources.GetmarketsummariesPath;
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(path);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(MarketSummariesResponse));
            using (Stream stream = resp.GetResponseStream())
            {
                response = (MarketSummariesResponse)jsonFormatter.ReadObject(stream);
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

        public static MarketSummaryResponse GetMarketSummary(String mareket)
        {
            MarketSummaryResponse response;
            string path = Resources.GetmarketsummaryPath + "?market=" + mareket;
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(path);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(MarketSummaryResponse));
            using (Stream stream = resp.GetResponseStream())
            {
                response = (MarketSummaryResponse)jsonFormatter.ReadObject(stream);
            }
            return response;
        }

        public static OrderbooksResponse GetOrderbooks(String mareket, OrderType type)
        {
            OrderbooksResponse response;
            
            string path = Resources.GetorderbookPath + "?market=" + mareket + "&type=" + EnumOrderType.GetString(type);
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(path);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(OrderbooksResponse));
            using (Stream stream = resp.GetResponseStream())
            {
                response = (OrderbooksResponse)jsonFormatter.ReadObject(stream);
            }
            return response;
        }

        public static HistoryResponse GetOrdersHistory(String mareket)
        {
            HistoryResponse response;

            string path = Resources.GetmarkethistoryPath + "?market=" + mareket;
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(path);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(HistoryResponse));
            using (Stream stream = resp.GetResponseStream())
            {
                response = (HistoryResponse)jsonFormatter.ReadObject(stream);
            }
            return response;
        }

        #endregion

        #region Marcet API

        public static BuySellResult SetOrderLimit(string api_key ,string mareket, OrderType type, double quantity, double rate)
        {
            BuySellResult response;

            string path = (type == OrderType.Buy)? $"{Resources.BuylimitPath}?apikey={api_key}&market={mareket}&quantity={quantity}&rate={rate}":
                          (type == OrderType.Sell)? $"{Resources.SelllimitPath}?apikey={api_key}&market={mareket}&quantity={quantity}&rate={rate}": "";
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(path);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(BuySellResult));
            using (Stream stream = resp.GetResponseStream())
            {
                response = (BuySellResult)jsonFormatter.ReadObject(stream);
            }
            return response;
        }


        public static CancelResponse CancelOrder(string api_key, string order_uuid)
        {
            CancelResponse response;

            string path = $"{Resources.CancelPath}?apikey={api_key}&uuid={order_uuid}";
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(path);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(CancelResponse));
            using (Stream stream = resp.GetResponseStream())
            {
                response = (CancelResponse)jsonFormatter.ReadObject(stream);
            }
            return response;
        }

        public static OpenOrderResponse GetOpenOrders(string api_key, string market)
        {
            OpenOrderResponse response;

            string path = $"{Resources.CancelPath}?apikey={api_key}&market={market}";
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(path);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(OpenOrderResponse));
            using (Stream stream = resp.GetResponseStream())
            {
                response = (OpenOrderResponse)jsonFormatter.ReadObject(stream);
            }
            return response;
        }

        #endregion

        #region Account API

        public static BalancesResponse GetBalances(string api_key)
        {
            BalancesResponse response;

            string path = $"{Resources.GetbalancesPath}?apikey={api_key}";
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(path);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(BalancesResponse));
            using (Stream stream = resp.GetResponseStream())
            {
                response = (BalancesResponse)jsonFormatter.ReadObject(stream);
            }
            return response;
        }

        public static BalanceResponse GetBalance(string api_key, string market)
        {
            BalanceResponse response;

            string path = $"{Resources.GetbalancesPath}?apikey={api_key}&market={market}";
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(path);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(BalanceResponse));
            using (Stream stream = resp.GetResponseStream())
            {
                response = (BalanceResponse)jsonFormatter.ReadObject(stream);
            }
            return response;
        }

        #endregion
    }
}
