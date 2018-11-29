using Smart_Menu;
using Configuration_Data;

namespace Gubbi7_Menu
{
	internal class MainMenuCreateConfiguration : IMenuPoint
	{
		private ConfigController configController;

		public MainMenuCreateConfiguration(ConfigController configController)
		{
			this.configController = configController;
		}

		public string GetMenuPointName()
		{
			return "Ny konfiguration";
		}

		public void Invoke()
		{
			Configuration configuration = configController.CreateConfiguration();
			configController.AddConfiguration(configuration);
		}
	}
}