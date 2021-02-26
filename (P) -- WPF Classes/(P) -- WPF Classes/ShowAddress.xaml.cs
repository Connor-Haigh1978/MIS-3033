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

namespace _P_____WPF_Classes
{
    /// <summary>
    /// Interaction logic for ShowAddress.xaml
    /// </summary>
    public partial class ShowAddress : Window
    {
        //public Student student { get; set; }
        
        public ShowAddress()
        {
            InitializeComponent();
        }

        public void Setup(Student student)
        {
            string name = student.FirstName + " " + student.LastName;
            FLBox.Text = name;
        }
        public void ShowAddressStudent(Address address)
        {
            AddressBlock.Text = address.ToString();


        }
    }
}
