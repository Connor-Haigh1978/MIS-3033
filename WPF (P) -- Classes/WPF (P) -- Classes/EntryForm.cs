using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF__P_____Classes
{
    class EntryForm
    {
        public string Name {get; set;}
        public string Address { get; set; }
        public int ZipCode { get; set; }
        
        public EntryForm()
        {
            Name = String.Empty;
            Address = String.Empty;
            ZipCode = 0;
        }
        EntryForm(string name, string address, int zipCode)
        {
            name = Name;
            address = Address;
            zipCode = ZipCode;
        }

        public override string ToString()
        {
            return $"name: {Name}, address: {Address}, ZipCode: {ZipCode}";
        }
    }
}
