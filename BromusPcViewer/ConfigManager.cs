using Newtonsoft.Json;
using System;
using System.IO;

namespace BromusPcViewer
{
	public static class ConfigManager
	{
		static string configFilePath="config.json";

		private static ConfigData Data;

		private static bool init = false;

		public static void InitConfig()
		{
			try {
				string text = File.ReadAllText(configFilePath);
				Data = JsonConvert.DeserializeObject<ConfigData>(text);
			} catch (Exception err) {
				StatusDisplay.WriteError(err.Message);
				Data = new ConfigData();
			}
			init = true;
		}

		public static string LoadPasswordLocal() {
			if (!init) InitConfig();
			return Data.password_local;
		}

		public static string LoadPasswordRemote() {
			if (!init) InitConfig();
			return Data.password_remote;
		}

		public static void SavePasswordLocal(string pass)
		{
			if (!init) InitConfig();
			Data.password_local=pass;
			saveConfig();
		}

		public static void SavePasswordRemote(string pass)
		{
			if (!init) InitConfig();
			Data.password_remote = pass;
			saveConfig();
		}

		static private void saveConfig() {
			if (!init) InitConfig();
			string jsonString = JsonConvert.SerializeObject(Data);
			File.WriteAllText(configFilePath, jsonString);
		}

		class ConfigData
		{
			public string password_local { get; set; }
			public string password_remote { get; set; }
		}
	}

	
}