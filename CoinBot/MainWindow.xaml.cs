using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Bittrex.Models;
using Bittrex;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace CoinBot
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //coinsgrd.ItemsSource  = BittrexApi.GetMarketsAsync().GetAwaiter().GetResult().result;
            GetMarketAsync();
        }

        private async void GetMarketAsync()
        {
            List<Market> markets = new List<Market>();
            await Task.Run(async() =>
            {
                markets = (await BittrexApi.GetMarketsAsync()).result;
            });
            coinsgrd.ItemsSource = markets;
        }

        private void btnMarketSummary_Click(object sender, RoutedEventArgs e)
        {
            coinsgrd.ItemsSource = BittrexApi.GetMarketSummaries().result;
        }

        private void btnCurrenci_Click(object sender, RoutedEventArgs e)
        {
            coinsgrd.ItemsSource = BittrexApi.GetCurrencies().result;
        }

        private void btnTickers_Click(object sender, RoutedEventArgs e)
        {
            TikerResponse response = BittrexApi.GetTicker("btc-trx");
            if (response.success)
            {
                List<Tiker> list = new List<Tiker>();
                list.Add(response.result);
                coinsgrd.ItemsSource = list;
            }
            else
            {
                MessageBox.Show(response.message);
            }
        }

        private void btnTickerSummary_Click(object sender, RoutedEventArgs e)
        {
            MarketSummaryResponse response = BittrexApi.GetMarketSummary("btc-trx");
            if (response.success)
            {
                coinsgrd.ItemsSource = response.result;
            }
            else
            {
                MessageBox.Show(response.message);
            }
        }

        private void btnOrderbooks_Click(object sender, RoutedEventArgs e)
        {
            OrderbooksResponse response = BittrexApi.GetOrderbooks("btc-trx", OrderType.Both);
            if (response.success)
            {
                coinsgrd.ItemsSource = response.result.buy;
            }
            else
            {
                MessageBox.Show(response.message);
            }
        }

        private void btnHistory_Click(object sender, RoutedEventArgs e)
        {
            HistoryResponse response = BittrexApi.GetOrdersHistory("btc-trx");
            if (response.success)
            {
                coinsgrd.ItemsSource = response.result;
            }
            else
            {
                MessageBox.Show(response.message);
            }
        }
    }
}
