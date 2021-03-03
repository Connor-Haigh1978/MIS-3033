using System;
using System.Collections.Generic;
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
        public SecondWindow()
        {
            InitializeComponent();

        }
        public void Image(ResultObject Pokemon)
        {
            PokemonName.Text = Pokemon.ToString();

            ImagePokemon.Source = new BitmapImage(new Uri(Pokemon.url));

        }
    }
}
