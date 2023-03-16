using OOpBasics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpBasic
{
    public class Student : Person
    {
        public string Course { get; set; }

        public long IndexNumber { get; set; }

        public List<Subject>Subjects { get; set; }

        public override string GetAddress()
        {
            return $"\nCity: {Address.City} \nState: {Address.State} \nZip: {Address.Zip}";
        }
    }
}
