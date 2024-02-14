using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _15._3._3
{
     class Contact
    {

        public Contact (string name , long phoneNumber , string email)
        {
            Name = name;
            PhoneNuber = phoneNumber;
            EMail = email;
        }
        public string Name { get; set; }
        public long PhoneNuber { get; set; }
        public string EMail { get; set; }
    }
}
