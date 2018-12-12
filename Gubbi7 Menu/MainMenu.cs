using System;
using Smart_Menu;

namespace Gubbi7_Menu
{
	public class MainMenu
	{

		private Menu mainMenu;
		public MainMenu()
		{
			mainMenu = new Menu("Main Menu");
			mainMenu.AddMenuPoint(new MainMenuSelectConfigurationMenu());
			mainMenu.AddMenuPoint(new MainMenuCreateConfiguration());
			mainMenu.AddMenuPoint(new MainMenuSchedulePrints());
		}

		public void StartMenu()
		{

			mainMenu.Activate();

		}
	}
}
