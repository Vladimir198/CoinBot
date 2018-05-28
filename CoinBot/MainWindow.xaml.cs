using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
            coinsgrd.ItemsSource = BittrexApi.GetMarkets().result;
        }

        private void btnMarketSummary_Click(object sender, RoutedEventArgs e)
        {
            coinsgrd.ItemsSource = BittrexApi.GetMarketSummary().result;
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
            } else
            {
                MessageBox.Show(response.message);
            }
        }

        private void btnTickerSummary_Click(object sender, RoutedEventArgs e)
        {
            TikerSummaryResponse response = BittrexApi.GetTickerSummary("btc-trx");
            if (response.success)
            {
                List<TikerSummary> list = new List<TikerSummary>();
                list.Add(response.Result);
                coinsgrd.ItemsSource = list;
            }
            else
            {
                MessageBox.Show(response.message);
            }
        }
    }
}
