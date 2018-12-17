using Smart_Menu;
using Controllers;

namespace Gubbi7_Menu
{
	internal class ActionPrintConfigurationFromData : IMenuPoint
	{
		private ConfigurationData config;

		public ActionPrintConfigurationFromData(ConfigurationData config)
		{
		}

		public string GetMenuPointName()
		{
			return "Print";
		}

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