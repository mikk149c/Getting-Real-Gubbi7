using System;

namespace CoreDataStructure
{
	internal class Parcel
	{
		private DateTime time;
		private int weight;
		private int height;
		private int width;
		private int length;

		public int Weight { get { return weight; } set { weight = value; } }
		public int Height { get { return height; } set { height = value; } }
		public int Width { get { return width; } set { width = value; } }
		public int Length { get { return length; } set { length = value; } }
		public DateTime Time { get => time; set => time = value; }

		internal int GetVolume()
		{
			return Height * Width * Length;
		}
	}
}