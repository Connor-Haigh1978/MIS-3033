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
            bool Success;
            int streetnumber;
            if (int.TryParse(streetNumberBox.Text, out streetnumber) == false)
            {
                Success = false;
                MessageBox.Show("Enter a valid Street Number");
            }
            int Zip;
            if (int.TryParse(ZipcodeBox.Text, out Zip) == false)
            {
                Success = false;
                MessageBox.Show("Enter valid Zip Code");



            }

            Student NewStudent = new Student()
            {
                FirstName = FirstNameBox.Text,
                LastName = LastNameBox.Text,
                GPA = Convert.ToDouble(GPABox.Text),
                Major = MajorBox.Text
            };
            Address StudentAddress = new Address()
            {
                StreetNumber = streetnumber,
                StreetName = streetNameBox.Text,
                State = stateBox.Text,
                City = cityBox.Text,
                ZipCode = Zip
            };
            NewStudent.SetAddress(
                streetnumber,
                streetNameBox.Text,
                stateBox.Text,
                cityBox.Text,
                Zip
                );
            cityBox.Clear();
            FirstNameBox.Clear();
            LastNameBox.Clear();
            GPABox.Clear();
            MajorBox.Clear();
            stateBox.Clear();
            streetNameBox.Clear();
            streetNumberBox.Clear();
            ZipcodeBox.Clear();

            //Address NewStudentAddress = new Address();
            //{
            //    NewStudentAddress.StreetNumber = streetnumber;
            //    NewStudentAddress.StreetName = streetNameBox.Text;
            //    NewStudentAddress.State = stateBox.Text;
            //    NewStudentAddress.City = cityBox.Text;
            //    NewStudentAddress.ZipCode = Zip;

            //}
            ////NewStudentAddress(streetnumber, streetNameBox.Text, stateBox.Text, cityBox.Text, Zip);
            //NewStudent.SetAddress(NewStudentAddress);
            
            StudentListBox.Items.Add(NewStudent);
          

        }

        private void StudentListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedStudent = (Student)StudentListBox.SelectedItem;
           // var selectedAddress = (Address);
            MessageBox.Show($"Nice job! {selectedStudent}");
            ShowAddress address = new ShowAddress();
            Address NewAddress = new Address();
            NewAddress = selectedStudent.Address;
            address.Setup(selectedStudent);
            address.ShowAddressStudent(NewAddress);
            address.Show();
        }
    }
}
