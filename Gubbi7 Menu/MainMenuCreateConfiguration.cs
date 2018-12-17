using Smart_Menu;
using System;
using System.Collections.Generic;

namespace Gubbi7_Menu
{
	struct ConfigurationData {
		public string name;
		public DateTime startTime;
		public DateTime endTime;
		public TimeSpan interval;
		public List<string> dataTypes;
		public bool realativeTime;
	}
	internal class MainMenuCreateConfiguration : IMenuPoint
	{

		public MainMenuCreateConfiguration()
		{
		}

		public string GetMenuPointName()
		{
			return "Ny konfiguration";
		}

		public void Invoke()
		{
			ConfigurationData config = new ConfigurationData();
			Console.WriteLine("Indfør konfiguration navn");
			config.name = Console.ReadLine();
			Console.WriteLine("Indfør start dato, format: MM-dd-yyyy");
			config.startTime = DateTime.Parse(Console.ReadLine());
			Console.WriteLine("Indfør slut dato, format: MM-dd-yyyy");
			config.endTime = DateTime.Parse(Console.ReadLine());
			Console.WriteLine("Indfør interval tid, format: d.tt:mm:ss");
			config.interval = TimeSpan.Parse(Console.ReadLine());
			Console.WriteLine("Indfør ønsket datatyper, mulige datatyper: Weight, Volume, ");
			config.dataTypes = new List<string>();
			string s = Console.ReadLine();
			while (!s.Length.Equals(0))
			{
				config.dataTypes.Add(s);
				s = Console.ReadLine();
			}
			config.realativeTime = false;
			Menu menu = new Menu("Hanling");
			menu.ExitAfterInWoke = true;
			menu.AddMenuPoint(new ActionSaveConfiguration(config));
			menu.AddMenuPoint(new ActionPrintConfigurationFromData(config));
			menu.Activate();
		}
	}
}