using System;
using System.Collections.Generic;
using System.Text;

namespace _P_____WPF_Classes
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; } 
        public Address Address { get; set; } 

        Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Major = string.Empty;
            GPA = -1;
            Address = new Address();
        }


    }

    public class Address
    {
        public int StreetNumber {get; set;}
        public string StreetName { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }


        public Address()
        {
            StreetNumber = 0;
            StreetName = string.Empty;
            State = string.Empty;
            City = string.Empty;
            ZipCode = 0;
        }
    }
}
