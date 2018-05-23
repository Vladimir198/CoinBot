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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace CoinBot
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MarketResponse response;
       
       public MainWindow()
        {
            InitializeComponent();
            response = new MarketResponse();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string site = "https://bittrex.com/api/v1.1/public/getmarkets";
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(site);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(MarketResponse));
            using (Stream stream = resp.GetResponseStream())
            {
                response = (MarketResponse)jsonFormatter.ReadObject(stream);
            }
            coinsgrd.ItemsSource = response.result;

        }
    }
}
