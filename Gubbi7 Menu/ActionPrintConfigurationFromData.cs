using Smart_Menu;
using Controllers;

namespace Gubbi7_Menu
{
	internal class ActionPrintConfigurationFromData : IMenuPoint
	{
		// Der oprettes privat objekt med klassen som kaldes "config"
		private ConfigurationData config;

		// Der oprettes en metode som sætter tidligere oprettede objekt = objekt config fra "ConfigurationData" klassen
		// Dette er et objekt indeholder forskellige datatyper:
		/* public string name;
		public DateTime startTime;
		public DateTime endTime;
		public TimeSpan interval;
		public List<string> dataTypes;
		public bool realativeTime; */
		public ActionPrintConfigurationFromData(ConfigurationData config)
		{
			this.config = config;
		}
		// returnerer menupunkts navn
		public string GetMenuPointName()
		{
			return "Print";
		}
		// Printer konfiguration udfra brugerdefineret input. False betegner relativtid, hvilket er en ikke implementeret
		// metode
		public void Invoke()
		{
			ConfigController.Instance.PrintConfiguration(
				config.name,
				config.startTime,
				config.endTime,
				config.interval,
				config.dataTypes,
				false
				);
		}
	}
}