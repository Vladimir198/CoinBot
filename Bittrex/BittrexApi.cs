using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Bittrex.Models;

namespace Bittrex
{
    using Properties;
    public static class BittrexApi
    {
        /// <summary>
        /// Отправляет запрос на сервер
        /// </summary>
        /// <param name="path">путь запроса</param>
        /// <param name="type">Тип объекта который ожидается получить</param>
        /// <returns>Обект который нужно привести к необходимиому типу</returns>
        static async Task<object> GetResponseAsync(string path, Type type)
        {
            object result;
            return await Task.Run(async()=> {
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(path);
                HttpWebResponse resp = (HttpWebResponse) await req.GetResponseAsync();
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(type);
                using (Stream stream = resp.GetResponseStream())
                {
                    result = jsonFormatter.ReadObject(stream);
                }
                Thread.Sleep(5000);
                return result;
            });
            
        }

        /// <summary>
        /// Отправляет запрос на сервер
        /// </summary>
        /// <param name="path">путь запроса</param>
        /// <param name="type">Тип объекта который ожидается получить</param>
        /// <returns>Обект который нужно привести к необходимиому типу</returns>
        static object GetResponse(string path, Type type)
        {
            object result;
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(path);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(type);
            using (Stream stream = resp.GetResponseStream())
            {
                result = jsonFormatter.ReadObject(stream);
            }
            Thread.Sleep(5000);
            return result;
        }

        #region Public API

        public static MarketResponse GetMarkets()
        {
            return (MarketResponse)GetResponse(Resources.GetmarketsPath, typeof(MarketResponse));
        }

        public static async Task<MarketResponse> GetMarketsAsync()
        {
            return (MarketResponse) await GetResponseAsync(Resources.GetmarketsPath, typeof(MarketResponse));
            
        }

        public static MarketSummariesResponse GetMarketSummaries()
        {
            return (MarketSummariesResponse)GetResponse(Resources.GetmarketsummariesPath, typeof(MarketSummariesResponse));
        }

        public static CurrenciesResponse GetCurrencies()
        {
            return (CurrenciesResponse)GetResponse(Resources.GetcurrenciesPath, typeof(CurrenciesResponse));
        }

        public static TikerResponse GetTicker(String mareket)
        {
            string path = Resources.GettickerPath + "?market=" + mareket;
            return (TikerResponse)GetResponse(path, typeof(TikerResponse));
        }

        public static MarketSummaryResponse GetMarketSummary(String mareket)
        {
            string path = Resources.GetmarketsummaryPath + "?market=" + mareket;
            return (MarketSummaryResponse)GetResponse(path, typeof(MarketSummaryResponse));
        }

        public static OrderbooksResponse GetOrderbooks(String mareket, OrderType type)
        {
            string path = Resources.GetorderbookPath + "?market=" + mareket + "&type=" + EnumOrderType.GetString(type);
            return (OrderbooksResponse)GetResponse(path, typeof(OrderbooksResponse));
        }

        public static HistoryResponse GetOrdersHistory(String mareket)
        {
            string path = Resources.GetmarkethistoryPath + "?market=" + mareket;
            return (HistoryResponse)GetResponse(path, typeof(HistoryResponse));
        }

        #endregion

        #region Marcet API

        public static BuySelResponse SetOrderLimit(string api_key ,string mareket, OrderType type, double quantity, double rate)
        {

            string path = (type == OrderType.Buy)? $"{Resources.BuylimitPath}?apikey={api_key}&market={mareket}&quantity={quantity}&rate={rate}":
                          (type == OrderType.Sell)? $"{Resources.SelllimitPath}?apikey={api_key}&market={mareket}&quantity={quantity}&rate={rate}": "";
            return (BuySelResponse)GetResponse(path, typeof(BuySelResponse));
        }

        public static CancelResponse CancelOrder(string api_key, string order_uuid)
        {
            string path = $"{Resources.CancelPath}?apikey={api_key}&uuid={order_uuid}";
            return (CancelResponse)GetResponse(path, typeof(CancelResponse));
        }

        public static OpenOrderResponse GetOpenOrders(string api_key, string market)
        {
            string path = $"{Resources.CancelPath}?apikey={api_key}&market={market}";
            return (OpenOrderResponse)GetResponse(path, typeof(OpenOrderResponse));
        }

        #endregion

        #region Account API

        public static BalancesResponse GetBalances(string api_key)
        {
            string path = $"{Resources.GetbalancesPath}?apikey={api_key}";
            return (BalancesResponse)GetResponse(path, typeof(BalancesResponse));
        }

        public static BalanceResponse GetBalance(string api_key, string market)
        {
            string path = $"{Resources.GetbalancesPath}?apikey={api_key}&market={market}";
            return (BalanceResponse)GetResponse(path, typeof(BalanceResponse));
        }

        #endregion
    }
}
