using Smart_Menu;

namespace Gubbi7_Menu
{
	internal class ConfigurationActionMenu : IMenuPoint
	{
		private string name;

		public ConfigurationActionMenu(string name)
		{
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
			actionMenu.AddMenuPoint(new ActionPrintConfiguration(name));
			actionMenu.AddMenuPoint(new ActionScheduleConfiguration(name));
			actionMenu.AddMenuPoint(new ActionDeleteConfiguration(name));
			actionMenu.Activate();
		}
	}
}