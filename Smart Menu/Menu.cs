using System;
using System.Collections.Generic;


namespace Smart_Menu
{
	public class Menu
	{
		private string mainMenuName;
		private List<IMenuPoint> menuPointList = new List<IMenuPoint>();
		private int pointer = 0;

		public string Name { get { return mainMenuName; } set { mainMenuName = value; } }

		public int OutputLine { get { return Name.Split('\n').Length + menuPointList.Count + 1; } }

		public bool ExitAfterInWoke { get; set; } = false;

		public Menu(string mainMenuName)
		{
			Name = mainMenuName;
		}
		
		public void AddMenuPoint(IMenuPoint menuPoint)
		{
			menuPointList.Add(menuPoint);
		}
		// Denne metode står basically for at skrive menuen til konsollen, hvor menuen tilrettes efter hvert bruger input.
		public void Activate()
		{
			DisplayMenu();
			if (!menuPointList.Count.Equals(0))
			{
				ConsoleKey key;
				do
				{
					key = Console.ReadKey(true).Key;
					switch (key)
					{
						case ConsoleKey.UpArrow:
							MovePointerUp();
							break;
						case ConsoleKey.DownArrow:
							MovePointerDown();
							break;
						case ConsoleKey.Enter:
							Console.Clear();
							menuPointList[pointer].Invoke();
							DisplayMenu();
							break;
					}
				}
				// Hvis key IKKE er = Escape + IKKE er = med Enter + hviss ExitAfterInWoke er false kører dette loop
				while (!key.Equals(ConsoleKey.Escape) && !( key.Equals(ConsoleKey.Enter) && ExitAfterInWoke) );
			
			}
			else
			//fejlmelding, ingen menupunkter indlæst
			{
				Console.WriteLine("Der er ingen menupunkter");
				Console.ReadKey();
			}
			Console.Clear();
		}

		private void MovePointerDown()
		{
			MovePointer(1);
		}

		private void MovePointerUp()
		{
			MovePointer(-1);
		}

		private void MovePointer(int v)
		{
			// temp1 sættes = original pointer værdi
			int PointerTemp1 = pointer;
			// pointer adderes med input parameter (kan være +1 eller -1)
			pointer += v;
			// Hvis pointer er mindre end nul, sættes pointer = 0
			if (pointer < 0)
			pointer = 0;
			// Hvis pointer mere end menulistpunkter -1, så sættes pointer til menupunktcount -1 )
			// dette sørger for at markeringen aldrig går udover menuen.
			if (pointer > menuPointList.Count - 1)
				pointer = menuPointList.Count - 1;
			// Temp2 sættes = pointer += v eller menupointlist.count -1 kan være mellem 0 og 4ish
			int PointerTemp2 = pointer;
			// hvis temp1 (original værdi) ikke er = temp2 (ændret værdi) temp1 skrives til sort baggrund, temp2
			// skrives til blå baggrund.
			if (!PointerTemp1.Equals(PointerTemp2))
			{
				UpdateMenuPoint(PointerTemp1);
				UpdateMenuPoint(PointerTemp2);
			}
			Console.SetCursorPosition(0, OutputLine); 
		}

		private void UpdateMenuPoint(int i)
		{
			int MenuLineCount = Name.Split('\n').Length;
			Console.SetCursorPosition(0, MenuLineCount + i);
			DisplaySelect(i);
		}

		private void DisplayMenu()
		{
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			Console.CursorVisible = false;
			Console.WriteLine(mainMenuName);
			MenuPointCount();
		}
		//Skriver til Konsollen
		private void MenuPointCount()
		{
			for (int i = 0; i < menuPointList.Count; i++)
			{
				DisplaySelect(i);
			}
		}

		private void DisplaySelect(int i)
		{
			if (i.Equals(pointer))
			{
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.WriteLine(menuPointList[i].GetMenuPointName());
				Console.BackgroundColor = ConsoleColor.Black;
			}
			else
			{
				Console.WriteLine(menuPointList[i].GetMenuPointName());
			}
			
		}

	}
}
