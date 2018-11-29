using Smart_Menu;
using Configuration_Data;

namespace Gubbi7_Menu
{
	internal class MainMenuManualConfiguration : IMenuPoint
	{
		private ConfigController configController;

		public MainMenuManualConfiguration(ConfigController configController)
		{
			this.configController = configController;
		}

		public string GetMenuPointName()
		{
			return "Manuel konfiguration";
		}

		public void Invoke()
		{
			Configuration manualConfiguration = configController.CreateConfiguration();
			configController.PrintConfiguration(manualConfiguration);
		}
	}
}