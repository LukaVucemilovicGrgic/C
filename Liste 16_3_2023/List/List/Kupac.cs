using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Kupac :InfoKupca
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double OIB { get; set;}
        public Address Address { get; set; }
        public virtual string GetAddress()
        {
            return $"Address: {Address.City} {Address.State} {Address.Zip}";
        }
    }
}
