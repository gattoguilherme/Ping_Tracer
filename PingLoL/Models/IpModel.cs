using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingLoL.Models
{
    public class IpModel
    {
        public IpModel()
        {

        }

        public IpModel(string ip, string address, string roundtripTime)
        {
            Ip = ip;
            Address = address;
            RoundtripTime = roundtripTime;
        }

        public string Ip { get; set; }
        public string Address { get; set; }
        public string RoundtripTime { get; set; }
    }
}
