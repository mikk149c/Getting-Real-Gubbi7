using System;
using System.IO;
using CoreDataStructure;

namespace Controllers
{
	public class LogfileController
	{

		public void IngestLogfile(string path)
		{
			// Der hentes en instans af ParcelDataController vha. en singleton (hvis ingen instansiering af klassen eksisterer
			//laves en instans, hvis den eksisterer i forvejen returnerer den, en tidligere lavet en instans)
			ParcelDataController parcelData = ParcelDataController.Instance;
			// Henter tekstfiler i currentDirectory (hvilket er mappen programmet ligger i atm) og indlæser alle tekstfilerne
			// som starter med "Taulov" På denne måde indlæses alle relevante tekst filer der er i mappen (udføres på alle
			// pga. foreach loopet)
			foreach (string s in Directory.GetFiles(Directory.GetCurrentDirectory(), "Taulov*.txt"))
			{
				//skriver indlæsningsprocessen til konsollen (visuelt kan brugeren se der udføres noget)
				Console.WriteLine(s);
				// alle linjer i filen indlæses i et array. udføres på tekstfilen "s" som indeholder en hel tekstfil.
				string[] lines = File.ReadAllLines(s);
				// forloop starter med i = 4 pga. de 4 første linjer ikke indeholder relevant data der skal indlæses
				for (int i = 4; i < lines.Length; i++)
				{
					// forskellige dataværdier der indlæses defineres.
					int weight, length, height, width;
					// der oprettes et string array for hver linje i "lines" arrayet, Dette array dannes ved at splitte
					// linjen over "tab" karakterer, da de adskiller den ønskede information i de originale tekstfiler.
					string[] tabs = lines[i].Split('\t');
					// Herefter "parses" de forskellige informationer til de prædefinerede værdier
					// fx vil indeks 3 i arrayet altid være en "length" værditype.
					DateTime date = DateTime.Parse(tabs[0]);
					string termianlId = tabs[1];
					weight = ParsData(tabs[2]);
					length = ParsData(tabs[3]);
					height = ParsData(tabs[4]);
					width = ParsData(tabs[5]);
					parcelData.RegisterParcel(termianlId, date, weight, length, height, width);
				}
			}
		}
		// metode der parser string "s" til en int hvis string givet ikke har en længde på 0 karakterer.
		// ellers returneres "0"
		private int ParsData(string s)
		{
			if (!s.Length.Equals(0))
				return int.Parse(s);
			else
				return 0;
		}
	}
}