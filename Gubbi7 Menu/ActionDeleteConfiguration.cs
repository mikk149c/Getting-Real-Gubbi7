using Smart_Menu;

namespace Gubbi7_Menu
{
	internal class ActionDeleteConfiguration : IMenuPoint
	{
		private IMenuConfigController configController;
		private string name;

		public ActionDeleteConfiguration(IMenuConfigController configController, string name)
		{
			this.configController = configController;
			this.name = name;
		}

		public string GetMenuPointName()
		{
			return "Delete";
		}

		public void Invoke()
		{
			configController.DeleteConfiguration(name);
		}
	}
}