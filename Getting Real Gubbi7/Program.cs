using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gubbi7_Menu;

namespace Getting_Real_Gubbi7
{
	class Program
	{
		static void Main(string[] args)
		{
			ConfigController configController = new ConfigController();
			SchedualController schedualController = new SchedualController();
			MainMenu menu = new MainMenu();
			menu.StartMenu();
		}
	}
}
