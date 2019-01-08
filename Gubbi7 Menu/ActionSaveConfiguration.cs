using Smart_Menu;
using Controllers;

namespace Gubbi7_Menu
{
	// Abonnerer på interface "IMenuPoint" som skal indeholde 2 metoder "GetMenuPointName" og "Invoke"
	internal class ActionSaveConfiguration : IMenuPoint
	{
		private ConfigurationData configurationData;

		public ActionSaveConfiguration(ConfigurationData configurationData)
		{
			this.configurationData = configurationData;
		}
		// returnerer menupunkts navn
		public string GetMenuPointName()
		{
			return "Gem";	
		}
		//udfører ønskede funktion
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