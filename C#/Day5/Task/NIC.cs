using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5SD43_Task
{
    internal class NIC
    {

        public string Manufacture { get; init; }
        public string MacAddress { get; init; }

        public type Type { get; init; }

        
        private NIC(string _man,string _mac,type _type)
        {

            Manufacture= _man;
            MacAddress= _mac;
            Type= _type;
        }
        public static NIC singleToneObj { get; } = new("intel", "00-44-55-66", type.Ethernet);


    }


    enum type
    {
        Ethernet,token_ring
    }
}
