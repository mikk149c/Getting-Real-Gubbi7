using Smart_Menu;
using Controllers;

namespace Gubbi7_Menu
{
	internal class SelectConfigurationMenu : IMenuPoint
	{
		// SINGLETON
		private ConfigController configController;

		public SelectConfigurationMenu()
		{
			this.configController = ConfigController.Instance;
		}
		// menunavn
		public string GetMenuPointName()
		{
			return "Vælg konfiguration";
		}
		// henter de relevante navne for den pågældende menu og printer den til konsollen via Avtivate metoden.
		public void Invoke()
		{
			Menu selectConfiguration = new Menu("Konfigurationer");
			selectConfiguration.ExitAfterInWoke = true;

			foreach (string s in configController.GetConfigurationNames())
			{

				selectConfiguration.AddMenuPoint(new ConfigurationActionMenu(s));

			}

			selectConfiguration.Activate();
		}
	}
}