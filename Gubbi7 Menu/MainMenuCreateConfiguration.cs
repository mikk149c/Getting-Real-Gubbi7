using Smart_Menu;
using System;

namespace Gubbi7_Menu
{
	struct ConfigurationData {

	}
	internal class MainMenuCreateConfiguration : IMenuPoint
	{
		private IMenuConfigController configController;

		public MainMenuCreateConfiguration()
		{
			this.configController = configController;
		}

		public string GetMenuPointName()
		{
			return "Ny konfiguration";
		}

		public void Invoke()
		{
			Console.WriteLine("Infør data");
			Console.ReadLine();
			Menu menu = new Menu("Hanling");
			menu.AddMenuPoint(new ActionSaveConfiguration(new ConfigurationData()));
			menu.AddMenuPoint(new ActionPrintConfiguration(new ConfigurationData()));
			menu.Activate();
		}
	}
}