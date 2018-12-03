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
			Menu ActionMenu = new Menu("Handling");
			ActionMenu.AddMenuPoint(new ActionPrintConfiguration(configController, name));
			ActionMenu.AddMenuPoint(new ActionScheduleConfiguration(configController, name));
			ActionMenu.AddMenuPoint(new ActionDeleteConfiguration(configController, name));
			ActionMenu.Activate();
		}
	}
}