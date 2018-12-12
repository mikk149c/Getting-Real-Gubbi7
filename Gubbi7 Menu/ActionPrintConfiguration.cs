using Smart_Menu;
using Controllers;

namespace Gubbi7_Menu
{
	internal class ActionPrintConfiguration : IMenuPoint
	{
		private ConfigController configController;
		private string name;
		private ConfigurationData configurationData;

		public ActionPrintConfiguration(ConfigurationData configurationData)
		{
			configurationData = configurationData;
		}

		public ActionPrintConfiguration(string name)
		{
			this.configController = ConfigController.Instance;
			this.name = name;
		}

		public string GetMenuPointName()
		{
			return "Print";
		}

		public void Invoke()
		{
			configController.PrintConfiguration(name);
		}
	}
}