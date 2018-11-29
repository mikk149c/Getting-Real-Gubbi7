﻿using Smart_Menu;

namespace Gubbi7_Menu
{
	internal class ConfigurationActionMenu : IMenuPoint
	{
		private ConfigController configController;
		private string name;

		public ConfigurationActionMenu(ConfigController configController, string name)
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
		}
	}
}