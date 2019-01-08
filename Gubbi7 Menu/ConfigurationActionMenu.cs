using Smart_Menu;

namespace Gubbi7_Menu
{
	internal class ConfigurationActionMenu : IMenuPoint
	{
		private string name;

		// Metode der sætter private string "name" = input string
		public ConfigurationActionMenu(string name)
		{
			this.name = name;
		}
		// returnerer private string
		public string GetMenuPointName()
		{
			return name;
		}
		// Handlingsmenuen for valgte konfiguration
		public void Invoke()
		{
			// opretter et objekt med en string for navnet af menuen
			Menu actionMenu = new Menu("Handling");
			// sætter en bool værdi til true
			actionMenu.ExitAfterInWoke = true;
			// Her hentes objekterne og deres tilhørende funktioner hvor (name) beskriver funktionen.
			actionMenu.AddMenuPoint(new ActionPrintConfiguration(name));
			actionMenu.AddMenuPoint(new ActionScheduleConfiguration(name));
			actionMenu.AddMenuPoint(new ActionDeleteConfiguration(name));
			// Denne metode printer menuen til konsollen.
			actionMenu.Activate();
		}
	}
}