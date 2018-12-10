using Smart_Menu;

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
			throw new System.NotImplementedException();
		}
	}
}