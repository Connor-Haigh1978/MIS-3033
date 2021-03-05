using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _P_____Pokemon
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {

        IndividualPokemon api;
        public SecondWindow()
        {
            InitializeComponent();

        }
        public void Image(ResultObject Pokemon)
        {

            //IndividualPokemon api;
            
            string url = $"{Pokemon.url}";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;

                api = JsonConvert.DeserializeObject<IndividualPokemon>(json);

            }


            HeightBlockAnswer.Text = api.height;
            WeightBlockAnswer.Text = api.weight;
            NameBlock.Text = Pokemon.name;
            SpriteImage.Source = new BitmapImage(new Uri(api.sprites.front_default));



        }

        private void ChangeSprite_Click(object sender, RoutedEventArgs e)
        {
            string status = ChangeSprite.Content.ToString().ToLower();
            //IndividualPokemon api;
            switch (status)
            {
                
                case "change to back sprite":
                    SpriteImage.Source = new BitmapImage(new Uri(api.sprites.back_default));
                    ChangeSprite.Content = "change to front sprite";
                    break;
                case "change to front sprite":
                    SpriteImage.Source = new BitmapImage(new Uri(api.sprites.front_default));
                    ChangeSprite.Content = "change to back sprite";
                    break;



            }

        }
    }
}
