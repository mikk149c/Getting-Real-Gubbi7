using Smart_Menu;

namespace Gubbi7_Menu
{
	internal class ActionPrintConfiguration : IMenuPoint
	{
		private ConfigController configController;
		private string name;

		public ActionPrintConfiguration(ConfigController configController, string name)
		{
			this.configController = configController;
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