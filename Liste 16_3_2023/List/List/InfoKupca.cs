using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public interface InfoKupca
    {
        int Age { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        Address Address { get; set; }

        string GetAddress();

    }
}
