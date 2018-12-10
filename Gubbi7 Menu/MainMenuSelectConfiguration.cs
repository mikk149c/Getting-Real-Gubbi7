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
			Menu selectConfiguration = new Menu("Konfigurationer");
			selectConfiguration.ExitAfterInWoke = true;

			foreach (string s in configController.GetConfigurationNames())
			{

				selectConfiguration.AddMenuPoint(new ConfigurationActionMenu(configController, s));

			}

			selectConfiguration.Activate();
		}
	}
}