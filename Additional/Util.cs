using System;
using System.Net;
using IniParser;
using IniParser.Model;

namespace After_Test.Additional {
	public class Util {
		public IPAddress[] ipadrlist;
		public string[] checkList;
		public string database;
		public bool isSerctFree;
		public IniData config;

		public Util () {
			var parse = new FileIniDataParser();
			config = parse.ReadFile(Environment.CurrentDirectory + @"\config\config.ini");
			var hostName = Dns.GetHostName();
			ipadrlist = Dns.GetHostAddresses(hostName);
			isSerctFree = false;
			checkList = config[ "config" ][ "ipArr" ].Split(',');
			////获取MAC地址
			//var nwInterface = NetworkInterface.GetAllNetworkInterfaces();
			//foreach ( var n in nwInterface ) {
			//	var MACBytes = n.GetPhysicalAddress().GetAddressBytes();
			//	var MAC = BitConverter.ToString(MACBytes);
			//	MAC = MAC.Replace('-', ':');
			//}

		}



		public bool CheckIpInList() {
			foreach ( var ip in ipadrlist ) {
				if ( Array.IndexOf(checkList, ip.ToString()) > -1 ) {
					isSerctFree = true;
					return false;
					//TODO
					//return true;
				}
			}
			isSerctFree = false;
			return false;
		}
	}
}
