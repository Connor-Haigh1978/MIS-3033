using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace _P_____WPF_Classes
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

        private void SubmitInfor_Click(object sender, RoutedEventArgs e)
        {
            double GPA;
            Student NewStudent = new Student()
            {
                FirstName = FirstNameBox.Text,
                LastName = LastNameBox.Text,
                GPA = Convert.ToDouble(GPABox.Text),
                Major = MajorBox.Text
            };

            NewStudent.SetAddress(Convert.ToInt32(streetNumberBox.Text), streetNameBox.Text, stateBox.Text, cityBox.Text, Convert.ToInt32(ZipcodeBox.Text));

            cityBox.Clear();
            FirstNameBox.Clear();
            LastNameBox.Clear();
            GPABox.Clear();
            MajorBox.Clear();
            stateBox.Clear();
            streetNameBox.Clear();
            streetNumberBox.Clear();
            ZipcodeBox.Clear();

            StudentListBox.Items.Add(NewStudent);
            //List<Address> addresses = new List<Address>();

            //int streetNumber, string streetName, string state, string city, int zipcode


        }

        private void StudentListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedStudent = (Student)StudentListBox.SelectedItem;
            var selectedAddress = (Address);
            MessageBox.Show($"Nice job! {selectedStudent.Address}");
        }
    }
}
