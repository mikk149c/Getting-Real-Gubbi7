using Smart_Menu;
using System;
using System.Collections.Generic;
using Controllers;

namespace Gubbi7_Menu
{
	// Struct defineres som en datapakke med datatyper som kan brugerdefineres for en konfiguration af brugeren.
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
		// gør absolut ingenting, overflødig
		public MainMenuCreateConfiguration()
		{
		}
		// sætter navnet for menupunktet
		public string GetMenuPointName()
		{
			return "Ny konfiguration";
		}
		
		public void Invoke()
		{
			// nyt config objekt oprettes.
			ConfigurationData config = new ConfigurationData();
			// forskellige datatyper udfyldes af brugeren.
			Console.WriteLine("Indfør konfiguration navn");
			config.name = Console.ReadLine();
			Console.WriteLine("Indfør start dato, format: dd-MM-yyyy");
			config.startTime = DateTime.Parse(Console.ReadLine());
			Console.WriteLine("Indfør slut dato, format: dd-MM-yyyy");
			config.endTime = DateTime.Parse(Console.ReadLine());
			Console.WriteLine("Indfør interval tid, format: d.tt:mm:ss");
			config.interval = TimeSpan.Parse(Console.ReadLine());
			Console.WriteLine("Indfør ønsket datatyper");
			// Skriver datatyper til konsollen som er i overensstemmelse med input string fra brugeren.
			config.dataTypes = new List<string>();
			string s = "";
			MenuUtility.SearchMenu(ConfigController.Instance.GetDataTypes(), out s);
			while (!s.Length.Equals(0))
			{
				config.dataTypes.Add(s);
				MenuUtility.SearchMenu(ConfigController.Instance.GetDataTypes(), out s);
			}
			// stubkode, ikke implementeret
			config.realativeTime = false;
			Menu menu = new Menu("Handling");
			menu.ExitAfterInWoke = true;
			// opretter menupunkter for den nye konfiguration.
			menu.AddMenuPoint(new ActionSaveConfiguration(config));
			menu.AddMenuPoint(new ActionPrintConfigurationFromData(config));
			menu.Activate();
		}
	}
}