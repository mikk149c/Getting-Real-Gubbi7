using System;
using Smart_Menu;

namespace Gubbi7_Menu
{
	public class MainMenu
	{

		private Menu mainMenu;
		public MainMenu(IMenuConfigController configController, IMenuSchedualController scheduleController)
		{

			mainMenu = new Menu("Main Menu");
			mainMenu.AddMenuPoint(new MainMenuSelectConfigurationMenu(configController));
			mainMenu.AddMenuPoint(new MainMenuManualConfiguration(configController));
			mainMenu.AddMenuPoint(new MainMenuCreateConfiguration(configController));
			mainMenu.AddMenuPoint(new MainMenuSchedulePrints(scheduleController));

		}

		public void StartMenu()
		{

			mainMenu.Activate();

		}

		
	}
}
