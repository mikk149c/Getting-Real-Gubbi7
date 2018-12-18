using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gubbi7_Menu;
using Controllers;
using System.IO;

namespace Getting_Real_Gubbi7
{
	class Program
	{
		static void Main(string[] args)
		{
			LogfileController logfileController = new LogfileController();
			logfileController.IngestLogfile(Directory.GetCurrentDirectory());
			MainMenu menu = new MainMenu();
			menu.StartMenu();
		}
	}
}
