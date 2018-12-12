using Smart_Menu;
using Controllers;

namespace Gubbi7_Menu
{
	internal class ActionDeleteConfiguration : IMenuPoint
	{
		private ConfigController configController;
		private string name;

		public ActionDeleteConfiguration(string name)
		{
			this.configController = ConfigController.Instance;
			this.name = name;
		}

		public string GetMenuPointName()
		{
			return "Delete";
		}

		public void Invoke()
		{
			if(MenuUtility.ConfirmAction($"slette {name}"))
				configController.DeleteConfiguration(name);
		}
	}
}