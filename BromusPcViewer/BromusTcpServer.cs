using System;
using System.Net;
using System.Net.Sockets;

namespace BromusPcViewer
{    
    internal class BromusTcpServer
    {
        TcpListener tcpListener;
        IPAddress ip;
        TcpClient client;
        int lastTcpMessageTime =0;
        int tcpTimeout = 100;

        int Port { get; set; }

        public BromusTcpServer(String ip, int Port) {
            this.Port = Port;
            this.ip = IPAddress.Parse(ip);
			tcpListener = new TcpListener(this.ip, Port);
		}

        public void StartServer() {
            
            tcpListener.Start();

			tcpListener.BeginAcceptTcpClient(new AsyncCallback(ClientAcceptedEvent), tcpListener);
            String[] animatedStatMess = { "Waiting for clients ◡◡", "Waiting for clients -  -", "Waiting for clients ⊙⊙", "Waiting for clients ⊙⊙", "Waiting for clients -  -" };

			StatusDisplay.WriteAnimatedStatus(animatedStatMess, 200);
        }

        private void ClientAcceptedEvent(IAsyncResult ar) {
            TcpListener listener = (TcpListener)ar.AsyncState;
            client = listener.EndAcceptTcpClient(ar);
			
			StatusDisplay.WriteStatus("Client accepted "+client.Client.RemoteEndPoint);
        }

        private void waitForClient() {
			tcpListener.BeginAcceptTcpClient(new AsyncCallback(ClientAcceptedEvent), tcpListener);
			StatusDisplay.WriteStatus("Waiting for clients");
		}
    }
}
