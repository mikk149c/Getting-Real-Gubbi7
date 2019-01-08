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
			mainMenu.AddMenuPoint(new SelectConfigurationMenu());
			mainMenu.AddMenuPoint(new MainMenuCreateConfiguration());
			mainMenu.AddMenuPoint(new MainMenuSchedulePrints());
		}
		//foretager et kald til metoden "Activate() som befinder sig i menu klassen
		public void StartMenu()
		{

			mainMenu.Activate();

		}
	}
}
