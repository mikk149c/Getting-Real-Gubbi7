using Smart_Menu;

namespace Gubbi7_Menu
{
	internal class ActionPrintConfiguration : IMenuPoint
	{
		private IMenuConfigController configController;
		private string name;

		public ActionPrintConfiguration(IMenuConfigController configController, string name)
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