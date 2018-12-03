using Smart_Menu;

namespace Gubbi7_Menu
{
	internal class MainMenuSelectConfigurationMenu : IMenuPoint
	{
		private IMenuConfigController configController;

		public MainMenuSelectConfigurationMenu(IMenuConfigController configController)
		{
			this.configController = configController;
		}

		public string GetMenuPointName()
		{
			return "Vælg konfiguration";
		}

		public void Invoke()
		{
			Menu SelectConfiguration = new Menu("Konfigurationer");

			foreach (string s in configController.GetConfigurationNames())
			{

				SelectConfiguration.AddMenuPoint(new ConfigurationActionMenu(configController, s));

			}

			SelectConfiguration.Activate();
		}
	}
}