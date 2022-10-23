using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace BromusPcViewer
{
	public partial class GreetingWindow : Form
	{
		public GreetingWindow()
		{
			InitializeComponent();
		}

		private void GreetingWindow_Load(object sender, EventArgs e)
		{
			StatusDisplay.AssignLabelObj(statusLbl);

			List<String> ips = new List<String>();
			var host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (var ip in host.AddressList)
			{
				if (ip.AddressFamily == AddressFamily.InterNetwork)
				{
					ips.Add(ip.ToString());   
				}
			}
			localIplbl.Text="Your local IP: "+string.Join(" / ",ips);

			loacalPassTxt.Text = ConfigManager.LoadPasswordLocal();
		}

		private void connectBtn_Click(object sender, EventArgs e)
		{
			StatusDisplay.WriteStatus("connect click");
		}

		private void startHostBtn_Click(object sender, EventArgs e)
		{
			ConfigManager.SavePasswordLocal(loacalPassTxt.Text);

			Regex regexIpV4 = new Regex("^((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])$");
			MatchCollection regexIpV4Match = regexIpV4.Matches(localHostIpTxt.Text.Replace(" ", ""));

			Regex regexIpV6 = new Regex("^(([0-9a-fA-F]{1,4}:){7,7}[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,7}:|([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}|([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}|([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}|([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}|[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})|:((:[0-9a-fA-F]{1,4}){1,7}|:)|fe80:(:[0-9a-fA-F]{0,4}){0,4}%[0-9a-zA-Z]{1,}|::(ffff(:0{1,4}){0,1}:){0,1}((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])|([0-9a-fA-F]{1,4}:){1,4}:((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]))$"); ;
			MatchCollection regexIpV6Match = regexIpV6.Matches(localHostIpTxt.Text.Replace(" ", ""));

			Regex regexPort = new Regex("^()([1-9]|[1-5]?[0-9]{2,4}|6[1-4][0-9]{3}|65[1-4][0-9]{2}|655[1-2][0-9]|6553[1-5])$");
			MatchCollection regexPortMatch = regexPort.Matches(startHostPortTxt.Text.Replace(" ", ""));

			if (
				(localHostIpTxt.Text.Replace(" ","").Length != 0)
				&&
				(regexIpV4Match.Count == 0)
				&&
				(regexIpV6Match.Count == 0)
			)
			{
				StatusDisplay.WriteError("not a valid ip address "+ localHostIpTxt.Text.Replace(" ", ""));
				return;
			}

			if (regexPortMatch.Count == 0)
			{
				StatusDisplay.WriteError("not a valid port "+startHostPortTxt.Text.Replace(" ", ""));
				return;
			}

			String ip = "0.0.0.0";
			if (localHostIpTxt.Text.Replace(" ", "").Length != 0)
			{
				ip = localHostIpTxt.Text.Replace(" ", "");
			}

			BromusTcpServer server = new BromusTcpServer(ip,int.Parse(startHostPortTxt.Text.Replace(" ", "")));
			server.StartServer();
		}
	}
}
