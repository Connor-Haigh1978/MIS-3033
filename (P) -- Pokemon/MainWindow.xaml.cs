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

namespace _P_____Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            AllPokemonAPI api;

            string url = "https://pokeapi.co/api/v2/pokemon?limit=1200";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<AllPokemonAPI>(json);

            }

            foreach (var item in api.results.OrderBy(x => x.name).ToList())
            {
                CharacterList.Items.Add(item);

            }

        }

        private void CharacterList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //PokemonPicture.Source = new BitmapImage(new Uri(SelectedPokemon.url));
            SecondWindow NewWindow = new SecondWindow();
            Image ImageWindow = new Image();
            var SelectedPokemon = (ResultObject)CharacterList.SelectedItem;
            NewWindow.Image(SelectedPokemon);
            NewWindow.Show();

        }
    }
}
