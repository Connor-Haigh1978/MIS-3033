﻿using System;
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

namespace _P_____Rick_and_Morty
{
    /// <summary>
    /// Interaction logic for ImageWindow.xaml
    /// </summary>
    public partial class ImageWindow : Window
    {
        public ImageWindow()
        {
            InitializeComponent();
        }
        public void SetUpWindow(Character Character)
        {
            NameBox.Text = Character.ToString();
            CharacterImage.Source = new BitmapImage(new Uri(Character.image));

        }
    }
}
