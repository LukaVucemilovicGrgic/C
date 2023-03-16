using OOpBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OOpBasics
{
    public abstract class Person : IPerson
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        protected string OIB { get; set; }
        public virtual string GetAddress()
        {
            return $"Address: {Address.City} {Address.State} {Address.Zip}";
        }

    }
}