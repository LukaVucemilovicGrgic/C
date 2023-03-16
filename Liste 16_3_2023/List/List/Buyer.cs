using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Buyer : Kupac
    {
        protected double OIB { get; set; }

        public override string GetAddress()
        {
            return $"Address: {Address.City} {Address.Street} {Address.Zip}";
        }
    }
}
