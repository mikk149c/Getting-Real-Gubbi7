using Smart_Menu;

namespace Gubbi7_Menu
{
	internal class ConfigurationActionMenu : IMenuPoint
	{
		private IMenuConfigController configController;
		private string name;

		public ConfigurationActionMenu(IMenuConfigController configController, string name)
		{
			this.configController = configController;
			this.name = name;
		}

		public string GetMenuPointName()
		{
			return name;
		}

		public void Invoke()
		{
			Menu actionMenu = new Menu("Handling");
			actionMenu.ExitAfterInWoke = true;
			actionMenu.AddMenuPoint(new ActionPrintConfiguration(configController, name));
			actionMenu.AddMenuPoint(new ActionScheduleConfiguration(configController, name));
			actionMenu.AddMenuPoint(new ActionDeleteConfiguration(configController, name));
			actionMenu.Activate();
		}
	}
}