using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace 서버_개발
{
    class NetworkServer
    {
        TcpListener CommunicateMobileServer;

        public NetworkServer(string ip, int port)
        {
            IPAddress ipaddr = IPAddress.Parse(ip);
            CommunicateMobileServer = new TcpListener(ipaddr, port);

            CommunicateMobileServer.Start();
            CommunicateMobileServer.BeginAcceptSocket(new AsyncCallback(DoAcceptSocketCallback), CommunicateMobileServer);
        }

        private void DoAcceptSocketCallback(IAsyncResult ar)
        {
            TcpListener tcplistener = (TcpListener)ar.AsyncState;
            Socket clientSocket = tcplistener.EndAcceptSocket(ar);


        }
    }
}
