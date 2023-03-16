using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public  abstract class Kupac :InfoKupca
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public string Ticket { get; set; }
        public virtual string GetAddress()
        {
            return $"Address: {Address.City} {Address.Street} {Address.Zip}";
        }
    }
}
