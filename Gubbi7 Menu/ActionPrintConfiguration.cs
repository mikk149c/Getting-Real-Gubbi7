using Smart_Menu;
using Controllers;
using System;

namespace Gubbi7_Menu
{
	// der abonneres på "IMenuPoint Interface
	internal class ActionPrintConfiguration : IMenuPoint
	{
		//oprettes tomt objekt af configcontroller
		private ConfigController configController;
		// oprettes tom string som benyttes til konfigurationsnavne i forhold til aktionen der bliver pålagt den
		private string name;

		public ActionPrintConfiguration(string name)
		{
			// det tomme objekt sættes = med configcontroller.instance, som er en singleton
			this.configController = ConfigController.Instance;
			this.name = name;
		}

		public string GetMenuPointName()
		// Giver aktionen et navn "Print"
		{
			return "Print";
		}
		// dette udøres når "slet" vælges.
		public void Invoke()
		{
		
			Console.WriteLine("Printing file");
			// skriver valgte konfiguration til en txt fil i current directory (debug mappen)
			configController.PrintConfiguration(name);
		}
	}
}