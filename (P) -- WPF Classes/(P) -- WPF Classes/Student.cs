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

        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Major = string.Empty;
            GPA = -1;
            Address = new Address();
        }
        public Student(string firstName, string lastName, string major, double gpa)
        {
            firstName = FirstName;
            lastName = LastName;
            major = Major;
            gpa = GPA;
        }
        public string CalculateDistinction()
        {
            string Distinction;
            if (GPA >= 3.80)
            {
                Distinction = "Summa Cum Laude";
            }
            if (GPA >= 3.6)
            {
                Distinction = "Magna Cum Laude";
            }
            if (GPA >= 3.4)
            {
                Distinction = "Cum Laude";
            }
            else
            {
                Distinction = "No Distinction";
            }

            return Distinction;
        }
        public void SetAddress(int streetNumber, string streetName, string state, string city, int zipcode)
        {
            Address = new Address(streetNumber, streetName, state, city, zipcode);

            Address.StreetNumber = streetNumber;
            Address.StreetName = streetName;
            Address.State = state;
            Address.City = city;
            Address.ZipCode = zipcode;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Major}, {CalculateDistinction()}"; 
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
        public Address(int streetnumber, string streetname, string state, string city, int zipcode)
        {
            streetnumber = StreetNumber;
            streetname = StreetName;
            state = State;
            city = City;
            zipcode = ZipCode;
        }
        public override string ToString()
        {
            return $"{StreetNumber}, {StreetName}, {State}, {City}, {ZipCode}";
        }
    }
}
