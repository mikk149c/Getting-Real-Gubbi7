using Smart_Menu;
using Controllers;

namespace Gubbi7_Menu
{
	internal class ActionScheduleConfiguration : IMenuPoint
	{
		// Hentes instans af Singleton "ConfigController"
		private ConfigController configController;
		private string name;

		public ActionScheduleConfiguration(string name)
		{
			this.configController = ConfigController.Instance;
			this.name = name;
		}
		// menupunktsnavn
		public string GetMenuPointName()
		{
			return "Planlæg";
		}
		// Her er en ikke implementeret metode for regulært print af en konfiguration.
		public void Invoke()
		{
			configController.ScheduleConfiguration(name);
		}
	}
}