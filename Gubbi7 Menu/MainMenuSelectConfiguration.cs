using Smart_Menu;
using Controllers;

namespace Gubbi7_Menu
{
	internal class MainMenuSelectConfigurationMenu : IMenuPoint
	{
		private ConfigController configController;

		public MainMenuSelectConfigurationMenu()
		{
			this.configController = ConfigController.Instance;
		}

		public string GetMenuPointName()
		{
			return "Vælg konfiguration";
		}

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