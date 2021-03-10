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

namespace _P_____ChuckNorisJoke
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string url = "https://api.chucknorris.io/jokes/categories";
            FillComboBox(url);

        }

        private void FillComboBox(string url)
        {
            using (var client = new HttpClient())
            {
                CategoryBox.Items.Add("All");
                List<string> JsonData = new List<string>();

                JsonData.Add(client.GetStringAsync(url).Result);

                foreach (var item in JsonData)
                {
                    var items = item.Split(',');
                    foreach (var Category in items)
                    {
                        CategoryBox.Items.Add(Category.Trim('"', '[', ']'));
                    }
                }

            }
        }

        private void CategoryBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selection = CategoryBox.SelectedValue.ToString();
            string url;
            if (selection.ToUpper() == "ALL")
            {
                url = "https://api.chucknorris.io/jokes/random";
            }
            else
            {
                url = $"https://api.chucknorris.io/jokes/random?category={selection}";
            }
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                JokeAPI api = JsonConvert.DeserializeObject<JokeAPI>(json);

                JokeBox.Text = api.ToString();

            }
        }
    }
}
