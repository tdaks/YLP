using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace 서버_개발
{
    class Manager
    {
        static Manager singleton = null;
        NetworkServer ns = null;

        public static Manager Singleton
        {
            get
            {
                return Singleton;
            }
        }

        private Manager() { }
        static Manager()
        {
            singleton = new Manager();
        }

        public string MyIP
        {
            get
            {
                string host_name = Dns.GetHostName();
                IPHostEntry host_entry = Dns.GetHostEntry(host_name);

                foreach (IPAddress ipaddr in host_entry.AddressList)
                {
                    if (ipaddr.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return ipaddr.ToString();
                    }
                }
                return string.Empty;
            }
        }

        public void StartCommunicateMobile()
        {
            ns = new NetworkServer(MyIP, Define.Port);
        }
    }
}
