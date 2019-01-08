using Smart_Menu;
using Controllers;
using System;

namespace Gubbi7_Menu
{
	// der abonneres på "IMenuPoint Interface
	internal class ActionDeleteConfiguration : IMenuPoint
	{
		//oprettes tomt objekt af configcontroller
		private ConfigController configController;
		// oprettes tom string som benyttes til konfigurationsnavne i forhold til aktionen der bliver pålagt den
		private string name;

		public ActionDeleteConfiguration(string name)
			// det tomme objekt sættes = med configcontroller.instance, som er en singleton
		{
			this.configController = ConfigController.Instance;
			this.name = name;
		}

		// Giver aktionen et navn "slet"
		public string GetMenuPointName()
		{
			return "Slet";
		}
		// dette udøres når "slet" vælges.
		public void Invoke()
		{
			// Hvis if statement kravet er opfyldt (returnerer en true bool) udføres følgende kode
			if(MenuUtility.ConfirmAction($"slette {name}"))
			{
				// fjerner alle konfigurationer fra listen, hvor input string er = konfigurationsnavn
				// i listen (configRepo.Configurations)
				configController.DeleteConfiguration(name);
				// Skriver til konsollen at konfigurationen(navnet) er blevet slettet
				Console.WriteLine($"{name} blev slettet");
				Console.ReadKey();
			}
		}
	}
}