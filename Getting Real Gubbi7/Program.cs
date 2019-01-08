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
			// instansierer logfilecontroller klassen hvorefter metoden "IngestLogfile" fra klassen udføres med en metode som input
			// metoden "GetCurrentDirectory()" kommer fra klassen "Directory" som er en base klasse.
			LogfileController logfileController = new LogfileController();
			logfileController.IngestLogfile(Directory.GetCurrentDirectory());
			// MainMenu klassen instansieres, hvorefter der et metodekald på "StartMenu()
			MainMenu menu = new MainMenu();
			menu.StartMenu();
		}
	}
}
