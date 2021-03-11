using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace _P_____GOT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void QuoteButton_Click(object sender, RoutedEventArgs e)
        {
            GOTApi api;

            using (var client = new HttpClient())
            {
                string url = "https://got-quotes.herokuapp.com/quotes";

                string JsonData = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<GOTApi>(JsonData);

                QuoteBox.Text = api.quote;

                PersonBox.Text = $"- {api.character}";

            }


        }
    }
}
