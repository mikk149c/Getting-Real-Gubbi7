using Smart_Menu;
using Controllers;

namespace Gubbi7_Menu
{
	internal class ActionSaveConfiguration : IMenuPoint
	{
		private ConfigurationData configurationData;

		public ActionSaveConfiguration(ConfigurationData configurationData)
		{
			this.configurationData = configurationData;
		}

		public string GetMenuPointName()
		{
			return "Gem";
		}

		public void Invoke()
		{
			ConfigController.Instance.AddConfiguration
				(
				configurationData.name,
				configurationData.startTime,
				configurationData.endTime,
				configurationData.interval,
				configurationData.dataTypes,
				configurationData.realativeTime
				);
		}
	}
}